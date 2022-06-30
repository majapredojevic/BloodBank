using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using BloodBank.Data.Model;
using System.Resources;

namespace BloodBank.Forms
{
    public partial class BloodDonorsForm : Form
    {
        private bool addNewItem = false;
        private List<BloodDonor> donors = new List<BloodDonor>();
        private int selectedPosition = -1;
        ResourceManager rm;
        public BloodDonorsForm()
        {
            rm = new ResourceManager("BloodBank.Resources.Strings", System.Reflection.Assembly.GetExecutingAssembly());
            InitializeComponent();
            FillComboBoxes();
            FillBloodDonorsDataGridView();
        }

        private void FillComboBoxes()
        {
            var rHFactors = Util.Common.DataFactory.RHFactor.GetRHFactors();
            foreach (var r in rHFactors)
            {
                cbRH.Items.Add(r);
                
            }

            var bloodTypes = Util.Common.DataFactory.BloodType.GetBloodTypes();
            foreach (var t in bloodTypes)
            {
                cbBloodType.Items.Add(t);
            }
        }
        private void FillBloodDonorsDataGridView()
        {
            dgvBloodDonors.Rows.Clear();
            donors.Clear();
            donors = Util.Common.DataFactory.BloodDonor.GetBloodDonors(tbFilter.Text);
            foreach (var d in donors)
            {
               
                DataGridViewRow row = new DataGridViewRow()
                {
                    Tag = d
                };

                
                row.CreateCells(dgvBloodDonors, d.Person.FirstName,
                                                d.FathersName,
                                                d.Person.LastName,
                                                d.Person.JMBG,
                                                d.BloodType.Name,
                                                d.RHFactor.Name,
                                                d.Person.Phone,
                                                d.Person.Email,
                                                d.Person.Address.ToString(),
                                                d.NumberOfDonations
                                              );
                dgvBloodDonors.Rows.Add(row);
            }

            DisableControls();
            
            if (dgvBloodDonors.RowCount == 0)
                contextMenuStrip1.Enabled = false;
          
        }


        private void ShowData()
        {

            btnAdd.Enabled = false;
            EnableControls();
            tbFathersName.Enabled = false;
            tbJMBG.Enabled = false;



            var selectedRow = dgvBloodDonors.SelectedRows[0];
            selectedPosition = selectedRow.Index;
            tbFirstName.Text = selectedRow.Cells[0].Value.ToString();
            tbFathersName.Text = selectedRow.Cells[1].Value.ToString();
            tbLastName.Text = selectedRow.Cells[2].Value.ToString();
            tbJMBG.Text = selectedRow.Cells[3].Value.ToString();
            cbBloodType.Text = selectedRow.Cells[4].Value.ToString();
            cbRH.Text = selectedRow.Cells[5].Value.ToString();
            tbPhone.Text = selectedRow.Cells[6].Value.ToString();
            tbEmail.Text = selectedRow.Cells[7].Value.ToString();
            var regex = new Regex(@"([\D+]*) ([\d]*), ([\d]*).([\D]*), ([\D+' ']*)");
            Match match = regex.Match(selectedRow.Cells[8].Value.ToString());
            tbStreet.Text = match.Groups[1].Value;
            tbStreetNumber.Text = match.Groups[2].Value;
            tbCity.Text = match.Groups[4].Value;
            tbPostalCode.Text = match.Groups[3].Value;
            tbState.Text = match.Groups[5].Value;
        }

           

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            FillBloodDonorsDataGridView();
        }

      

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.AutoScrollPosition = new Point(781, 380);
           
            pnlFilter.Enabled = false;
            dgvBloodDonors.Enabled = false;

            tbFathersName.Enabled = true;
            tbJMBG.Enabled = true;
            EnableControls();
            ClearTextBoxes();
            addNewItem = true;
        }

      

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlFilter.Enabled = false;
            dgvBloodDonors.Enabled = false;
            addNewItem = false;
            ShowData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            
            DisableControls();
            ClearTextBoxes();
            pnlFilter.Enabled = true;
            contextMenuStrip1.Enabled = true;
            dgvBloodDonors.Enabled = true;
            btnAdd.Enabled = true;
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        { 
         var selectedRow = dgvBloodDonors.SelectedRows[0];
            selectedPosition = selectedRow.Index;

        var result = MessageBox.Show(rm.GetString("DeleteWarning"),rm.GetString("Warning"), MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result.Equals(DialogResult.Yes))
            {
                try
                {
                    Util.Common.DataFactory.BloodDonor.DeleteBloodDonorById(donors[selectedPosition].Person.Id);
                    MessageBox.Show(rm.GetString("DeleteSuccessfully"), rm.GetString("Notification"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FillBloodDonorsDataGridView();
    }
                catch
                {
                    MessageBox.Show(rm.GetString("DeleteUnsuccessfully"),rm.GetString("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

        }

       
       
        private void btnSave_Click(object sender, EventArgs e)
        {
           
            TrimTextBoxes();

            

            if (tbFirstName.Text.Equals("") || tbLastName.Text.Equals("")|| tbJMBG.Text.Equals("") || tbJMBG.TextLength !=13
                 || tbState.Text.Equals("") || tbCity.Text.Equals("") || tbPostalCode.Text.Equals("") || tbStreet.Text.Equals("") || tbStreetNumber.Text.Equals(""))
                MessageBox.Show(rm.GetString("EnterData"), rm.GetString("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
           
            else if (addNewItem == true)
            {
                try
                {
                    Util.Common.DataFactory.BloodDonor.InsertBloodDonor(new BloodDonor()
                    {
                        Person = new Person()
                        {
                            FirstName = tbFirstName.Text,
                            LastName = tbLastName.Text,
                            JMBG = tbJMBG.Text,
                            Phone = tbPhone.Text,
                            Email = tbEmail.Text,
                            Address = new Address()
                            {
                                State = tbState.Text,
                                City = tbCity.Text,
                                PostalCode = tbPostalCode.Text,
                                Street = tbStreet.Text,
                                StreetNumber = tbStreetNumber.Text
                            }
                        },
                        FathersName = tbFathersName.Text,
                        RHFactor = new RHFactor()
                        {
                            Name = cbRH.Text
                        },
                        BloodType = new BloodType()
                        {
                            Name = cbBloodType.Text
                        }
                    } );
                    pnlFilter.Enabled = true;
                    dgvBloodDonors.Enabled = true;
                    DisableControls();
                    btnAdd.Enabled = true;
                    MessageBox.Show(rm.GetString("AddedSuccessfully"), rm.GetString("Notification"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FillBloodDonorsDataGridView();
                    SelectDonor(tbJMBG.Text);
                    ClearTextBoxes();
      
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
                    var selectedRow = dgvBloodDonors.SelectedRows[0];
                    selectedPosition = selectedRow.Index;
                    var regex = new Regex(@"([\D+]*) ([\d]*), ([\d]*).([\D]*), ([\D+' ']*)");
                    Match match = regex.Match(selectedRow.Cells[8].Value.ToString());
                   
                    Util.Common.DataFactory.BloodDonor.UpdateBloodDonor(new BloodDonor()
                    {
                        Person = new Person()
                        {
                            Id = donors[selectedPosition].Person.Id,
                            FirstName = tbFirstName.Text,
                            LastName = tbLastName.Text,
                            JMBG = tbJMBG.Text,
                            Phone = tbPhone.Text,
                            Email = tbEmail.Text,
                            Address = new Address()
                            { 
                                Id = Util.Common.DataFactory.BloodDonor.CheckIfAddressExist(match.Groups[5].Value, match.Groups[4].Value, match.Groups[3].Value,match.Groups[1].Value,match.Groups[2].Value),
                                State = tbState.Text,
                                City = tbCity.Text,
                                PostalCode = tbPostalCode.Text,
                                Street = tbStreet.Text,
                                StreetNumber = tbStreetNumber.Text
                            }
                        },
                        FathersName = tbFathersName.Text,
                        RHFactor = new RHFactor()
                        {
                            Name = cbRH.Text
                        },
                        BloodType = new BloodType()
                        {
                            Name = cbBloodType.Text
                        }
                    }) ;
                    pnlFilter.Enabled = true;
                    dgvBloodDonors.Enabled = true;
                    DisableControls();
                    btnAdd.Enabled = true;
                    MessageBox.Show(rm.GetString("EditedSuccessfully"), rm.GetString("Notification"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FillBloodDonorsDataGridView();
                    SelectDonor(tbJMBG.Text);
                    ClearTextBoxes();

                }
                catch
                {
                    MessageBox.Show(rm.GetString("EditedUnsuccessfully"), rm.GetString("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tbPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }


        private void ClearTextBoxes()
        {
            tbFirstName.Text = "";
            tbLastName.Text = "";
            tbFathersName.Text = "";
            tbJMBG.Text = "";
            tbPhone.Text = "";
            tbEmail.Text = "";
            cbBloodType.Text = "";
            cbRH.Text = "";
            tbState.Text = "";
            tbPostalCode.Text = "";
            tbStreet.Text = "";
            tbStreetNumber.Text = "";
            tbCity.Text = "";
        }

        private void TrimTextBoxes()
        {
            tbFirstName.Text.Trim();
            tbLastName.Text.Trim();
            tbFathersName.Text.Trim();
            tbJMBG.Text.Trim();
            cbBloodType.Text.Trim();
            cbRH.Text.Trim();
            tbPhone.Text.Trim();
            tbEmail.Text.Trim();
            tbState.Text.Trim();
            tbCity.Text.Trim();
            tbPostalCode.Text.Trim();
            tbStreet.Text.Trim();
            tbStreetNumber.Text.Trim();
        }
        private void DisableControls()
        {
            gbInformation.Enabled = false;
            gbAddress.Enabled = false;
            btnCancel.Enabled = false;
            btnSave.Enabled = false;
        }

        private void EnableControls()
        {
            gbInformation.Enabled = true;
            gbAddress.Enabled = true;
            btnCancel.Enabled = true;
            btnSave.Enabled = true;
        }

        private void SelectDonor(string jmbg)
        {
            foreach (DataGridViewRow row in dgvBloodDonors.Rows)
            {
                if (row.Cells[3].Value.Equals(jmbg))
                    row.Selected = true;
            }
        }

    }
    
}
