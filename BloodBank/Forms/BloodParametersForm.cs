using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime;
using BloodBank.Data.Model;
using System.Resources;

namespace BloodBank.Forms
{
    public partial class BloodParametersForm : Form

    {
        ResourceManager rm;
        private List<BloodParameter> parameters = new List<BloodParameter>();
        private List<Virus> viruses = new List<Virus>();
        private int selectedPosition = -1;
        private bool addNewItem = false;
        private string Value = "";

        public BloodParametersForm()
        {
            rm = new ResourceManager("BloodBank.Resources.Strings", System.Reflection.Assembly.GetExecutingAssembly());

            InitializeComponent();
            FillRHFactorDataGridView();
            FillBloodTypeDataGridView();
            FillBloodParameterDataGridView();
        }

        private void FillRHFactorDataGridView()
        {

            var rHFactors = Util.Common.DataFactory.RHFactor.GetRHFactors();
            foreach (var r in rHFactors)
            {
                DataGridViewRow row = new DataGridViewRow()
                {
                    Tag = r
                };
                row.CreateCells(dgvRHFactor,
                                              r.Name);
                dgvRHFactor.Rows.Add(row);
            }


        }

        private void FillBloodTypeDataGridView()
        {

            var bloodTypes = Util.Common.DataFactory.BloodType.GetBloodTypes();
            foreach (var r in bloodTypes)
            {
                DataGridViewRow row = new DataGridViewRow()
                {
                    Tag = r
                };
                row.CreateCells(dgvRHFactor,
                                              r.Name);
                dgvBloodType.Rows.Add(row);
            }


        }

        private void FillBloodParameterDataGridView()
        {
            dgvBloodParameters.Rows.Clear();
            parameters.Clear();
             parameters = Util.Common.DataFactory.BloodParameter.GetBloodParameters(tbFilter.Text);
            foreach (var p in parameters)
            {
                DataGridViewRow row = new DataGridViewRow()
                {
                    Tag = p
                };
                row.CreateCells(dgvBloodParameters, p.Name,
                                                    p.Unit,
                                                    p.ReferenceValue
                                                    );
                dgvBloodParameters.Rows.Add(row);
            }
            if (dgvBloodParameters.RowCount == 0)
                contextMenuStrip1.Enabled = false;
            DisableControls();
        }

        private void FillVirusDataGridView()
        {
            dgvBloodParameters.Rows.Clear();
            viruses.Clear();
            viruses = Util.Common.DataFactory.Virus.GetViruses(tbFilter.Text);
            foreach (var v in viruses)
            {
                DataGridViewRow row = new DataGridViewRow()
                {
                    Tag = v
                };
                row.CreateCells(dgvBloodParameters, v.Name,
                                                    v.Unit,
                                                    v.ReferenceValue
                                                    );
                dgvBloodParameters.Rows.Add(row);
            }
            if (dgvBloodParameters.RowCount == 0)
                contextMenuStrip1.Enabled = false;
            DisableControls();
        }


        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            if (tcCiphers.SelectedIndex.Equals(0))

                FillBloodParameterDataGridView();
            else
                FillVirusDataGridView();
        }



        private void ShowData()
        {

            btnAdd.Enabled = false;
            EnableControls();
            tbName.Enabled = false;
            tbUnit.Enabled = false;



            var selectedRow =  dgvBloodParameters.SelectedRows[0];
            selectedPosition = selectedRow.Index;
            tbName.Text = selectedRow.Cells[0].Value.ToString();
            tbUnit.Text = selectedRow.Cells[1].Value.ToString();

            if (selectedRow.Cells[2].Value.ToString().Contains('<'))
            {

                rbLessThan.Checked = true;
                tbLessThan.Text = selectedRow.Cells[2].Value.ToString().Substring(1);
            }
            else if (selectedRow.Cells[2].Value.ToString().Contains('>'))
            {


                rbGreaterThan.Checked = true;
                tbGreaterThan.Text = selectedRow.Cells[2].Value.ToString().Substring(1);

            }
            else
            {
                rbRange.Checked = true;
                string[] values = selectedRow.Cells[2].Value.ToString().Split('-');
                tbRangeValue1.Text = values[0];
                tbRangeValue2.Text = values[1];
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            EnableControls();
            dgvBloodParameters.Enabled = false;
            pnlFilter.Enabled = false;
            tbName.Text = "";
            tbUnit.Text = "";
            ClearTextBoxes();
            addNewItem = true;
        }

    
        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvBloodParameters.Enabled = false;
            pnlFilter.Enabled = false;
            addNewItem = false;
            ShowData();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DisableControls();
            tbName.Text = "";
            tbUnit.Text = "";
            ClearTextBoxes();
            dgvBloodParameters.Enabled = true;
            pnlFilter.Enabled = true;
            btnAdd.Enabled = true;
        }

       

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedRow = dgvBloodParameters.SelectedRows[0];
            selectedPosition = selectedRow.Index;

            var result = MessageBox.Show(rm.GetString("DeleteWarning"),rm.GetString("Warning"), MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result.Equals(DialogResult.Yes))
            {
                try
                {
                    if (tcCiphers.SelectedIndex.Equals(0))
                    {
                        Util.Common.DataFactory.BloodParameter.DeleteBloodParameterById(parameters[selectedPosition].Id);
                        FillBloodParameterDataGridView();
                    }
                    else
                    {
                        Util.Common.DataFactory.Virus.DeleteVirusById(viruses[selectedPosition].Id);
                        FillVirusDataGridView();
                    }

                    MessageBox.Show(rm.GetString("DeleteSuccessfully"),rm.GetString("Notification"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                catch
                {
                    MessageBox.Show(rm.GetString("DeleteUnsuccessfully"), rm.GetString("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

        }

       
        private void btnSave_Click(object sender, EventArgs e)
        {
            TrimTextBoxes();
            Value = "";

            if (rbLessThan.Checked && !tbLessThan.Text.Equals(""))
                Value = "<" + tbLessThan.Text;
            else if (rbGreaterThan.Checked && !tbGreaterThan.Text.Equals(""))
                Value = ">" + tbGreaterThan.Text;
            else
            {
                if (rbRange.Checked && !tbRangeValue1.Text.Equals("") && !tbRangeValue2.Text.Equals(""))
                {
                    Value = tbRangeValue1.Text + "-" + tbRangeValue2.Text;
                }
            }


            if (tbName.Text.Equals("") || Value.Equals("") || tbUnit.Text.Equals(""))
            {
                MessageBox.Show(rm.GetString("EnterData"), rm.GetString("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (rbRange.Checked && !checkRange(tbRangeValue1.Text, tbRangeValue2.Text))
            {
                   
                MessageBox.Show(rm.GetString("WrongData"), rm.GetString("Error"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (addNewItem == true)
            {
                try
                {
                    if (tcCiphers.SelectedIndex.Equals(0))
                    {
                        Util.Common.DataFactory.BloodParameter.InsertBloodParameter(new BloodParameter()
                        {
                            Name = tbName.Text,
                            ReferenceValue = Value,
                            Unit = tbUnit.Text
                        });
                        FillBloodParameterDataGridView();
                        SelectParameter(tbName.Text);

                    }

                    else
                    {
                        Util.Common.DataFactory.Virus.InsertVirus(new Virus()
                        {
                            Name = tbName.Text,
                            ReferenceValue = Value,
                            Unit = tbUnit.Text
                        });

                        FillVirusDataGridView();
                        SelectParameter(tbName.Text);

                    }

                    MessageBox.Show(rm.GetString("AddedSuccessfully"), rm.GetString("Notification"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisableControls();
                    setControls();
                    btnAdd.Enabled = true;

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
                    var selectedRow = dgvBloodParameters.SelectedRows[0];
                    selectedPosition = selectedRow.Index;

                    if (tcCiphers.SelectedIndex.Equals(0))
                    {
                        Util.Common.DataFactory.BloodParameter.UpdateBloodParameter(new BloodParameter()
                        {
                            Id = parameters[selectedPosition].Id,
                            ReferenceValue = Value
                        });
                        FillBloodParameterDataGridView();
                        SelectParameter(tbName.Text);
                    }
                    else
                    {
                        Util.Common.DataFactory.Virus.UpdateVirus(new Virus()
                        {
                            Id = viruses[selectedPosition].Id,
                            ReferenceValue = Value
                        });

                        FillVirusDataGridView();
                        SelectParameter(tbName.Text);
                        
                    }
                    setControls();
                    MessageBox.Show(rm.GetString("EditedSuccessfully"), rm.GetString("Notification"), MessageBoxButtons.OK, MessageBoxIcon.Information);



                }
                catch
                {
                    MessageBox.Show(rm.GetString("EditedUnsuccessfully"), rm.GetString("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            
        }

        private void dgvBloodParameters_EnabledChanged(object sender, EventArgs e)
        {
            if (!dgvBloodParameters.Enabled)
            {
                dgvBloodParameters.RowsDefaultCellStyle.BackColor = SystemColors.Control;
                dgvBloodParameters.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.Control;
                dgvBloodParameters.ColumnHeadersDefaultCellStyle.SelectionBackColor = SystemColors.Control;

            }
            else
            {
                dgvBloodParameters.RowsDefaultCellStyle.BackColor = Color.White;
                dgvBloodParameters.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.InactiveCaption;
                dgvBloodParameters.ColumnHeadersDefaultCellStyle.SelectionBackColor = SystemColors.InactiveCaption;
            }
        }

        private void tcCiphers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tcCiphers.SelectedIndex.Equals(1) || tcCiphers.SelectedIndex.Equals(0))
            {
                tcCiphers.SelectedTab.Controls.Add(pnlAddOrEdit);
                tcCiphers.SelectedTab.Controls.Add(pnlFilter);
                tcCiphers.SelectedTab.Controls.Add(gbBloodParameters);
                gbBloodParameters.BringToFront();

                if (tcCiphers.SelectedIndex.Equals(0))
                {
                   
                    gbBloodParameters.Text = rm.GetString("BloodParameters");
                    FillBloodParameterDataGridView();
                }
                else
                {
                    gbBloodParameters.Text = rm.GetString("Viruses");
                    FillVirusDataGridView();
                }
            }

        }


        private void rbLessThan_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLessThan.Checked == true)
            {
                ClearTextBoxes();
                tbLessThan.Enabled = true;
                tbGreaterThan.Enabled = false;
                tbRangeValue1.Enabled = false;
                tbRangeValue2.Enabled = false;
            }
            else
                tbLessThan.Text = "";
        }

        private void rbGreaterThan_CheckedChanged(object sender, EventArgs e)
        {
            if (rbGreaterThan.Checked == true)
            {
                ClearTextBoxes();
                tbLessThan.Enabled = false;
                tbGreaterThan.Enabled = true;
                tbRangeValue1.Enabled = false;
                tbRangeValue2.Enabled = false;
            }
            else
                tbGreaterThan.Text = "";
        }

        private void rbRange_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRange.Checked == true)
            {
                ClearTextBoxes();
                tbLessThan.Enabled = false;
                tbGreaterThan.Enabled = false;
                tbRangeValue1.Enabled = true;
                tbRangeValue2.Enabled = true;

            }
            else
            {
                tbRangeValue1.Text = "";
                tbRangeValue2.Text = "";
            }
        }


        private void tbLessThan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != ',') && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void TrimTextBoxes()
        {
            tbName.Text.Trim();
            tbUnit.Text.Trim();
            tbLessThan.Text.Trim();
            tbGreaterThan.Text.Trim();
            tbRangeValue1.Text.Trim();
            tbRangeValue2.Text.Trim();
        }

        private void DisableControls()
        {
            tbName.Enabled = false;
            tbUnit.Enabled = false;
            gbReferenceValues.Enabled = false;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            rbLessThan.Checked = false;
            rbGreaterThan.Checked = false;
            rbRange.Checked = false;
            tbLessThan.Enabled = false;
            tbGreaterThan.Enabled = false;
            tbRangeValue1.Enabled = false;
            tbRangeValue2.Enabled = false;
        }

        private void EnableControls()
        {
            tbName.Enabled = true;
            tbUnit.Enabled = true;
            gbReferenceValues.Enabled = true;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;

        }

        private void ClearTextBoxes()
        {

            tbLessThan.Text = "";
            tbGreaterThan.Text = "";
            tbRangeValue1.Text = "";
            tbRangeValue2.Text = "";
        }

        private bool checkRange(string value1, string value2)
        {
            if (Decimal.Parse(value1) >= Decimal.Parse(value2))
                return false;
            return true; 
        }

        private void setControls()
        {
            pnlFilter.Enabled = true;
            dgvBloodParameters.Enabled = true;
            btnAdd.Enabled = true;
            ClearTextBoxes();
            tbName.Text = "";
            tbUnit.Text = "";
            DisableControls();
        }

        private void SelectParameter(string name)
        {
            foreach (DataGridViewRow row in dgvBloodParameters.Rows)
            {
                if (row.Cells[0].Value.Equals(name))
                    row.Selected = true;
            }
        }

    }
}

  

