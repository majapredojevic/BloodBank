using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BloodBank.Data.Model;
using System.Resources;

namespace BloodBank.Forms
{
    
    public partial class NewReportForm : Form
    {
        ResourceManager rm;
        private List<BloodParameter> bloodParameters = new List<BloodParameter>();
        private List<Virus> viruses = new List<Virus>();
        public NewReportForm(string username)
        {
            rm = new ResourceManager("BloodBank.Resources.Strings", System.Reflection.Assembly.GetExecutingAssembly());
            InitializeComponent();
            FillBoxes(username);
            FillDataGridViews();
         
        }

        private void FillBoxes(string username)
        {
            lblSign.Text = Util.Common.DataFactory.Accounts.GetEmployeeByUsername(username).ToString();

            var rHFactors = Util.Common.DataFactory.RHFactor.GetRHFactors();
            foreach (var r in rHFactors)
            {
                cbRHFactor.Items.Add(r);

            }

            var bloodTypes = Util.Common.DataFactory.BloodType.GetBloodTypes();
            foreach (var t in bloodTypes)
            {
                cbBloodType.Items.Add(t);
            }


        }

        private void FillDataGridViews()
        {
            dgvBloodParameters.Rows.Clear();
            dgvViruses.Rows.Clear();


             bloodParameters = Util.Common.DataFactory.BloodParameter.GetBloodParameters("");
            foreach (var b in bloodParameters)
            {
                DataGridViewRow row = new DataGridViewRow()
                {
                    Tag = b
                };
                row.CreateCells(dgvBloodParameters, b.Name,
                                                    b.Unit,
                                                    b.ReferenceValue
                                                );
                dgvBloodParameters.Rows.Add(row);
            }

            viruses = Util.Common.DataFactory.Virus.GetViruses("");
            foreach (var v in viruses)
            {
                DataGridViewRow row = new DataGridViewRow()
                {
                    Tag = v
                };
                row.CreateCells(dgvViruses, v.Name,
                                            v.Unit,
                                            v.ReferenceValue
                                                );
                dgvViruses.Rows.Add(row);
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            bool exist = false;
            var bloodDonations = Util.Common.DataFactory.BloodDonation.GetBloodDonations("");

            foreach (var b in bloodDonations)
            {
                if (b.BloodBag.Id.ToString().Equals(tbIDBloodBag.Text))
                {
                    exist = true;
                }
            }
            if (exist)
            {
                lblID.Text = rm.GetString("Found");
                lblID.ForeColor = Color.Green;
            }
            else
            {
                lblID.Text = rm.GetString("Not found");
                lblID.ForeColor = Color.Red;
            }
        }

        private void tbIDBloodBag_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != ',') && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void dgvBloodParameters_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox tb = e.Control as TextBox;
            tb.KeyPress += new KeyPressEventHandler(tbIDBloodBag_KeyPress);
        }

        private void dgvViruses_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox tb = e.Control as TextBox;
            tb.KeyPress += new KeyPressEventHandler(tbIDBloodBag_KeyPress);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FillDataGridViews();
            ClearBoxes();


        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            TrimTextBoxes();

            if (tbIDBloodBag.Text.Equals("") || cbRHFactor.Text.Equals("") || cbBloodType.Text.Equals("") || lblID.Text.Equals("Nije pronađeno") || lblID.Text.Equals("Not found"))
                MessageBox.Show(rm.GetString("EnterData"), rm.GetString("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                Report r = new Report()
                {
                    bloodBag = new BloodBag()
                    {
                        Id = Int32.Parse(tbIDBloodBag.Text)
                    },
                    rhFactor = new RHFactor()
                    {
                        Name = cbRHFactor.Text.Trim()
                    },
                    bloodType = new BloodType()
                    {
                        Name = cbBloodType.Text.Trim()
                    },
                    laborant = new Employee()
                    {
                        Person = new Person()
                        {
                            Id = Util.Common.DataFactory.Employee.GetLaborantByName(lblSign.Text)
                        }
                    }
                };

                List<ReportBloodParameter> reportBloodParameters = new List<ReportBloodParameter>();

                foreach (DataGridViewRow row in dgvBloodParameters.Rows)
                {
                    int position = row.Index;

                    if (row.Cells[3].Value != null)
                    {
                        reportBloodParameters.Add(new ReportBloodParameter()
                        {
                            report = new Report()
                            {
                                bloodBag = new BloodBag()
                                {
                                    Id = Int32.Parse(tbIDBloodBag.Text)
                                }
                            },
                            value = Decimal.Parse(row.Cells[3].Value.ToString().Trim()),
                            bloodParameter = new BloodParameter()
                            {
                                Id = bloodParameters[position].Id
                            }
                        });
                    }
                }

                List<ReportViruses> reportViruses = new List<ReportViruses>();

                foreach (DataGridViewRow row in dgvViruses.Rows)
                {
                    int position = row.Index;
                    if (row.Cells[3].Value != null)
                    {
                        reportViruses.Add(new ReportViruses()
                        {
                            report = new Report()
                            {
                                bloodBag = new BloodBag()
                                {
                                    Id = Int32.Parse(tbIDBloodBag.Text)
                                }
                            },
                            value = Decimal.Parse(row.Cells[3].Value.ToString().Trim()),
                            virus = new Virus()
                            {
                                Id = viruses[position].Id
                            }
                        });
                    }
                }
                try
                {
                    Util.Common.DataFactory.Report.InsertReport(r, reportBloodParameters, reportViruses);

                    MessageBox.Show(rm.GetString("New report success"),rm.GetString("Notification"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show(rm.GetString("Error report"),rm.GetString("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                FillDataGridViews();
                ClearBoxes();
            }
        }

        private void ClearBoxes()
        {
            tbIDBloodBag.Text = "";
            cbBloodType.Text = "";
            cbRHFactor.Text = "";
            lblID.Text = "";
        }

        private void TrimTextBoxes()
        {
            tbIDBloodBag.Text.Trim();
            cbRHFactor.Text.Trim();
            cbBloodType.Text.Trim();

        }
    }
}
