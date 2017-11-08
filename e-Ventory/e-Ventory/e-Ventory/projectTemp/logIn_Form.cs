using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectTemp
{
    public partial class logIn_Form : Form
    {
        public logIn_Form()
        {
            InitializeComponent();
        }

        private void logIn_Form_Load(object sender, EventArgs e)
        {
            form_FadeTimer.Start();
        }

        private void form_FadeTimer_Tick(object sender, EventArgs e)
        {
            this.Opacity += .40;
            if(this.Opacity == 100)
            {
                form_FadeTimer.Stop();
            }
        }

        private void minimize_MouseHover(object sender, EventArgs e)
        {
            minimize.ForeColor = Color.FromArgb(41, 128, 185);
        }
        private void minimize_MouseLeave(object sender, EventArgs e)
        {
            minimize.ForeColor = Color.FromArgb(236, 240, 241);
        }
        private void close_MouseHover_1(object sender, EventArgs e)
        {
            close.ForeColor = Color.Red;
        }

        private void close_MouseLeave_1(object sender, EventArgs e)
        {
            close.ForeColor = Color.FromArgb(236, 240, 241);
        }

        private void userNametxt_Enter_1(object sender, EventArgs e)
        {
            if (userNametxt.Text.Trim().Equals("Username"))
            {
                userNametxt.Text = "";
            }
        }

        private void userNametxt_Leave_1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(userNametxt.Text))
            {
                userNametxt.Text = "Username";
            }
        }

        private void passWordtxt_Enter_1(object sender, EventArgs e)
        {
            if (passWordtxt.Text.Trim().Equals("Password"))
            {
                passWordtxt.Text = "";
                passWordtxt.isPassword = true;
            }
        }

        private void passWordtxt_Leave_1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(passWordtxt.Text))
            {
                passWordtxt.Text = "Password";
                passWordtxt.isPassword = false;
            }
        }

        private void close_Click_1(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to exit?", "e-Ventory", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void loginButton_Click_1(object sender, EventArgs e)
        {
            mainMenu_Form main_menuObj = new mainMenu_Form();
            this.Hide();
            main_menuObj.Show();
        }

        private void signUpbtn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            signUp_Form signUp_Obj = new signUp_Form();
            signUp_Obj.Show();
        }
    }
}
