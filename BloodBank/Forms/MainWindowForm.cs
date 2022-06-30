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
using System.Threading;
using System.Resources;

namespace BloodBank.Forms
{
    public partial class MainWindowForm : Form
    {
        protected Form activeForm;
        private readonly string username = "";
        private readonly string accountType= "";
        private readonly CultureInfo culture;
        private readonly ResourceManager rm;

        public MainWindowForm(string username,string accountType, CultureInfo culture)
        {
            this.culture = culture;
            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;
            rm = new ResourceManager("BloodBank.Resources.Strings", System.Reflection.Assembly.GetExecutingAssembly());

            InitializeComponent();

            this.username = username;
            this.accountType = accountType;
            SetButtons(username, accountType);
        }

        private void SetButtons(string username, string accountType)
        {
            lblUsername.Text = username;

            if (accountType.Equals("1"))
            {
                btnOne.Text = rm.GetString("Blood donors");
                btnTwo.Text = rm.GetString("Blood donation");

            }
            else
            {
                btnOne.Text = rm.GetString("Ciphers");
                btnTwo.Text = rm.GetString("New report");

            }

        }
        private void btnOne_Click(object sender, EventArgs e)
        {
            if (accountType.Equals("1"))

                OpenChildForm(new BloodDonorsForm());
          else
                OpenChildForm(new BloodParametersForm());

            btnOne.BackColor = Color.FromArgb(242,0,0);
        }


        private void btnTwo_Click(object sender, EventArgs e)
        {
            if (accountType.Equals("1"))

                OpenChildForm(new BloodDonationForm(username));
        else
                OpenChildForm(new NewReportForm(username));

            btnTwo.BackColor = Color.FromArgb(242, 0, 0);
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AnalysisReportsForm());

            btnThree.BackColor = Color.FromArgb(242, 0, 0);

        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            OpenChildForm(new BloodBankInfoForm());
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
                this.WindowState = FormWindowState.Normal;

        }


        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new LoginForm(new CultureInfo("sr"));
            f.ShowDialog();
            this.Close();
        }

       



        private void clearButtonsColor()
        {
            btnOne.BackColor = Color.FromArgb(88, 88, 88);
            btnTwo.BackColor = Color.FromArgb(88, 88, 88);
            btnThree.BackColor = Color.FromArgb(88, 88, 88);

        }

        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                clearButtonsColor();
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnlMainWindow.Controls.Add(childForm);
            this.pnlMainWindow.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
