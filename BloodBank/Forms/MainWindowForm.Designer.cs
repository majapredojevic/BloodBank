
namespace BloodBank.Forms
{
    partial class MainWindowForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindowForm));
            this.pnlNavigation = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.lblBloodBank = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnInfo = new System.Windows.Forms.Button();
            this.pnlMainWindow = new System.Windows.Forms.Panel();
            this.pnlNavigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNavigation
            // 
            this.pnlNavigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.pnlNavigation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNavigation.Controls.Add(this.pictureBox1);
            this.pnlNavigation.Controls.Add(this.lblUsername);
            this.pnlNavigation.Controls.Add(this.btnMaximize);
            this.pnlNavigation.Controls.Add(this.btnClose);
            this.pnlNavigation.Controls.Add(this.btnMinimize);
            resources.ApplyResources(this.pnlNavigation, "pnlNavigation");
            this.pnlNavigation.ForeColor = System.Drawing.SystemColors.Control;
            this.pnlNavigation.Name = "pnlNavigation";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BloodBank.Properties.Resources.user;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // lblUsername
            // 
            resources.ApplyResources(this.lblUsername, "lblUsername");
            this.lblUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Name = "lblUsername";
            // 
            // btnMaximize
            // 
            resources.ApplyResources(this.btnMaximize, "btnMaximize");
            this.btnMaximize.BackgroundImage = global::BloodBank.Properties.Resources.max;
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.BackgroundImage = global::BloodBank.Properties.Resources._90_905672_x_cross_close_symbol_icon_button_gui_close;
            this.btnClose.Name = "btnClose";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMinimize
            // 
            resources.ApplyResources(this.btnMinimize, "btnMinimize");
            this.btnMinimize.BackgroundImage = global::BloodBank.Properties.Resources.min;
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // lblBloodBank
            // 
            resources.ApplyResources(this.lblBloodBank, "lblBloodBank");
            this.lblBloodBank.ForeColor = System.Drawing.Color.White;
            this.lblBloodBank.Name = "lblBloodBank";
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.Silver;
            resources.ApplyResources(this.pnlMenu, "pnlMenu");
            this.pnlMenu.Controls.Add(this.pbIcon);
            this.pnlMenu.Controls.Add(this.btnLogout);
            this.pnlMenu.Controls.Add(this.btnThree);
            this.pnlMenu.Controls.Add(this.btnTwo);
            this.pnlMenu.Controls.Add(this.btnOne);
            this.pnlMenu.Name = "pnlMenu";
            // 
            // pbIcon
            // 
            this.pbIcon.Image = global::BloodBank.Properties.Resources.Icon;
            resources.ApplyResources(this.pbIcon, "pbIcon");
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.TabStop = false;
            // 
            // btnLogout
            // 
            resources.ApplyResources(this.btnLogout, "btnLogout");
            this.btnLogout.BackColor = System.Drawing.Color.Silver;
            this.btnLogout.BackgroundImage = global::BloodBank.Properties.Resources.PinClipart_com_government_power_clipart_1821638;
            this.btnLogout.ForeColor = System.Drawing.Color.Silver;
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnThree
            // 
            resources.ApplyResources(this.btnThree, "btnThree");
            this.btnThree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.btnThree.ForeColor = System.Drawing.Color.White;
            this.btnThree.Name = "btnThree";
            this.btnThree.UseVisualStyleBackColor = false;
            this.btnThree.Click += new System.EventHandler(this.btnThree_Click);
            // 
            // btnTwo
            // 
            resources.ApplyResources(this.btnTwo, "btnTwo");
            this.btnTwo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.btnTwo.ForeColor = System.Drawing.Color.White;
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.UseVisualStyleBackColor = false;
            this.btnTwo.Click += new System.EventHandler(this.btnTwo_Click);
            // 
            // btnOne
            // 
            resources.ApplyResources(this.btnOne, "btnOne");
            this.btnOne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.btnOne.ForeColor = System.Drawing.Color.White;
            this.btnOne.Name = "btnOne";
            this.btnOne.UseVisualStyleBackColor = false;
            this.btnOne.Click += new System.EventHandler(this.btnOne_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnInfo);
            this.panel1.Controls.Add(this.lblBloodBank);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // btnInfo
            // 
            resources.ApplyResources(this.btnInfo, "btnInfo");
            this.btnInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnInfo.BackgroundImage = global::BloodBank.Properties.Resources.info;
            this.btnInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // pnlMainWindow
            // 
            this.pnlMainWindow.BackColor = System.Drawing.Color.White;
            this.pnlMainWindow.BackgroundImage = global::BloodBank.Properties.Resources.background1;
            resources.ApplyResources(this.pnlMainWindow, "pnlMainWindow");
            this.pnlMainWindow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMainWindow.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlMainWindow.Name = "pnlMainWindow";
            // 
            // MainWindowForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ControlBox = false;
            this.Controls.Add(this.pnlMainWindow);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlNavigation);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainWindowForm";
            this.pnlNavigation.ResumeLayout(false);
            this.pnlNavigation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlNavigation;
        private System.Windows.Forms.Label lblBloodBank;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.PictureBox pbIcon;
        private System.Windows.Forms.Panel pnlMainWindow;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}