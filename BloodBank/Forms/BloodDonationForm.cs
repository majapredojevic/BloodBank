using System;
using System.Collections.Generic;
using System.Configuration;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BloodBank.Data.Model;
using System.Resources;
using System.Text.RegularExpressions;

namespace BloodBank.Forms
{
    public partial class BloodDonationForm : Form
    {
        ResourceManager rm;
        private readonly string username;
        Employee doctor = new Employee();
        BloodDonor donor = new BloodDonor();
        bool addNewItem = false;
        int id = 0;
        public BloodDonationForm(string username)
        {
            this.username = username;
            rm = new ResourceManager("BloodBank.Resources.Strings", System.Reflection.Assembly.GetExecutingAssembly());
            
            InitializeComponent();
            DisableControls();
            
            FillBoxes();
            dgvBloodDonation.Columns["DateTime"].DefaultCellStyle.Format = ConfigurationManager.AppSettings["DateTimeFormat"];
            FillBloodDonationDataGridView();
        }


        private void FillBloodDonationDataGridView()
        {
            dgvBloodDonation.Rows.Clear();
            var donations = Util.Common.DataFactory.BloodDonation.GetBloodDonations(tbFilter.Text);
            foreach (var d in donations)
            {

                DataGridViewRow row = new DataGridViewRow()
                {
                    Tag = d
                };
                row.CreateCells(dgvBloodDonation,d.Id,
                                                 d.BloodBag.Id,
                                                 d.BloodBag.Capacity,
                                                 d.Donor.ToString(),
                                                 d.Donor.Person.JMBG,
                                                 d.Hemoglobin,
                                                 d.BloodPressure,
                                                 d.Pulse,
                                                 d.HealthCondition,
                                                 d.DateOfDonation,
                                                 d.Doctor.ToString(),
                                                 d.Office.Name
                                              
                                                );
                dgvBloodDonation.Rows.Add(row);
            }

            DisableControls();

          

        }


    
    private void FillBoxes()
        {
            doctor = Util.Common.DataFactory.Accounts.GetEmployeeByUsername(username);
            lblDoctor.Text = doctor.ToString();

            var offices = Util.Common.DataFactory.Offices.GetOffices();
            foreach (var o in offices)
            {
                cbOffice.Items.Add(o.ToString());
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            tbJMBG.Text.Trim();

            if (tbJMBG.TextLength == 13)
            {
                List<BloodDonor> donors = Util.Common.DataFactory.BloodDonor.GetBloodDonors(tbJMBG.Text);
                if (donors.Count == 1)
                {
                    foreach (var d in donors)
                    {
                        donor.Person = new Person()
                        {
                            Id = d.Person.Id,
                            FirstName = d.Person.FirstName,
                            LastName = d.Person.LastName
                        };

                        tbFirstName.Text = donor.Person.FirstName;
                        tbLastName.Text = donor.Person.LastName;
                        

                    }
                }
                else
                {
                    MessageBox.Show(rm.GetString("DonorNotFound"),rm.GetString("Notification"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ClearTextBoxes();
                        
                }
            }
            else
            {
                MessageBox.Show(rm.GetString("EnterData"), rm.GetString("Notification"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ClearTextBoxes();
            }
        }

            

        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.AutoScrollPosition = new Point(1076, 796);

            addNewItem = true;
            ClearTextBoxes();
            dgvBloodDonation.Enabled = false;
            pnlFilter.Enabled = false;
            EnableControls();
            
        }


        private void tbJMBG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void tbBloodPreasure_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != '/'))
                e.Handled = true;
        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            FillBloodDonationDataGridView();
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlFilter.Enabled = false;
            dgvBloodDonation.Enabled = false;
            EnableControls();
            gbBloodDonation.Enabled = false;
            btnSearch.Enabled = false;
            tbJMBG.Enabled = false;
            addNewItem = false;
            ShowData();
        }
        private void ShowData()
        {
            var selectedRow = dgvBloodDonation.SelectedRows[0];
            id = Int32.Parse(selectedRow.Cells[1].Value.ToString());
            var regex = new Regex(@"^\b(\w+)\b(.*)\b(\w+)\b");
            Match match = regex.Match(selectedRow.Cells[3].Value.ToString());
            tbFirstName.Text = match.Groups[1].Value;
            tbLastName.Text = match.Groups[3].Value;
            tbJMBG.Text = selectedRow.Cells[4].Value.ToString();
            tbHemoglobin.Text = selectedRow.Cells[5].Value.ToString();
            tbBloodPressure.Text = selectedRow.Cells[6].Value.ToString();
            tbPulse.Text = selectedRow.Cells[7].Value.ToString();
            tbHealthCondition.Text = selectedRow.Cells[8].Value.ToString();
            cbOffice.Text = selectedRow.Cells[11].Value.ToString();
            tbCapacity.Text = selectedRow.Cells[2].Value.ToString();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DisableControls();
            ClearTextBoxes();
            pnlFilter.Enabled = true;
            dgvBloodDonation.Enabled = true;
            btnAdd.Enabled = true;
        }

       
        private void btnSave_Click(object sender, EventArgs e)
        {
            
            TrimTextBoxes();

            if (tbFirstName.Text.Equals("") || tbHemoglobin.Text.Equals("") || tbPulse.Text.Equals("") || tbBloodPressure.Text.Equals("") ||
                lblDoctor.Text.Equals("") || cbOffice.Text.Equals("") || tbCapacity.Text.Equals(""))
            {
                MessageBox.Show(rm.GetString("EnterData"),rm.GetString("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (addNewItem)
            {
                try
                { 
                   int id= Util.Common.DataFactory.BloodDonation.InsertBloodDonation(new BloodDonation()
                    {
                        Hemoglobin = Convert.ToInt32(tbHemoglobin.Text),
                        BloodPressure = tbBloodPressure.Text,
                        Pulse = Convert.ToInt32(tbPulse.Text),
                        HealthCondition = tbHealthCondition.Text,
                        Donor = donor,
                        Doctor = doctor,
                        Office = new Office()
                        {
                            Id = Util.Common.DataFactory.Offices.GetOfficeByName(cbOffice.Text)
                        },
                        BloodBag = new BloodBag()
                        {
                            Capacity = Convert.ToInt32(tbCapacity.Text)

                        }
                    }) ;

                    pnlFilter.Enabled = true;
                    dgvBloodDonation.Enabled = true;
                    DisableControls();
                    ClearTextBoxes();
                    MessageBox.Show(rm.GetString("AddedSuccessfully"), rm.GetString("Notification"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FillBloodDonationDataGridView();
                    SelectRow(id);
                }
                catch
                {
                    MessageBox.Show(rm.GetString("AddedUnsuccessfully"), rm.GetString("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
               try
                 { 
                    
                    Util.Common.DataFactory.BloodDonation.UpdateBloodDonation(new BloodDonation()
                    {
                        Id = Convert.ToInt32(dgvBloodDonation.SelectedRows[0].Cells[0].Value),
                        Hemoglobin = Convert.ToInt32(tbHemoglobin.Text),
                        BloodPressure = tbBloodPressure.Text,
                        Pulse = Convert.ToInt32(tbPulse.Text),
                        HealthCondition = tbHealthCondition.Text,
                        BloodBag = new BloodBag()
                        {  
                            Id = Convert.ToInt32(dgvBloodDonation.SelectedRows[0].Cells[1].Value),
                            Capacity = Convert.ToInt32(tbCapacity.Text)

                        }
                    }) ;
                    pnlFilter.Enabled = true;
                    dgvBloodDonation.Enabled = true;
                    DisableControls();
                    ClearTextBoxes();
                     MessageBox.Show(rm.GetString("EditedSuccessfully"), rm.GetString("Notification"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                     FillBloodDonationDataGridView();
                     SelectRow(id);
                 }
                 catch
                 {
                     MessageBox.Show(rm.GetString("EditedUnsuccessfully"), rm.GetString("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }

            }

        }


        private void TrimTextBoxes()
        {
            tbFirstName.Text.Trim();
            tbLastName.Text.Trim();
            tbJMBG.Text.Trim();
            tbHemoglobin.Text.Trim();
            tbPulse.Text.Trim();
            tbBloodPressure.Text.Trim();
            tbHealthCondition.Text.Trim();
            tbCapacity.Text.Trim();

        }

        private void ClearTextBoxes()
        {
            tbFirstName.Text = "";
            tbLastName.Text = "";
            tbJMBG.Text = "";
            tbHemoglobin.Text = "";
            tbPulse.Text = "";
            tbBloodPressure.Text = "";
            tbHealthCondition.Text = "";
            tbCapacity.Text = "";
        }
        private void DisableControls()
        {
            gbBloodDonor.Enabled = false;
            gbBloodDonation.Enabled = false;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
        }

        private void EnableControls()
        {

            gbBloodDonor.Enabled = true;
            gbBloodDonation.Enabled = true;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;

        }
        private void SelectRow(int idBloodBag)
        {
            foreach (DataGridViewRow row in dgvBloodDonation.Rows)
            {
                if (row.Cells[1].Value.Equals(idBloodBag))
                {
                    row.Selected = true;
                    dgvBloodDonation.FirstDisplayedScrollingRowIndex = row.Index;
                   
                }

             }
        }

       
    }
}
