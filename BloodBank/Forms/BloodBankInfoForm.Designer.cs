
namespace BloodBank.Forms
{
    partial class BloodBankInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BloodBankInfoForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblName = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblPhoneNumbers = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.dgvOfficesInfo = new System.Windows.Forms.DataGridView();
            this.OfficeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblOffices = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOfficesInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            resources.ApplyResources(this.lblName, "lblName");
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblName.Name = "lblName";
            // 
            // lblMail
            // 
            resources.ApplyResources(this.lblMail, "lblMail");
            this.lblMail.BackColor = System.Drawing.Color.Transparent;
            this.lblMail.ForeColor = System.Drawing.Color.Black;
            this.lblMail.Name = "lblMail";
            // 
            // lblPhone
            // 
            resources.ApplyResources(this.lblPhone, "lblPhone");
            this.lblPhone.BackColor = System.Drawing.Color.Transparent;
            this.lblPhone.ForeColor = System.Drawing.Color.Black;
            this.lblPhone.Name = "lblPhone";
            // 
            // lblPhoneNumbers
            // 
            resources.ApplyResources(this.lblPhoneNumbers, "lblPhoneNumbers");
            this.lblPhoneNumbers.BackColor = System.Drawing.Color.Transparent;
            this.lblPhoneNumbers.ForeColor = System.Drawing.Color.Black;
            this.lblPhoneNumbers.Name = "lblPhoneNumbers";
            // 
            // lblEmail
            // 
            resources.ApplyResources(this.lblEmail, "lblEmail");
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.ForeColor = System.Drawing.Color.Black;
            this.lblEmail.Name = "lblEmail";
            // 
            // dgvOfficesInfo
            // 
            this.dgvOfficesInfo.AllowUserToAddRows = false;
            this.dgvOfficesInfo.AllowUserToDeleteRows = false;
            this.dgvOfficesInfo.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvOfficesInfo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            resources.ApplyResources(this.dgvOfficesInfo, "dgvOfficesInfo");
            this.dgvOfficesInfo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvOfficesInfo.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOfficesInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOfficesInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOfficesInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OfficeName,
            this.Email,
            this.Phone,
            this.Address});
            this.dgvOfficesInfo.EnableHeadersVisualStyles = false;
            this.dgvOfficesInfo.Name = "dgvOfficesInfo";
            this.dgvOfficesInfo.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOfficesInfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvOfficesInfo.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dgvOfficesInfo.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvOfficesInfo.RowTemplate.Height = 24;
            // 
            // OfficeName
            // 
            this.OfficeName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            resources.ApplyResources(this.OfficeName, "OfficeName");
            this.OfficeName.Name = "OfficeName";
            this.OfficeName.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            resources.ApplyResources(this.Email, "Email");
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            resources.ApplyResources(this.Phone, "Phone");
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.Address, "Address");
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // lblInfo
            // 
            resources.ApplyResources(this.lblInfo, "lblInfo");
            this.lblInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblInfo.ForeColor = System.Drawing.Color.Black;
            this.lblInfo.Name = "lblInfo";
            // 
            // lblOffices
            // 
            resources.ApplyResources(this.lblOffices, "lblOffices");
            this.lblOffices.BackColor = System.Drawing.Color.Transparent;
            this.lblOffices.ForeColor = System.Drawing.Color.Black;
            this.lblOffices.Name = "lblOffices";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::BloodBank.Properties.Resources.information_button;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // BloodBankInfoForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BloodBank.Properties.Resources.background1;
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.dgvOfficesInfo);
            this.Controls.Add(this.lblOffices);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPhoneNumbers);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblName);
            this.Name = "BloodBankInfoForm";
            this.Load += new System.EventHandler(this.BloodBankInfoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOfficesInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblPhoneNumbers;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.DataGridView dgvOfficesInfo;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblOffices;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn OfficeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
    }
}