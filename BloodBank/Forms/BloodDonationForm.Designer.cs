
namespace BloodBank.Forms
{
    partial class BloodDonationForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BloodDonationForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblFilter = new System.Windows.Forms.Label();
            this.gbNewDonation = new System.Windows.Forms.GroupBox();
            this.gbBloodDonation = new System.Windows.Forms.GroupBox();
            this.lblDoctor = new System.Windows.Forms.Label();
            this.lblOffice = new System.Windows.Forms.Label();
            this.cbOffice = new System.Windows.Forms.ComboBox();
            this.lblSignature = new System.Windows.Forms.Label();
            this.gbBloodDonor = new System.Windows.Forms.GroupBox();
            this.tbCapacity = new System.Windows.Forms.TextBox();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.tbJMBG = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tbBloodPressure = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.tbHemoglobin = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbPulse = new System.Windows.Forms.TextBox();
            this.tbHealthCondition = new System.Windows.Forms.TextBox();
            this.lblPulse = new System.Windows.Forms.Label();
            this.lblBloodPressure = new System.Windows.Forms.Label();
            this.lblHealthCondition = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblHemoglobin = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblJMBG = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvBloodDonation = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BloodBag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BloodDonor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JMBG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hemoglobin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BloodPressure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pulse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HealthCondition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Signature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Office = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.gbNewDonation.SuspendLayout();
            this.gbBloodDonation.SuspendLayout();
            this.gbBloodDonor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBloodDonation)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.pnlFilter.SuspendLayout();
            this.SuspendLayout();
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
            // lblFilter
            // 
            resources.ApplyResources(this.lblFilter, "lblFilter");
            this.lblFilter.ForeColor = System.Drawing.Color.Black;
            this.lblFilter.Name = "lblFilter";
            // 
            // gbNewDonation
            // 
            this.gbNewDonation.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gbNewDonation.Controls.Add(this.gbBloodDonation);
            this.gbNewDonation.Controls.Add(this.gbBloodDonor);
            this.gbNewDonation.Controls.Add(this.btnCancel);
            this.gbNewDonation.Controls.Add(this.btnSave);
            this.gbNewDonation.Controls.Add(this.btnAdd);
            resources.ApplyResources(this.gbNewDonation, "gbNewDonation");
            this.gbNewDonation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbNewDonation.ForeColor = System.Drawing.Color.Black;
            this.gbNewDonation.Name = "gbNewDonation";
            this.gbNewDonation.TabStop = false;
            // 
            // gbBloodDonation
            // 
            resources.ApplyResources(this.gbBloodDonation, "gbBloodDonation");
            this.gbBloodDonation.Controls.Add(this.lblDoctor);
            this.gbBloodDonation.Controls.Add(this.lblOffice);
            this.gbBloodDonation.Controls.Add(this.cbOffice);
            this.gbBloodDonation.Controls.Add(this.lblSignature);
            this.gbBloodDonation.Name = "gbBloodDonation";
            this.gbBloodDonation.TabStop = false;
            // 
            // lblDoctor
            // 
            resources.ApplyResources(this.lblDoctor, "lblDoctor");
            this.lblDoctor.Name = "lblDoctor";
            // 
            // lblOffice
            // 
            resources.ApplyResources(this.lblOffice, "lblOffice");
            this.lblOffice.BackColor = System.Drawing.Color.Transparent;
            this.lblOffice.Name = "lblOffice";
            // 
            // cbOffice
            // 
            resources.ApplyResources(this.cbOffice, "cbOffice");
            this.cbOffice.FormattingEnabled = true;
            this.cbOffice.Name = "cbOffice";
            // 
            // lblSignature
            // 
            resources.ApplyResources(this.lblSignature, "lblSignature");
            this.lblSignature.BackColor = System.Drawing.Color.Transparent;
            this.lblSignature.Name = "lblSignature";
            // 
            // gbBloodDonor
            // 
            resources.ApplyResources(this.gbBloodDonor, "gbBloodDonor");
            this.gbBloodDonor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gbBloodDonor.Controls.Add(this.tbCapacity);
            this.gbBloodDonor.Controls.Add(this.lblCapacity);
            this.gbBloodDonor.Controls.Add(this.tbJMBG);
            this.gbBloodDonor.Controls.Add(this.btnSearch);
            this.gbBloodDonor.Controls.Add(this.comboBox2);
            this.gbBloodDonor.Controls.Add(this.label7);
            this.gbBloodDonor.Controls.Add(this.label6);
            this.gbBloodDonor.Controls.Add(this.dateTimePicker1);
            this.gbBloodDonor.Controls.Add(this.comboBox1);
            this.gbBloodDonor.Controls.Add(this.tbBloodPressure);
            this.gbBloodDonor.Controls.Add(this.button6);
            this.gbBloodDonor.Controls.Add(this.tbHemoglobin);
            this.gbBloodDonor.Controls.Add(this.label13);
            this.gbBloodDonor.Controls.Add(this.tbPulse);
            this.gbBloodDonor.Controls.Add(this.tbHealthCondition);
            this.gbBloodDonor.Controls.Add(this.lblPulse);
            this.gbBloodDonor.Controls.Add(this.lblBloodPressure);
            this.gbBloodDonor.Controls.Add(this.lblHealthCondition);
            this.gbBloodDonor.Controls.Add(this.lblFirstName);
            this.gbBloodDonor.Controls.Add(this.lblHemoglobin);
            this.gbBloodDonor.Controls.Add(this.tbFirstName);
            this.gbBloodDonor.Controls.Add(this.tbLastName);
            this.gbBloodDonor.Controls.Add(this.lblLastName);
            this.gbBloodDonor.Controls.Add(this.lblJMBG);
            this.gbBloodDonor.Name = "gbBloodDonor";
            this.gbBloodDonor.TabStop = false;
            // 
            // tbCapacity
            // 
            resources.ApplyResources(this.tbCapacity, "tbCapacity");
            this.tbCapacity.BackColor = System.Drawing.SystemColors.Window;
            this.tbCapacity.Name = "tbCapacity";
            this.tbCapacity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbJMBG_KeyPress);
            // 
            // lblCapacity
            // 
            resources.ApplyResources(this.lblCapacity, "lblCapacity");
            this.lblCapacity.Name = "lblCapacity";
            // 
            // tbJMBG
            // 
            resources.ApplyResources(this.tbJMBG, "tbJMBG");
            this.tbJMBG.BackColor = System.Drawing.SystemColors.Window;
            this.tbJMBG.Name = "tbJMBG";
            this.tbJMBG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbJMBG_KeyPress);
            // 
            // btnSearch
            // 
            resources.ApplyResources(this.btnSearch, "btnSearch");
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.CausesValidation = false;
            this.btnSearch.ForeColor = System.Drawing.Color.Navy;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // comboBox2
            // 
            resources.ApplyResources(this.comboBox2, "comboBox2");
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Name = "comboBox2";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // dateTimePicker1
            // 
            resources.ApplyResources(this.dateTimePicker1, "dateTimePicker1");
            this.dateTimePicker1.Name = "dateTimePicker1";
            // 
            // comboBox1
            // 
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Name = "comboBox1";
            // 
            // tbBloodPressure
            // 
            resources.ApplyResources(this.tbBloodPressure, "tbBloodPressure");
            this.tbBloodPressure.BackColor = System.Drawing.SystemColors.Window;
            this.tbBloodPressure.Name = "tbBloodPressure";
            this.tbBloodPressure.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBloodPreasure_KeyPress);
            // 
            // button6
            // 
            resources.ApplyResources(this.button6, "button6");
            this.button6.BackColor = System.Drawing.SystemColors.Control;
            this.button6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button6.Name = "button6";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // tbHemoglobin
            // 
            resources.ApplyResources(this.tbHemoglobin, "tbHemoglobin");
            this.tbHemoglobin.BackColor = System.Drawing.SystemColors.Window;
            this.tbHemoglobin.Name = "tbHemoglobin";
            this.tbHemoglobin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbJMBG_KeyPress);
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Name = "label13";
            // 
            // tbPulse
            // 
            resources.ApplyResources(this.tbPulse, "tbPulse");
            this.tbPulse.BackColor = System.Drawing.SystemColors.Window;
            this.tbPulse.Name = "tbPulse";
            this.tbPulse.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbJMBG_KeyPress);
            // 
            // tbHealthCondition
            // 
            resources.ApplyResources(this.tbHealthCondition, "tbHealthCondition");
            this.tbHealthCondition.BackColor = System.Drawing.SystemColors.Window;
            this.tbHealthCondition.Name = "tbHealthCondition";
            // 
            // lblPulse
            // 
            resources.ApplyResources(this.lblPulse, "lblPulse");
            this.lblPulse.Name = "lblPulse";
            // 
            // lblBloodPressure
            // 
            resources.ApplyResources(this.lblBloodPressure, "lblBloodPressure");
            this.lblBloodPressure.Name = "lblBloodPressure";
            // 
            // lblHealthCondition
            // 
            resources.ApplyResources(this.lblHealthCondition, "lblHealthCondition");
            this.lblHealthCondition.BackColor = System.Drawing.Color.Transparent;
            this.lblHealthCondition.Name = "lblHealthCondition";
            // 
            // lblFirstName
            // 
            resources.ApplyResources(this.lblFirstName, "lblFirstName");
            this.lblFirstName.BackColor = System.Drawing.Color.Transparent;
            this.lblFirstName.Name = "lblFirstName";
            // 
            // lblHemoglobin
            // 
            resources.ApplyResources(this.lblHemoglobin, "lblHemoglobin");
            this.lblHemoglobin.BackColor = System.Drawing.Color.Transparent;
            this.lblHemoglobin.Name = "lblHemoglobin";
            // 
            // tbFirstName
            // 
            this.tbFirstName.BackColor = System.Drawing.SystemColors.Menu;
            resources.ApplyResources(this.tbFirstName, "tbFirstName");
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.ReadOnly = true;
            // 
            // tbLastName
            // 
            this.tbLastName.BackColor = System.Drawing.SystemColors.Menu;
            resources.ApplyResources(this.tbLastName, "tbLastName");
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.ReadOnly = true;
            // 
            // lblLastName
            // 
            resources.ApplyResources(this.lblLastName, "lblLastName");
            this.lblLastName.BackColor = System.Drawing.Color.Transparent;
            this.lblLastName.Name = "lblLastName";
            // 
            // lblJMBG
            // 
            resources.ApplyResources(this.lblJMBG, "lblJMBG");
            this.lblJMBG.BackColor = System.Drawing.Color.Transparent;
            this.lblJMBG.Name = "lblJMBG";
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
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btnAdd, "btnAdd");
            this.btnAdd.ForeColor = System.Drawing.Color.Green;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvBloodDonation
            // 
            this.dgvBloodDonation.AllowUserToAddRows = false;
            this.dgvBloodDonation.AllowUserToDeleteRows = false;
            this.dgvBloodDonation.AllowUserToResizeColumns = false;
            this.dgvBloodDonation.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvBloodDonation.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBloodDonation.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvBloodDonation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBloodDonation.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBloodDonation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBloodDonation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBloodDonation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.BloodBag,
            this.Quantity,
            this.BloodDonor,
            this.JMBG,
            this.Hemoglobin,
            this.BloodPressure,
            this.Pulse,
            this.HealthCondition,
            this.DateTime,
            this.Signature,
            this.Office});
            this.dgvBloodDonation.ContextMenuStrip = this.contextMenuStrip1;
            resources.ApplyResources(this.dgvBloodDonation, "dgvBloodDonation");
            this.dgvBloodDonation.EnableHeadersVisualStyles = false;
            this.dgvBloodDonation.GridColor = System.Drawing.Color.Black;
            this.dgvBloodDonation.MultiSelect = false;
            this.dgvBloodDonation.Name = "dgvBloodDonation";
            this.dgvBloodDonation.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBloodDonation.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvBloodDonation.RowHeadersVisible = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.dgvBloodDonation.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvBloodDonation.RowTemplate.Height = 24;
            this.dgvBloodDonation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // Column1
            // 
            resources.ApplyResources(this.Column1, "Column1");
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // BloodBag
            // 
            resources.ApplyResources(this.BloodBag, "BloodBag");
            this.BloodBag.Name = "BloodBag";
            this.BloodBag.ReadOnly = true;
            // 
            // Quantity
            // 
            resources.ApplyResources(this.Quantity, "Quantity");
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // BloodDonor
            // 
            this.BloodDonor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.BloodDonor.DefaultCellStyle = dataGridViewCellStyle3;
            resources.ApplyResources(this.BloodDonor, "BloodDonor");
            this.BloodDonor.Name = "BloodDonor";
            this.BloodDonor.ReadOnly = true;
            // 
            // JMBG
            // 
            this.JMBG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            resources.ApplyResources(this.JMBG, "JMBG");
            this.JMBG.Name = "JMBG";
            this.JMBG.ReadOnly = true;
            // 
            // Hemoglobin
            // 
            this.Hemoglobin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            resources.ApplyResources(this.Hemoglobin, "Hemoglobin");
            this.Hemoglobin.Name = "Hemoglobin";
            this.Hemoglobin.ReadOnly = true;
            // 
            // BloodPressure
            // 
            this.BloodPressure.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            resources.ApplyResources(this.BloodPressure, "BloodPressure");
            this.BloodPressure.Name = "BloodPressure";
            this.BloodPressure.ReadOnly = true;
            // 
            // Pulse
            // 
            this.Pulse.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            resources.ApplyResources(this.Pulse, "Pulse");
            this.Pulse.Name = "Pulse";
            this.Pulse.ReadOnly = true;
            // 
            // HealthCondition
            // 
            this.HealthCondition.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            resources.ApplyResources(this.HealthCondition, "HealthCondition");
            this.HealthCondition.Name = "HealthCondition";
            this.HealthCondition.ReadOnly = true;
            // 
            // DateTime
            // 
            this.DateTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle4.Format = "ConfigurationManager.AppSettings[\"DateTimeFormat\"]";
            dataGridViewCellStyle4.NullValue = null;
            this.DateTime.DefaultCellStyle = dataGridViewCellStyle4;
            resources.ApplyResources(this.DateTime, "DateTime");
            this.DateTime.Name = "DateTime";
            this.DateTime.ReadOnly = true;
            this.DateTime.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Signature
            // 
            this.Signature.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            resources.ApplyResources(this.Signature, "Signature");
            this.Signature.Name = "Signature";
            this.Signature.ReadOnly = true;
            // 
            // Office
            // 
            this.Office.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            resources.ApplyResources(this.Office, "Office");
            this.Office.Name = "Office";
            this.Office.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.Image = global::BloodBank.Properties.Resources.edit;
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            resources.ApplyResources(this.EditToolStripMenuItem, "EditToolStripMenuItem");
            this.EditToolStripMenuItem.Click += new System.EventHandler(this.EditToolStripMenuItem_Click);
            // 
            // pnlFilter
            // 
            this.pnlFilter.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlFilter.Controls.Add(this.tbFilter);
            this.pnlFilter.Controls.Add(this.lblFilter);
            resources.ApplyResources(this.pnlFilter, "pnlFilter");
            this.pnlFilter.Name = "pnlFilter";
            // 
            // tbFilter
            // 
            resources.ApplyResources(this.tbFilter, "tbFilter");
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.TextChanged += new System.EventHandler(this.tbFilter_TextChanged);
            // 
            // BloodDonationForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvBloodDonation);
            this.Controls.Add(this.gbNewDonation);
            this.Controls.Add(this.pnlFilter);
            this.Name = "BloodDonationForm";
            this.gbNewDonation.ResumeLayout(false);
            this.gbBloodDonation.ResumeLayout(false);
            this.gbBloodDonation.PerformLayout();
            this.gbBloodDonor.ResumeLayout(false);
            this.gbBloodDonor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBloodDonation)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.GroupBox gbNewDonation;
        private System.Windows.Forms.ComboBox cbOffice;
        private System.Windows.Forms.Label lblOffice;
        private System.Windows.Forms.Label lblSignature;
        private System.Windows.Forms.GroupBox gbBloodDonor;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox tbBloodPressure;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox tbHemoglobin;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbPulse;
        private System.Windows.Forms.TextBox tbHealthCondition;
        private System.Windows.Forms.Label lblPulse;
        private System.Windows.Forms.Label lblBloodPressure;
        private System.Windows.Forms.Label lblHealthCondition;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblHemoglobin;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblJMBG;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvBloodDonation;
        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.TextBox tbFilter;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox gbBloodDonation;
        private System.Windows.Forms.TextBox tbJMBG;
        private System.Windows.Forms.TextBox tbCapacity;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.Label lblDoctor;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn BloodBag;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn BloodDonor;
        private System.Windows.Forms.DataGridViewTextBoxColumn JMBG;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hemoglobin;
        private System.Windows.Forms.DataGridViewTextBoxColumn BloodPressure;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pulse;
        private System.Windows.Forms.DataGridViewTextBoxColumn HealthCondition;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Signature;
        private System.Windows.Forms.DataGridViewTextBoxColumn Office;
    }
}