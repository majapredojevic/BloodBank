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

namespace BloodBank.Forms
{
    public partial class BloodBankInfoForm : Form
    {
        public BloodBankInfoForm()
        {
            InitializeComponent();
            FillLabelBankInfo();
            FillDataGridView();
            
        }

        private void FillDataGridView()
        {
           
            var officesInfo = Util.Common.DataFactory.Offices.GetOffices();
            foreach (var o in officesInfo)
            {
                DataGridViewRow row = new DataGridViewRow()
                {
                    Tag = o
                };
        row.CreateCells(dgvOfficesInfo, 
                                      o.Name,
                                      o.Email,
                                      o.Phone,
                                      o.Address.ToString());
                dgvOfficesInfo.Rows.Add(row);
            }
            
        }

        private void FillLabelBankInfo()
        {
            var bank = Util.Common.DataFactory.BloodBank.GetBloodBank();
            foreach (var b in bank)
            {
                lblName.Text = b.Name;
                lblEmail.Text = b.Email;
                lblPhoneNumbers.Text = b.Phone;
            }
        }

        private void BloodBankInfoForm_Load(object sender, EventArgs e)
        {
            dgvOfficesInfo.ClearSelection();
        }

        
    }
}
