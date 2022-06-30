using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Resources;
using System.Threading;

namespace BloodBank.Forms
{
    public partial class LoginForm : Form
    {
        readonly CultureInfo culture;
        ResourceManager rm;
        public LoginForm( CultureInfo culture)
        {
            this.culture = culture;
            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;
            rm = new ResourceManager("BloodBank.Resources.Strings", System.Reflection.Assembly.GetExecutingAssembly());
            
            InitializeComponent();
        }
       
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = tbUserName.Text.Trim();
            string password = tbPassword.Text.Trim();
            

            if (userName != "" && password != "")
            {
                try
                {
                    var accountType = Util.Common.DataFactory.Accounts.CheckAccount(userName, password);

                    if (accountType.Equals("1") || accountType.Equals("2"))//accountType: 1= doktor, 2=laborant;
                    {
                        this.Hide();
                        Form f = new MainWindowForm(userName, accountType, Thread.CurrentThread.CurrentCulture);
                        f.ShowDialog();
                        this.Close();
                    }
                     else
                        MessageBox.Show(rm.GetString("WrongData"), rm.GetString("FailedLogin"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                   
              
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, rm.GetString("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(rm.GetString("EnterData"),rm.GetString("FailedLogin"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            tbUserName.Clear();
            tbPassword.Clear();
        }

        private void tbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
             char enterChar = (char)13;

            if (e.KeyChar == enterChar)
                btnLogin.PerformClick();
        }

        private void btnSerbian_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new LoginForm(new CultureInfo("sr"));
            f.ShowDialog();
            this.Close();
        }

        private void btnEnglish_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new LoginForm(new CultureInfo("en"));
            f.ShowDialog();
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

    }
}



