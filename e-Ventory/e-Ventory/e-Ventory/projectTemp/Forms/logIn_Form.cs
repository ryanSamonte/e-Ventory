using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using eVentoryLibraries;

namespace projectTemp
{
    public partial class logIn_Form : Form
    {
        
        SqlConnection con = new SqlConnection(@DBConnection.connect());
        
        public logIn_Form()
        {
            InitializeComponent();
            lblUsername.Visible = false;
            lblPassword.Visible = false;
        }

        private void logIn_Form_Load(object sender, EventArgs e)
        {
            form_FadeTimer.Start();
            this.ActiveControl = minimize;
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
                smallLabelTrans.ShowSync(lblUsername);
            }
        }

        private void userNametxt_Leave_1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(userNametxt.Text))
            {
                userNametxt.Text = "Username";
                lblUsername.Visible = false;
            }
        }

        private void passWordtxt_Enter_1(object sender, EventArgs e)
        {
            //userNametxt.ForeColor = Color.White;
            smallLabelTrans.ShowSync(lblPassword);
            if (passWordtxt.Text.Trim().Equals("Password")) 
            {
                //smallLabelTrans.ShowSync(lblPassword);
                passWordtxt.Text = "";
                if (lblPassword.Visible == true)
                {
                    passWordtxt.isPassword = true;
                    showBtn.Visible = false;
                }
            }
        }

        private void passWordtxt_Leave_1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(passWordtxt.Text))
            {
                //lblPassword.Visible = true;
                passWordtxt.Text = "Password";
                passWordtxt.isPassword = false;
                smallLabelTrans.Hide(lblPassword);
                logInBtn.Focus();
            }
        }

        private void close_Click_1(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to exit?", "e-Ventory", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                deleteStatement.deleteAllLoggedAdmin(DBConnection.connect());
                Application.Exit();
            }
        }

        private void loginButton_Click_1(object sender, EventArgs e)
        {
            if(userNametxt.Text.Trim().Equals("") || passWordtxt.Text.Trim().Equals(""))
            {

                MetroFramework.MetroMessageBox.Show(this, "Please input username/password", "e-Ventory", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(dataLib.logInVerification(userNametxt.Text.Trim(), passWordtxt.Text.Trim(), DBConnection.connect()) == true)
                {
                    insertStatements.insertLoggedAdmin(DBConnection.connect(), dataLib.getLoggedID(DBConnection.connect(), userNametxt.Text.Trim()), userNametxt.Text.Trim());
                    insertStatements.insertSystemLog(DBConnection.connect(), "Log-in", dataLib.loggedAdminName(DBConnection.connect(), dataLib.getLoggedAdminID(DBConnection.connect())), dataLib.currentDateAndTime());
                    mainMenu_Form mainObj = new mainMenu_Form();
                    this.Hide();
                    mainObj.Show();
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Incorrect username/password", "e-Ventory", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    userNametxt.Text = "";
                    passWordtxt.Text = "";
                    userNametxt.Focus();
                }
            }
        }

        private void signUpbtn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            signUp_Form signUp_Obj = new signUp_Form();
            signUp_Obj.Show();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            passWordtxt.isPassword = false;
            showBtn.Visible = false;
            hideBtn.Visible = true;
        }

        private void hideBtn_Click(object sender, EventArgs e)
        {
            passWordtxt.isPassword = true;
            showBtn.Visible = true;
            hideBtn.Visible = false;
        }

        private void passWordtxt_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData != Keys.Back)
            {
                showBtn.Visible = true;
            }
            else
            {
                if (passWordtxt.Text.Equals(""))
                {
                    showBtn.Visible = false;
                }
            }
        }
    }
}
