
namespace BloodBank.Forms
{
    partial class BloodDonorsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BloodDonorsForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbBloodDonor = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbAddress = new System.Windows.Forms.GroupBox();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.tbStreetNumber = new System.Windows.Forms.TextBox();
            this.tbPostalCode = new System.Windows.Forms.TextBox();
            this.tbStreet = new System.Windows.Forms.TextBox();
            this.lblPostalCode = new System.Windows.Forms.Label();
            this.tbState = new System.Windows.Forms.TextBox();
            this.lblState = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblStreetNumber = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.gbInformation = new System.Windows.Forms.GroupBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.tbFathersName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.cbRH = new System.Windows.Forms.ComboBox();
            this.lblFathersName = new System.Windows.Forms.Label();
            this.cbBloodType = new System.Windows.Forms.ComboBox();
            this.lblbloodType = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.lblRh = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.lblJMBG = new System.Windows.Forms.Label();
            this.tbJMBG = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvBloodDonors = new System.Windows.Forms.DataGridView();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImeOca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JMBG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KrvnaGrupa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RHFaktor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Doniranja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.gbBloodDonor.SuspendLayout();
            this.gbAddress.SuspendLayout();
            this.gbInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBloodDonors)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.pnlFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbBloodDonor
            // 
            this.gbBloodDonor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gbBloodDonor.Controls.Add(this.btnCancel);
            this.gbBloodDonor.Controls.Add(this.btnSave);
            this.gbBloodDonor.Controls.Add(this.gbAddress);
            this.gbBloodDonor.Controls.Add(this.gbInformation);
            this.gbBloodDonor.Controls.Add(this.btnAdd);
            resources.ApplyResources(this.gbBloodDonor, "gbBloodDonor");
            this.gbBloodDonor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbBloodDonor.ForeColor = System.Drawing.Color.Black;
            this.gbBloodDonor.Name = "gbBloodDonor";
            this.gbBloodDonor.TabStop = false;
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
            // gbAddress
            // 
            resources.ApplyResources(this.gbAddress, "gbAddress");
            this.gbAddress.BackColor = System.Drawing.Color.Transparent;
            this.gbAddress.Controls.Add(this.tbCity);
            this.gbAddress.Controls.Add(this.tbStreetNumber);
            this.gbAddress.Controls.Add(this.tbPostalCode);
            this.gbAddress.Controls.Add(this.tbStreet);
            this.gbAddress.Controls.Add(this.lblPostalCode);
            this.gbAddress.Controls.Add(this.tbState);
            this.gbAddress.Controls.Add(this.lblState);
            this.gbAddress.Controls.Add(this.lblCity);
            this.gbAddress.Controls.Add(this.lblStreetNumber);
            this.gbAddress.Controls.Add(this.lblStreet);
            this.gbAddress.ForeColor = System.Drawing.Color.Black;
            this.gbAddress.Name = "gbAddress";
            this.gbAddress.TabStop = false;
            // 
            // tbCity
            // 
            this.tbCity.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.tbCity, "tbCity");
            this.tbCity.Name = "tbCity";
            // 
            // tbStreetNumber
            // 
            this.tbStreetNumber.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.tbStreetNumber, "tbStreetNumber");
            this.tbStreetNumber.Name = "tbStreetNumber";
            this.tbStreetNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPhone_KeyPress);
            // 
            // tbPostalCode
            // 
            this.tbPostalCode.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.tbPostalCode, "tbPostalCode");
            this.tbPostalCode.Name = "tbPostalCode";
            this.tbPostalCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPhone_KeyPress);
            // 
            // tbStreet
            // 
            this.tbStreet.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.tbStreet, "tbStreet");
            this.tbStreet.Name = "tbStreet";
            // 
            // lblPostalCode
            // 
            resources.ApplyResources(this.lblPostalCode, "lblPostalCode");
            this.lblPostalCode.BackColor = System.Drawing.Color.Transparent;
            this.lblPostalCode.ForeColor = System.Drawing.Color.Black;
            this.lblPostalCode.Name = "lblPostalCode";
            // 
            // tbState
            // 
            this.tbState.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.tbState, "tbState");
            this.tbState.Name = "tbState";
            // 
            // lblState
            // 
            resources.ApplyResources(this.lblState, "lblState");
            this.lblState.BackColor = System.Drawing.Color.Transparent;
            this.lblState.ForeColor = System.Drawing.Color.Black;
            this.lblState.Name = "lblState";
            // 
            // lblCity
            // 
            resources.ApplyResources(this.lblCity, "lblCity");
            this.lblCity.BackColor = System.Drawing.Color.Transparent;
            this.lblCity.ForeColor = System.Drawing.Color.Black;
            this.lblCity.Name = "lblCity";
            // 
            // lblStreetNumber
            // 
            resources.ApplyResources(this.lblStreetNumber, "lblStreetNumber");
            this.lblStreetNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblStreetNumber.ForeColor = System.Drawing.Color.Black;
            this.lblStreetNumber.Name = "lblStreetNumber";
            // 
            // lblStreet
            // 
            resources.ApplyResources(this.lblStreet, "lblStreet");
            this.lblStreet.BackColor = System.Drawing.Color.Transparent;
            this.lblStreet.ForeColor = System.Drawing.Color.Black;
            this.lblStreet.Name = "lblStreet";
            // 
            // gbInformation
            // 
            resources.ApplyResources(this.gbInformation, "gbInformation");
            this.gbInformation.Controls.Add(this.lblFirstName);
            this.gbInformation.Controls.Add(this.tbFathersName);
            this.gbInformation.Controls.Add(this.lblLastName);
            this.gbInformation.Controls.Add(this.tbLastName);
            this.gbInformation.Controls.Add(this.cbRH);
            this.gbInformation.Controls.Add(this.lblFathersName);
            this.gbInformation.Controls.Add(this.cbBloodType);
            this.gbInformation.Controls.Add(this.lblbloodType);
            this.gbInformation.Controls.Add(this.tbFirstName);
            this.gbInformation.Controls.Add(this.lblRh);
            this.gbInformation.Controls.Add(this.lblEmail);
            this.gbInformation.Controls.Add(this.tbPhone);
            this.gbInformation.Controls.Add(this.lblJMBG);
            this.gbInformation.Controls.Add(this.tbJMBG);
            this.gbInformation.Controls.Add(this.tbEmail);
            this.gbInformation.Controls.Add(this.lblPhone);
            this.gbInformation.Name = "gbInformation";
            this.gbInformation.TabStop = false;
            // 
            // lblFirstName
            // 
            resources.ApplyResources(this.lblFirstName, "lblFirstName");
            this.lblFirstName.BackColor = System.Drawing.Color.Transparent;
            this.lblFirstName.ForeColor = System.Drawing.Color.Black;
            this.lblFirstName.Name = "lblFirstName";
            // 
            // tbFathersName
            // 
            this.tbFathersName.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.tbFathersName, "tbFathersName");
            this.tbFathersName.Name = "tbFathersName";
            // 
            // lblLastName
            // 
            resources.ApplyResources(this.lblLastName, "lblLastName");
            this.lblLastName.BackColor = System.Drawing.Color.Transparent;
            this.lblLastName.ForeColor = System.Drawing.Color.Black;
            this.lblLastName.Name = "lblLastName";
            // 
            // tbLastName
            // 
            this.tbLastName.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.tbLastName, "tbLastName");
            this.tbLastName.Name = "tbLastName";
            // 
            // cbRH
            // 
            resources.ApplyResources(this.cbRH, "cbRH");
            this.cbRH.FormattingEnabled = true;
            this.cbRH.Name = "cbRH";
            // 
            // lblFathersName
            // 
            resources.ApplyResources(this.lblFathersName, "lblFathersName");
            this.lblFathersName.BackColor = System.Drawing.Color.Transparent;
            this.lblFathersName.ForeColor = System.Drawing.Color.Black;
            this.lblFathersName.Name = "lblFathersName";
            // 
            // cbBloodType
            // 
            resources.ApplyResources(this.cbBloodType, "cbBloodType");
            this.cbBloodType.FormattingEnabled = true;
            this.cbBloodType.Name = "cbBloodType";
            // 
            // lblbloodType
            // 
            resources.ApplyResources(this.lblbloodType, "lblbloodType");
            this.lblbloodType.BackColor = System.Drawing.Color.Transparent;
            this.lblbloodType.ForeColor = System.Drawing.Color.Black;
            this.lblbloodType.Name = "lblbloodType";
            // 
            // tbFirstName
            // 
            this.tbFirstName.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.tbFirstName, "tbFirstName");
            this.tbFirstName.Name = "tbFirstName";
            // 
            // lblRh
            // 
            resources.ApplyResources(this.lblRh, "lblRh");
            this.lblRh.BackColor = System.Drawing.Color.Transparent;
            this.lblRh.ForeColor = System.Drawing.Color.Black;
            this.lblRh.Name = "lblRh";
            // 
            // lblEmail
            // 
            resources.ApplyResources(this.lblEmail, "lblEmail");
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.ForeColor = System.Drawing.Color.Black;
            this.lblEmail.Name = "lblEmail";
            // 
            // tbPhone
            // 
            resources.ApplyResources(this.tbPhone, "tbPhone");
            this.tbPhone.BackColor = System.Drawing.SystemColors.Window;
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPhone_KeyPress);
            // 
            // lblJMBG
            // 
            resources.ApplyResources(this.lblJMBG, "lblJMBG");
            this.lblJMBG.BackColor = System.Drawing.Color.Transparent;
            this.lblJMBG.ForeColor = System.Drawing.Color.Black;
            this.lblJMBG.Name = "lblJMBG";
            // 
            // tbJMBG
            // 
            this.tbJMBG.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.tbJMBG, "tbJMBG");
            this.tbJMBG.Name = "tbJMBG";
            this.tbJMBG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPhone_KeyPress);
            // 
            // tbEmail
            // 
            resources.ApplyResources(this.tbEmail, "tbEmail");
            this.tbEmail.BackColor = System.Drawing.SystemColors.Window;
            this.tbEmail.Name = "tbEmail";
            // 
            // lblPhone
            // 
            resources.ApplyResources(this.lblPhone, "lblPhone");
            this.lblPhone.BackColor = System.Drawing.Color.Transparent;
            this.lblPhone.ForeColor = System.Drawing.Color.Black;
            this.lblPhone.Name = "lblPhone";
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
            // dgvBloodDonors
            // 
            this.dgvBloodDonors.AllowUserToAddRows = false;
            this.dgvBloodDonors.AllowUserToDeleteRows = false;
            this.dgvBloodDonors.AllowUserToResizeColumns = false;
            this.dgvBloodDonors.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvBloodDonors.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBloodDonors.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvBloodDonors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBloodDonors.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBloodDonors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBloodDonors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBloodDonors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ime,
            this.ImeOca,
            this.Prezime,
            this.JMBG,
            this.KrvnaGrupa,
            this.RHFaktor,
            this.Telefon,
            this.Column6,
            this.Adresa,
            this.Doniranja});
            this.dgvBloodDonors.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBloodDonors.DefaultCellStyle = dataGridViewCellStyle6;
            resources.ApplyResources(this.dgvBloodDonors, "dgvBloodDonors");
            this.dgvBloodDonors.EnableHeadersVisualStyles = false;
            this.dgvBloodDonors.GridColor = System.Drawing.Color.Black;
            this.dgvBloodDonors.MultiSelect = false;
            this.dgvBloodDonors.Name = "dgvBloodDonors";
            this.dgvBloodDonors.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBloodDonors.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvBloodDonors.RowHeadersVisible = false;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvBloodDonors.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvBloodDonors.RowTemplate.Height = 24;
            this.dgvBloodDonors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // Ime
            // 
            this.Ime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            resources.ApplyResources(this.Ime, "Ime");
            this.Ime.Name = "Ime";
            this.Ime.ReadOnly = true;
            // 
            // ImeOca
            // 
            this.ImeOca.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            resources.ApplyResources(this.ImeOca, "ImeOca");
            this.ImeOca.Name = "ImeOca";
            this.ImeOca.ReadOnly = true;
            // 
            // Prezime
            // 
            this.Prezime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            resources.ApplyResources(this.Prezime, "Prezime");
            this.Prezime.Name = "Prezime";
            this.Prezime.ReadOnly = true;
            // 
            // JMBG
            // 
            this.JMBG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            resources.ApplyResources(this.JMBG, "JMBG");
            this.JMBG.Name = "JMBG";
            this.JMBG.ReadOnly = true;
            // 
            // KrvnaGrupa
            // 
            this.KrvnaGrupa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.KrvnaGrupa.DefaultCellStyle = dataGridViewCellStyle3;
            resources.ApplyResources(this.KrvnaGrupa, "KrvnaGrupa");
            this.KrvnaGrupa.Name = "KrvnaGrupa";
            this.KrvnaGrupa.ReadOnly = true;
            // 
            // RHFaktor
            // 
            this.RHFaktor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.RHFaktor.DefaultCellStyle = dataGridViewCellStyle4;
            resources.ApplyResources(this.RHFaktor, "RHFaktor");
            this.RHFaktor.Name = "RHFaktor";
            this.RHFaktor.ReadOnly = true;
            // 
            // Telefon
            // 
            this.Telefon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            resources.ApplyResources(this.Telefon, "Telefon");
            this.Telefon.Name = "Telefon";
            this.Telefon.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            resources.ApplyResources(this.Column6, "Column6");
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Adresa
            // 
            this.Adresa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            resources.ApplyResources(this.Adresa, "Adresa");
            this.Adresa.Name = "Adresa";
            this.Adresa.ReadOnly = true;
            // 
            // Doniranja
            // 
            this.Doniranja.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Doniranja.DefaultCellStyle = dataGridViewCellStyle5;
            resources.ApplyResources(this.Doniranja, "Doniranja");
            this.Doniranja.Name = "Doniranja";
            this.Doniranja.ReadOnly = true;
            this.Doniranja.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditToolStripMenuItem,
            this.DeleteToolStripMenuItem});
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
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Image = global::BloodBank.Properties.Resources._90_905672_x_cross_close_symbol_icon_button_gui_close;
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            resources.ApplyResources(this.DeleteToolStripMenuItem, "DeleteToolStripMenuItem");
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // tbFilter
            // 
            resources.ApplyResources(this.tbFilter, "tbFilter");
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.TextChanged += new System.EventHandler(this.tbFilter_TextChanged);
            // 
            // lblFilter
            // 
            resources.ApplyResources(this.lblFilter, "lblFilter");
            this.lblFilter.ForeColor = System.Drawing.Color.Black;
            this.lblFilter.Name = "lblFilter";
            // 
            // pnlFilter
            // 
            this.pnlFilter.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlFilter.Controls.Add(this.tbFilter);
            this.pnlFilter.Controls.Add(this.lblFilter);
            resources.ApplyResources(this.pnlFilter, "pnlFilter");
            this.pnlFilter.Name = "pnlFilter";
            // 
            // BloodDonorsForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ControlBox = false;
            this.Controls.Add(this.gbBloodDonor);
            this.Controls.Add(this.dgvBloodDonors);
            this.Controls.Add(this.pnlFilter);
            this.Name = "BloodDonorsForm";
            this.gbBloodDonor.ResumeLayout(false);
            this.gbAddress.ResumeLayout(false);
            this.gbAddress.PerformLayout();
            this.gbInformation.ResumeLayout(false);
            this.gbInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBloodDonors)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbBloodDonor;
        private System.Windows.Forms.ComboBox cbRH;
        private System.Windows.Forms.ComboBox cbBloodType;
        private System.Windows.Forms.Label lblbloodType;
        private System.Windows.Forms.Label lblRh;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gbAddress;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.TextBox tbStreetNumber;
        private System.Windows.Forms.TextBox tbPostalCode;
        private System.Windows.Forms.TextBox tbStreet;
        private System.Windows.Forms.Label lblPostalCode;
        private System.Windows.Forms.TextBox tbState;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblStreetNumber;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbJMBG;
        private System.Windows.Forms.Label lblFathersName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblJMBG;
        private System.Windows.Forms.TextBox tbFathersName;
        private System.Windows.Forms.DataGridView dgvBloodDonors;
        private System.Windows.Forms.TextBox tbFilter;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.GroupBox gbInformation;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImeOca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn JMBG;
        private System.Windows.Forms.DataGridViewTextBoxColumn KrvnaGrupa;
        private System.Windows.Forms.DataGridViewTextBoxColumn RHFaktor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Doniranja;
    }
}