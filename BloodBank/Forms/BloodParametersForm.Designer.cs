
namespace BloodBank.Forms
{
    partial class BloodParametersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BloodParametersForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tcCiphers = new System.Windows.Forms.TabControl();
            this.tpBloodParameters = new System.Windows.Forms.TabPage();
            this.gbBloodParameters = new System.Windows.Forms.GroupBox();
            this.dgvBloodParameters = new System.Windows.Forms.DataGridView();
            this.columnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnRefValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.pnlAddOrEdit = new System.Windows.Forms.Panel();
            this.lblUnit = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbUnit = new System.Windows.Forms.TextBox();
            this.gbReferenceValues = new System.Windows.Forms.GroupBox();
            this.rbLessThan = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.tbLessThan = new System.Windows.Forms.TextBox();
            this.rbGreaterThan = new System.Windows.Forms.RadioButton();
            this.rbRange = new System.Windows.Forms.RadioButton();
            this.tbRangeValue1 = new System.Windows.Forms.TextBox();
            this.tbRangeValue2 = new System.Windows.Forms.TextBox();
            this.tbGreaterThan = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tpViruses = new System.Windows.Forms.TabPage();
            this.tpBloodTypes = new System.Windows.Forms.TabPage();
            this.dgvBloodType = new System.Windows.Forms.DataGridView();
            this.BloodType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpRHFactor = new System.Windows.Forms.TabPage();
            this.dgvRHFactor = new System.Windows.Forms.DataGridView();
            this.RHFactor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcCiphers.SuspendLayout();
            this.tpBloodParameters.SuspendLayout();
            this.gbBloodParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBloodParameters)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.pnlFilter.SuspendLayout();
            this.pnlAddOrEdit.SuspendLayout();
            this.gbReferenceValues.SuspendLayout();
            this.tpBloodTypes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBloodType)).BeginInit();
            this.tpRHFactor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRHFactor)).BeginInit();
            this.SuspendLayout();
            // 
            // tcCiphers
            // 
            this.tcCiphers.Controls.Add(this.tpBloodParameters);
            this.tcCiphers.Controls.Add(this.tpViruses);
            this.tcCiphers.Controls.Add(this.tpBloodTypes);
            this.tcCiphers.Controls.Add(this.tpRHFactor);
            resources.ApplyResources(this.tcCiphers, "tcCiphers");
            this.tcCiphers.Name = "tcCiphers";
            this.tcCiphers.SelectedIndex = 0;
            this.tcCiphers.SelectedIndexChanged += new System.EventHandler(this.tcCiphers_SelectedIndexChanged);
            // 
            // tpBloodParameters
            // 
            this.tpBloodParameters.Controls.Add(this.gbBloodParameters);
            this.tpBloodParameters.Controls.Add(this.pnlFilter);
            this.tpBloodParameters.Controls.Add(this.pnlAddOrEdit);
            resources.ApplyResources(this.tpBloodParameters, "tpBloodParameters");
            this.tpBloodParameters.Name = "tpBloodParameters";
            this.tpBloodParameters.UseVisualStyleBackColor = true;
            // 
            // gbBloodParameters
            // 
            this.gbBloodParameters.BackColor = System.Drawing.SystemColors.Control;
            this.gbBloodParameters.Controls.Add(this.dgvBloodParameters);
            resources.ApplyResources(this.gbBloodParameters, "gbBloodParameters");
            this.gbBloodParameters.Name = "gbBloodParameters";
            this.gbBloodParameters.TabStop = false;
            // 
            // dgvBloodParameters
            // 
            this.dgvBloodParameters.AllowUserToAddRows = false;
            this.dgvBloodParameters.AllowUserToDeleteRows = false;
            this.dgvBloodParameters.AllowUserToResizeColumns = false;
            this.dgvBloodParameters.AllowUserToResizeRows = false;
            resources.ApplyResources(this.dgvBloodParameters, "dgvBloodParameters");
            this.dgvBloodParameters.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvBloodParameters.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBloodParameters.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBloodParameters.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBloodParameters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBloodParameters.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnName,
            this.Unit,
            this.columnRefValue});
            this.dgvBloodParameters.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBloodParameters.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBloodParameters.EnableHeadersVisualStyles = false;
            this.dgvBloodParameters.GridColor = System.Drawing.Color.DimGray;
            this.dgvBloodParameters.MultiSelect = false;
            this.dgvBloodParameters.Name = "dgvBloodParameters";
            this.dgvBloodParameters.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBloodParameters.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBloodParameters.RowHeadersVisible = false;
            this.dgvBloodParameters.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.dgvBloodParameters.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBloodParameters.RowTemplate.Height = 24;
            this.dgvBloodParameters.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBloodParameters.ShowCellToolTips = false;
            this.dgvBloodParameters.ShowEditingIcon = false;
            this.dgvBloodParameters.EnabledChanged += new System.EventHandler(this.dgvBloodParameters_EnabledChanged);
            // 
            // columnName
            // 
            this.columnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            resources.ApplyResources(this.columnName, "columnName");
            this.columnName.Name = "columnName";
            this.columnName.ReadOnly = true;
            // 
            // Unit
            // 
            this.Unit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            resources.ApplyResources(this.Unit, "Unit");
            this.Unit.Name = "Unit";
            this.Unit.ReadOnly = true;
            // 
            // columnRefValue
            // 
            this.columnRefValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.columnRefValue, "columnRefValue");
            this.columnRefValue.Name = "columnRefValue";
            this.columnRefValue.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditToolStripMenuItem,
            this.DeleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
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
            // pnlFilter
            // 
            this.pnlFilter.BackColor = System.Drawing.SystemColors.Control;
            this.pnlFilter.Controls.Add(this.lblSearch);
            this.pnlFilter.Controls.Add(this.tbFilter);
            resources.ApplyResources(this.pnlFilter, "pnlFilter");
            this.pnlFilter.Name = "pnlFilter";
            // 
            // lblSearch
            // 
            resources.ApplyResources(this.lblSearch, "lblSearch");
            this.lblSearch.BackColor = System.Drawing.Color.Transparent;
            this.lblSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSearch.Name = "lblSearch";
            // 
            // tbFilter
            // 
            resources.ApplyResources(this.tbFilter, "tbFilter");
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.TextChanged += new System.EventHandler(this.tbFilter_TextChanged);
            // 
            // pnlAddOrEdit
            // 
            this.pnlAddOrEdit.BackColor = System.Drawing.SystemColors.Control;
            this.pnlAddOrEdit.Controls.Add(this.lblUnit);
            this.pnlAddOrEdit.Controls.Add(this.btnCancel);
            this.pnlAddOrEdit.Controls.Add(this.btnSave);
            this.pnlAddOrEdit.Controls.Add(this.tbUnit);
            this.pnlAddOrEdit.Controls.Add(this.gbReferenceValues);
            this.pnlAddOrEdit.Controls.Add(this.btnAdd);
            this.pnlAddOrEdit.Controls.Add(this.lblName);
            this.pnlAddOrEdit.Controls.Add(this.tbName);
            resources.ApplyResources(this.pnlAddOrEdit, "pnlAddOrEdit");
            this.pnlAddOrEdit.Name = "pnlAddOrEdit";
            // 
            // lblUnit
            // 
            resources.ApplyResources(this.lblUnit, "lblUnit");
            this.lblUnit.BackColor = System.Drawing.Color.Transparent;
            this.lblUnit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUnit.Name = "lblUnit";
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
            // tbUnit
            // 
            resources.ApplyResources(this.tbUnit, "tbUnit");
            this.tbUnit.Name = "tbUnit";
            // 
            // gbReferenceValues
            // 
            resources.ApplyResources(this.gbReferenceValues, "gbReferenceValues");
            this.gbReferenceValues.Controls.Add(this.rbLessThan);
            this.gbReferenceValues.Controls.Add(this.label7);
            this.gbReferenceValues.Controls.Add(this.tbLessThan);
            this.gbReferenceValues.Controls.Add(this.rbGreaterThan);
            this.gbReferenceValues.Controls.Add(this.rbRange);
            this.gbReferenceValues.Controls.Add(this.tbRangeValue1);
            this.gbReferenceValues.Controls.Add(this.tbRangeValue2);
            this.gbReferenceValues.Controls.Add(this.tbGreaterThan);
            this.gbReferenceValues.ForeColor = System.Drawing.Color.Black;
            this.gbReferenceValues.Name = "gbReferenceValues";
            this.gbReferenceValues.TabStop = false;
            // 
            // rbLessThan
            // 
            resources.ApplyResources(this.rbLessThan, "rbLessThan");
            this.rbLessThan.ForeColor = System.Drawing.Color.Black;
            this.rbLessThan.Name = "rbLessThan";
            this.rbLessThan.TabStop = true;
            this.rbLessThan.UseVisualStyleBackColor = true;
            this.rbLessThan.CheckedChanged += new System.EventHandler(this.rbLessThan_CheckedChanged);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // tbLessThan
            // 
            resources.ApplyResources(this.tbLessThan, "tbLessThan");
            this.tbLessThan.Name = "tbLessThan";
            this.tbLessThan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLessThan_KeyPress);
            // 
            // rbGreaterThan
            // 
            resources.ApplyResources(this.rbGreaterThan, "rbGreaterThan");
            this.rbGreaterThan.ForeColor = System.Drawing.Color.Black;
            this.rbGreaterThan.Name = "rbGreaterThan";
            this.rbGreaterThan.TabStop = true;
            this.rbGreaterThan.UseVisualStyleBackColor = true;
            this.rbGreaterThan.CheckedChanged += new System.EventHandler(this.rbGreaterThan_CheckedChanged);
            // 
            // rbRange
            // 
            resources.ApplyResources(this.rbRange, "rbRange");
            this.rbRange.ForeColor = System.Drawing.Color.Black;
            this.rbRange.Name = "rbRange";
            this.rbRange.TabStop = true;
            this.rbRange.UseVisualStyleBackColor = true;
            this.rbRange.CheckedChanged += new System.EventHandler(this.rbRange_CheckedChanged);
            // 
            // tbRangeValue1
            // 
            resources.ApplyResources(this.tbRangeValue1, "tbRangeValue1");
            this.tbRangeValue1.Name = "tbRangeValue1";
            this.tbRangeValue1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLessThan_KeyPress);
            // 
            // tbRangeValue2
            // 
            resources.ApplyResources(this.tbRangeValue2, "tbRangeValue2");
            this.tbRangeValue2.Name = "tbRangeValue2";
            this.tbRangeValue2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLessThan_KeyPress);
            // 
            // tbGreaterThan
            // 
            resources.ApplyResources(this.tbGreaterThan, "tbGreaterThan");
            this.tbGreaterThan.Name = "tbGreaterThan";
            this.tbGreaterThan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLessThan_KeyPress);
            // 
            // btnAdd
            // 
            resources.ApplyResources(this.btnAdd, "btnAdd");
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.ForeColor = System.Drawing.Color.Green;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblName
            // 
            resources.ApplyResources(this.lblName, "lblName");
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblName.Name = "lblName";
            // 
            // tbName
            // 
            resources.ApplyResources(this.tbName, "tbName");
            this.tbName.Name = "tbName";
            // 
            // tpViruses
            // 
            resources.ApplyResources(this.tpViruses, "tpViruses");
            this.tpViruses.Name = "tpViruses";
            this.tpViruses.UseVisualStyleBackColor = true;
            // 
            // tpBloodTypes
            // 
            this.tpBloodTypes.BackgroundImage = global::BloodBank.Properties.Resources.background1;
            resources.ApplyResources(this.tpBloodTypes, "tpBloodTypes");
            this.tpBloodTypes.Controls.Add(this.dgvBloodType);
            this.tpBloodTypes.Name = "tpBloodTypes";
            this.tpBloodTypes.UseVisualStyleBackColor = true;
            // 
            // dgvBloodType
            // 
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvBloodType.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            resources.ApplyResources(this.dgvBloodType, "dgvBloodType");
            this.dgvBloodType.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBloodType.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBloodType.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvBloodType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBloodType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BloodType});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBloodType.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvBloodType.EnableHeadersVisualStyles = false;
            this.dgvBloodType.MultiSelect = false;
            this.dgvBloodType.Name = "dgvBloodType";
            this.dgvBloodType.ReadOnly = true;
            this.dgvBloodType.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBloodType.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvBloodType.RowHeadersVisible = false;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvBloodType.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvBloodType.RowTemplate.Height = 24;
            // 
            // BloodType
            // 
            this.BloodType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.BloodType, "BloodType");
            this.BloodType.Name = "BloodType";
            this.BloodType.ReadOnly = true;
            // 
            // tpRHFactor
            // 
            this.tpRHFactor.BackgroundImage = global::BloodBank.Properties.Resources.background1;
            resources.ApplyResources(this.tpRHFactor, "tpRHFactor");
            this.tpRHFactor.Controls.Add(this.dgvRHFactor);
            this.tpRHFactor.Name = "tpRHFactor";
            this.tpRHFactor.UseVisualStyleBackColor = true;
            // 
            // dgvRHFactor
            // 
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvRHFactor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            resources.ApplyResources(this.dgvRHFactor, "dgvRHFactor");
            this.dgvRHFactor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRHFactor.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRHFactor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvRHFactor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRHFactor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RHFactor});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRHFactor.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvRHFactor.EnableHeadersVisualStyles = false;
            this.dgvRHFactor.MultiSelect = false;
            this.dgvRHFactor.Name = "dgvRHFactor";
            this.dgvRHFactor.ReadOnly = true;
            this.dgvRHFactor.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRHFactor.RowHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvRHFactor.RowHeadersVisible = false;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvRHFactor.RowsDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvRHFactor.RowTemplate.Height = 24;
            // 
            // RHFactor
            // 
            resources.ApplyResources(this.RHFactor, "RHFactor");
            this.RHFactor.Name = "RHFactor";
            this.RHFactor.ReadOnly = true;
            // 
            // BloodParametersForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tcCiphers);
            this.Name = "BloodParametersForm";
            this.tcCiphers.ResumeLayout(false);
            this.tpBloodParameters.ResumeLayout(false);
            this.gbBloodParameters.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBloodParameters)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            this.pnlAddOrEdit.ResumeLayout(false);
            this.pnlAddOrEdit.PerformLayout();
            this.gbReferenceValues.ResumeLayout(false);
            this.gbReferenceValues.PerformLayout();
            this.tpBloodTypes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBloodType)).EndInit();
            this.tpRHFactor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRHFactor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tcCiphers;
        private System.Windows.Forms.TabPage tpViruses;
        private System.Windows.Forms.TabPage tpBloodTypes;
        private System.Windows.Forms.TabPage tpRHFactor;
        private System.Windows.Forms.DataGridView dgvRHFactor;
        private System.Windows.Forms.TabPage tpBloodParameters;
        private System.Windows.Forms.GroupBox gbBloodParameters;
        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox tbFilter;
        private System.Windows.Forms.Panel pnlAddOrEdit;
        private System.Windows.Forms.GroupBox gbReferenceValues;
        private System.Windows.Forms.RadioButton rbLessThan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbLessThan;
        private System.Windows.Forms.RadioButton rbGreaterThan;
        private System.Windows.Forms.RadioButton rbRange;
        private System.Windows.Forms.TextBox tbRangeValue1;
        private System.Windows.Forms.TextBox tbRangeValue2;
        private System.Windows.Forms.TextBox tbGreaterThan;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvBloodParameters;
        private System.Windows.Forms.DataGridView dgvBloodType;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.TextBox tbUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn RHFactor;
        private System.Windows.Forms.DataGridViewTextBoxColumn BloodType;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnRefValue;
    }
}