
namespace BloodBank.Forms
{
    partial class NewReportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewReportForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbParameters = new System.Windows.Forms.GroupBox();
            this.dgvBloodParameters = new System.Windows.Forms.DataGridView();
            this.gbReport = new System.Windows.Forms.GroupBox();
            this.lblSign = new System.Windows.Forms.Label();
            this.tbIDBloodBag = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblLaborant = new System.Windows.Forms.Label();
            this.cbRHFactor = new System.Windows.Forms.ComboBox();
            this.cbBloodType = new System.Windows.Forms.ComboBox();
            this.lblIDBloodBag = new System.Windows.Forms.Label();
            this.lblBloodType = new System.Windows.Forms.Label();
            this.lblRHFactor = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbVirus = new System.Windows.Forms.GroupBox();
            this.dgvViruses = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReferenceValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReferenceValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBloodParameters)).BeginInit();
            this.gbReport.SuspendLayout();
            this.gbVirus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViruses)).BeginInit();
            this.SuspendLayout();
            // 
            // gbParameters
            // 
            resources.ApplyResources(this.gbParameters, "gbParameters");
            this.gbParameters.Controls.Add(this.dgvBloodParameters);
            this.gbParameters.Name = "gbParameters";
            this.gbParameters.TabStop = false;
            // 
            // dgvBloodParameters
            // 
            this.dgvBloodParameters.AllowUserToAddRows = false;
            this.dgvBloodParameters.AllowUserToDeleteRows = false;
            this.dgvBloodParameters.AllowUserToResizeColumns = false;
            this.dgvBloodParameters.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBloodParameters.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            resources.ApplyResources(this.dgvBloodParameters, "dgvBloodParameters");
            this.dgvBloodParameters.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvBloodParameters.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBloodParameters.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBloodParameters.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBloodParameters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBloodParameters.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cName,
            this.Unit,
            this.ReferenceValue,
            this.Value});
            this.dgvBloodParameters.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvBloodParameters.EnableHeadersVisualStyles = false;
            this.dgvBloodParameters.GridColor = System.Drawing.Color.DimGray;
            this.dgvBloodParameters.Name = "dgvBloodParameters";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBloodParameters.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvBloodParameters.RowHeadersVisible = false;
            this.dgvBloodParameters.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.dgvBloodParameters.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvBloodParameters.RowTemplate.Height = 24;
            this.dgvBloodParameters.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBloodParameters.ShowCellToolTips = false;
            this.dgvBloodParameters.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvBloodParameters_EditingControlShowing);
            // 
            // gbReport
            // 
            resources.ApplyResources(this.gbReport, "gbReport");
            this.gbReport.Controls.Add(this.lblSign);
            this.gbReport.Controls.Add(this.tbIDBloodBag);
            this.gbReport.Controls.Add(this.btnSearch);
            this.gbReport.Controls.Add(this.lblID);
            this.gbReport.Controls.Add(this.btnCancel);
            this.gbReport.Controls.Add(this.btnSave);
            this.gbReport.Controls.Add(this.lblLaborant);
            this.gbReport.Controls.Add(this.cbRHFactor);
            this.gbReport.Controls.Add(this.cbBloodType);
            this.gbReport.Controls.Add(this.lblIDBloodBag);
            this.gbReport.Controls.Add(this.lblBloodType);
            this.gbReport.Controls.Add(this.lblRHFactor);
            this.gbReport.Controls.Add(this.label4);
            this.gbReport.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbReport.Name = "gbReport";
            this.gbReport.TabStop = false;
            // 
            // lblSign
            // 
            resources.ApplyResources(this.lblSign, "lblSign");
            this.lblSign.Name = "lblSign";
            // 
            // tbIDBloodBag
            // 
            resources.ApplyResources(this.tbIDBloodBag, "tbIDBloodBag");
            this.tbIDBloodBag.BackColor = System.Drawing.SystemColors.Window;
            this.tbIDBloodBag.Name = "tbIDBloodBag";
            this.tbIDBloodBag.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbIDBloodBag_KeyPress);
            // 
            // btnSearch
            // 
            resources.ApplyResources(this.btnSearch, "btnSearch");
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.ForeColor = System.Drawing.Color.Navy;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblID
            // 
            resources.ApplyResources(this.lblID, "lblID");
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Name = "lblID";
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.ForeColor = System.Drawing.Color.Green;
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblLaborant
            // 
            resources.ApplyResources(this.lblLaborant, "lblLaborant");
            this.lblLaborant.BackColor = System.Drawing.Color.Transparent;
            this.lblLaborant.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblLaborant.Name = "lblLaborant";
            // 
            // cbRHFactor
            // 
            resources.ApplyResources(this.cbRHFactor, "cbRHFactor");
            this.cbRHFactor.FormattingEnabled = true;
            this.cbRHFactor.Name = "cbRHFactor";
            // 
            // cbBloodType
            // 
            resources.ApplyResources(this.cbBloodType, "cbBloodType");
            this.cbBloodType.FormattingEnabled = true;
            this.cbBloodType.Name = "cbBloodType";
            // 
            // lblIDBloodBag
            // 
            resources.ApplyResources(this.lblIDBloodBag, "lblIDBloodBag");
            this.lblIDBloodBag.BackColor = System.Drawing.Color.Transparent;
            this.lblIDBloodBag.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblIDBloodBag.Name = "lblIDBloodBag";
            // 
            // lblBloodType
            // 
            resources.ApplyResources(this.lblBloodType, "lblBloodType");
            this.lblBloodType.BackColor = System.Drawing.Color.Transparent;
            this.lblBloodType.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBloodType.Name = "lblBloodType";
            // 
            // lblRHFactor
            // 
            resources.ApplyResources(this.lblRHFactor, "lblRHFactor");
            this.lblRHFactor.BackColor = System.Drawing.Color.Transparent;
            this.lblRHFactor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRHFactor.Name = "lblRHFactor";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Name = "label4";
            // 
            // gbVirus
            // 
            resources.ApplyResources(this.gbVirus, "gbVirus");
            this.gbVirus.Controls.Add(this.dgvViruses);
            this.gbVirus.Name = "gbVirus";
            this.gbVirus.TabStop = false;
            // 
            // dgvViruses
            // 
            this.dgvViruses.AllowUserToAddRows = false;
            this.dgvViruses.AllowUserToDeleteRows = false;
            this.dgvViruses.AllowUserToResizeColumns = false;
            this.dgvViruses.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvViruses.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            resources.ApplyResources(this.dgvViruses, "dgvViruses");
            this.dgvViruses.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvViruses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvViruses.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvViruses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvViruses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViruses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colUnit,
            this.colReferenceValue,
            this.colValue});
            this.dgvViruses.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvViruses.EnableHeadersVisualStyles = false;
            this.dgvViruses.GridColor = System.Drawing.Color.DimGray;
            this.dgvViruses.Name = "dgvViruses";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvViruses.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvViruses.RowHeadersVisible = false;
            this.dgvViruses.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.dgvViruses.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvViruses.RowTemplate.Height = 24;
            this.dgvViruses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvViruses.ShowCellToolTips = false;
            this.dgvViruses.ShowEditingIcon = false;
            this.dgvViruses.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvViruses_EditingControlShowing);
            // 
            // colName
            // 
            this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colName.DefaultCellStyle = dataGridViewCellStyle11;
            resources.ApplyResources(this.colName, "colName");
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colUnit
            // 
            this.colUnit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colUnit.DefaultCellStyle = dataGridViewCellStyle12;
            resources.ApplyResources(this.colUnit, "colUnit");
            this.colUnit.Name = "colUnit";
            this.colUnit.ReadOnly = true;
            // 
            // colReferenceValue
            // 
            this.colReferenceValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.colReferenceValue.DefaultCellStyle = dataGridViewCellStyle13;
            resources.ApplyResources(this.colReferenceValue, "colReferenceValue");
            this.colReferenceValue.Name = "colReferenceValue";
            this.colReferenceValue.ReadOnly = true;
            // 
            // colValue
            // 
            this.colValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle14.Format = "N2";
            dataGridViewCellStyle14.NullValue = null;
            this.colValue.DefaultCellStyle = dataGridViewCellStyle14;
            resources.ApplyResources(this.colValue, "colValue");
            this.colValue.Name = "colValue";
            // 
            // cName
            // 
            this.cName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.cName.DefaultCellStyle = dataGridViewCellStyle3;
            resources.ApplyResources(this.cName, "cName");
            this.cName.Name = "cName";
            this.cName.ReadOnly = true;
            // 
            // Unit
            // 
            this.Unit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Unit.DefaultCellStyle = dataGridViewCellStyle4;
            resources.ApplyResources(this.Unit, "Unit");
            this.Unit.Name = "Unit";
            this.Unit.ReadOnly = true;
            // 
            // ReferenceValue
            // 
            this.ReferenceValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ReferenceValue.DefaultCellStyle = dataGridViewCellStyle5;
            resources.ApplyResources(this.ReferenceValue, "ReferenceValue");
            this.ReferenceValue.Name = "ReferenceValue";
            this.ReferenceValue.ReadOnly = true;
            // 
            // Value
            // 
            this.Value.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.NullValue = null;
            this.Value.DefaultCellStyle = dataGridViewCellStyle6;
            resources.ApplyResources(this.Value, "Value");
            this.Value.MaxInputLength = 10;
            this.Value.Name = "Value";
            // 
            // NewReportForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbVirus);
            this.Controls.Add(this.gbParameters);
            this.Controls.Add(this.gbReport);
            this.Name = "NewReportForm";
            this.gbParameters.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBloodParameters)).EndInit();
            this.gbReport.ResumeLayout(false);
            this.gbReport.PerformLayout();
            this.gbVirus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViruses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbParameters;
        private System.Windows.Forms.GroupBox gbReport;
        private System.Windows.Forms.Label lblLaborant;
        private System.Windows.Forms.ComboBox cbRHFactor;
        private System.Windows.Forms.ComboBox cbBloodType;
        private System.Windows.Forms.Label lblIDBloodBag;
        private System.Windows.Forms.Label lblBloodType;
        private System.Windows.Forms.Label lblRHFactor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox gbVirus;
        private System.Windows.Forms.DataGridView dgvBloodParameters;
        private System.Windows.Forms.DataGridView dgvViruses;
        private System.Windows.Forms.TextBox tbIDBloodBag;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblSign;
        private System.Windows.Forms.DataGridViewTextBoxColumn cName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReferenceValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReferenceValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValue;
    }
}