using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Resources;

namespace BloodBank.Forms
{
    public partial class AnalysisReportsForm : Form
    {
        ResourceManager rm;
        public AnalysisReportsForm()
        {
            rm = new ResourceManager("BloodBank.Resources.Strings", System.Reflection.Assembly.GetExecutingAssembly());
           
            InitializeComponent();

            AddButtonColumn();
            FillDataGridView();
           



        }

        private void AddButtonColumn()
        {
            var detailsColumn = new DataGridViewButtonColumn
            {
               Text = rm.GetString("Details"),
                HeaderText =rm.GetString("Details"),
                UseColumnTextForButtonValue = true,
                Name = "btnShowDetails",
                DataPropertyName = rm.GetString("Details"),
                MinimumWidth = 80,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                FlatStyle = FlatStyle.Popup,
                DefaultCellStyle = new DataGridViewCellStyle
                { 
                    BackColor = SystemColors.InactiveBorder
                }
            };
            dgvReport.Columns.Add(detailsColumn);
            
        }

        private void FillDataGridView()
        {
            
            dgvReport.Rows.Clear();


            dgvReport.Columns["DateTime"].DefaultCellStyle.Format = ConfigurationManager.AppSettings["DateTimeFormat"];
           
            var reports = Util.Common.DataFactory.Report.GetReports(tbFilter.Text);
            foreach (var r in reports)
            {

                DataGridViewRow row = new DataGridViewRow()
                {
                    Tag = r
                };
                row.CreateCells(dgvReport, r.bloodBag.Id,
                                           r.bloodBag.Capacity,
                                           r.rhFactor.Name,
                                           r.bloodType.Name,
                                           r.dateTime,
                                           r.laborant.ToString()
                                           );                    
                dgvReport.Rows.Add(row);

                              
            }

        }

        private void dgvReport_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvReport.Columns["btnShowDetails"].Index && e.RowIndex >= 0)
            {
                dgvReportDetails.Rows.Clear();
                
                var selectedRow = dgvReport.SelectedRows[0];
                int id = Int32.Parse(selectedRow.Cells[0].Value.ToString());
                
                var parameters = Util.Common.DataFactory.Report.GetBloodParametersByReportId(id);
                foreach (var p in parameters)
                {
                    DataGridViewRow row = new DataGridViewRow()
                    {
                        Tag = p
                    };
                    row.CreateCells(dgvReportDetails, p.bloodParameter.Name,
                                                      p.value.ToString(),
                                                      p.bloodParameter.ReferenceValue,
                                                      p.bloodParameter.Unit
                      );
                    row.DefaultCellStyle.BackColor = Color.White;
                    dgvReportDetails.Rows.Add(row);
                }

                var viruses = Util.Common.DataFactory.Report.GetReportVirusesByReportId(id);
                
                foreach (var v in viruses)
                {
                    DataGridViewRow row = new DataGridViewRow()
                    {
                        Tag = v
                    };
                    row.CreateCells(dgvReportDetails,  v.virus.Name,
                                                      v.value.ToString(),
                                                      v.virus.ReferenceValue,
                                                      v.virus.Unit
                      );
                    row.DefaultCellStyle.BackColor = SystemColors.InactiveBorder;
                    dgvReportDetails.Rows.Add(row);
                }
            }
        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            FillDataGridView();
        }
    }
}
