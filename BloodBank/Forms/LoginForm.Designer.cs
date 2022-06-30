
namespace BloodBank.Forms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.lblUserName = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pnlPassword = new System.Windows.Forms.Panel();
            this.pbPassword = new System.Windows.Forms.PictureBox();
            this.pnlUsername = new System.Windows.Forms.Panel();
            this.pbUsername = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblBloodBank = new System.Windows.Forms.Label();
            this.btnSerbian = new System.Windows.Forms.Button();
            this.btnEnglish = new System.Windows.Forms.Button();
            this.pnlPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPassword)).BeginInit();
            this.pnlUsername.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsername)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            resources.ApplyResources(this.lblUserName, "lblUserName");
            this.lblUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblUserName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblUserName.Name = "lblUserName";
            // 
            // tbUserName
            // 
            this.tbUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.tbUserName, "tbUserName");
            this.tbUserName.Name = "tbUserName";
            // 
            // lblPassword
            // 
            resources.ApplyResources(this.lblPassword, "lblPassword");
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPassword.Name = "lblPassword";
            // 
            // tbPassword
            // 
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.tbPassword, "tbPassword");
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.UseSystemPasswordChar = true;
            this.tbPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPassword_KeyPress);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            resources.ApplyResources(this.btnLogin, "btnLogin");
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pnlPassword
            // 
            this.pnlPassword.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPassword.Controls.Add(this.tbPassword);
            this.pnlPassword.Controls.Add(this.pbPassword);
            this.pnlPassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            resources.ApplyResources(this.pnlPassword, "pnlPassword");
            this.pnlPassword.Name = "pnlPassword";
            // 
            // pbPassword
            // 
            this.pbPassword.Image = global::BloodBank.Properties.Resources.passwordIcon;
            resources.ApplyResources(this.pbPassword, "pbPassword");
            this.pbPassword.Name = "pbPassword";
            this.pbPassword.TabStop = false;
            // 
            // pnlUsername
            // 
            this.pnlUsername.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUsername.Controls.Add(this.tbUserName);
            this.pnlUsername.Controls.Add(this.pbUsername);
            this.pnlUsername.ForeColor = System.Drawing.SystemColors.ControlText;
            resources.ApplyResources(this.pnlUsername, "pnlUsername");
            this.pnlUsername.Name = "pnlUsername";
            // 
            // pbUsername
            // 
            this.pbUsername.Image = global::BloodBank.Properties.Resources.userLogin;
            resources.ApplyResources(this.pbUsername, "pbUsername");
            this.pbUsername.Name = "pbUsername";
            this.pbUsername.TabStop = false;
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackgroundImage = global::BloodBank.Properties.Resources.min;
            resources.ApplyResources(this.btnMinimize, "btnMinimize");
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::BloodBank.Properties.Resources._90_905672_x_cross_close_symbol_icon_button_gui_close;
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.Name = "btnClose";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.lblBloodBank);
            this.panel3.Controls.Add(this.btnClose);
            this.panel3.Controls.Add(this.btnMinimize);
            this.panel3.ForeColor = System.Drawing.SystemColors.HighlightText;
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // lblBloodBank
            // 
            resources.ApplyResources(this.lblBloodBank, "lblBloodBank");
            this.lblBloodBank.ForeColor = System.Drawing.Color.White;
            this.lblBloodBank.Name = "lblBloodBank";
            // 
            // btnSerbian
            // 
            this.btnSerbian.BackgroundImage = global::BloodBank.Properties.Resources.flag_of_serbia_vector_logo1;
            resources.ApplyResources(this.btnSerbian, "btnSerbian");
            this.btnSerbian.Name = "btnSerbian";
            this.btnSerbian.UseVisualStyleBackColor = true;
            this.btnSerbian.Click += new System.EventHandler(this.btnSerbian_Click);
            // 
            // btnEnglish
            // 
            this.btnEnglish.BackgroundImage = global::BloodBank.Properties.Resources.flag_of_united_kingdom_vector_logo;
            resources.ApplyResources(this.btnEnglish, "btnEnglish");
            this.btnEnglish.Name = "btnEnglish";
            this.btnEnglish.UseVisualStyleBackColor = true;
            this.btnEnglish.Click += new System.EventHandler(this.btnEnglish_Click);
            // 
            // LoginForm
            // 
            this.BackgroundImage = global::BloodBank.Properties.Resources.background4;
            resources.ApplyResources(this, "$this");
            this.ControlBox = false;
            this.Controls.Add(this.btnEnglish);
            this.Controls.Add(this.btnSerbian);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.pnlPassword);
            this.Controls.Add(this.pnlUsername);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LoginForm";
            this.pnlPassword.ResumeLayout(false);
            this.pnlPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPassword)).EndInit();
            this.pnlUsername.ResumeLayout(false);
            this.pnlUsername.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsername)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.PictureBox pbUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.PictureBox pbPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel pnlPassword;
        private System.Windows.Forms.Panel pnlUsername;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblBloodBank;
        private System.Windows.Forms.Button btnSerbian;
        private System.Windows.Forms.Button btnEnglish;
    }
}