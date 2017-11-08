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
    public partial class signUp_Form : Form
    {
        SqlConnection con = new SqlConnection(DBConnection.connect());
        int adminCount = 0;
        public signUp_Form()
        {
            InitializeComponent();
            idGenerator();
            this.ActiveControl = backBtn;
        }

        private void backBtn_MouseHover(object sender, EventArgs e)
        {
            backBtn.ForeColor = Color.FromArgb(41, 128, 185);
        }

        private void backBtn_MouseLeave(object sender, EventArgs e)
        {
            backBtn.ForeColor = Color.FromArgb(236, 240, 241);
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            logIn_Form logIn_Obj = new logIn_Form();
            logIn_Obj.Show();
        }

        private void lastNameTxt_Enter(object sender, EventArgs e)
        {
            if(lastNameTxt.Text.Trim().Equals("Last Name"))
            {
                lastNameTxt.Text = "";
            }
        }

        private void lastNameTxt_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(lastNameTxt.Text))
            {
                lastNameTxt.Text = "Last Name";
            }
        }

        private void firstNameTxt_Enter(object sender, EventArgs e)
        {
            if(firstNameTxt.Text.Trim().Equals("First Name"))
            {
                firstNameTxt.Text = "";
            }
        }

        private void firstNameTxt_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(firstNameTxt.Text))
            {
                firstNameTxt.Text = "First Name";
            }
        }

        private void ageTxt_Enter(object sender, EventArgs e)
        {
            if (ageTxt.Text.Trim().Equals("Age"))
            {
                ageTxt.Text = "";
            }
        }

        private void ageTxt_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(ageTxt.Text))
            {
                ageTxt.Text = "Age";
            }
        }

        private void contactNumTxt_Enter(object sender, EventArgs e)
        {
            if (contactNumTxt.Text.Trim().Equals("Contact Number"))
            {
                contactNumTxt.Text = "";
            }
        }

        private void contactNumTxt_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(contactNumTxt.Text))
            {
                contactNumTxt.Text = "Contact Number";
            }
        }

        private void houseNumTxt_Enter(object sender, EventArgs e)
        {
            if (houseNumTxt.Text.Trim().Equals("House No"))
            {
                houseNumTxt.Text = "";
            }
        }

        private void houseNumTxt_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(houseNumTxt.Text))
            {
                houseNumTxt.Text = "House No";
            }
        }
 
        private void streetNameTxt_Enter(object sender, EventArgs e)
        {
            if (streetNameTxt.Text.Trim().Equals("Street Name"))
            {
                streetNameTxt.Text = "";
            }
        }

        private void streetNameTxt_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(streetNameTxt.Text))
            {
                streetNameTxt.Text = "Street Name";
            }
        }

        private void brgyTxt_Enter(object sender, EventArgs e)
        {
            if (brgyTxt.Text.Trim().Equals("Barangay"))
            {
                brgyTxt.Text = "";
            }
        }

        private void brgyTxt_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(brgyTxt.Text))
            {
                brgyTxt.Text = "Barangay";
            }
        }

        private void cityTxt_Enter(object sender, EventArgs e)
        {
            if (cityTxt.Text.Trim().Equals("City"))
            {
                cityTxt.Text = "";
            }
        }

        private void cityTxt_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cityTxt.Text))
            {
                cityTxt.Text = "City";
            }
        }

        private void uNametxt_Enter(object sender, EventArgs e)
        {
            if (uNametxt.Text.Trim().Equals("Username"))
            {
                uNametxt.Text = "";
            }
        }

        private void uNametxt_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(uNametxt.Text))
            {
                uNametxt.Text = "Username";
            }
        }

        private void passWtxt_Enter(object sender, EventArgs e)
        {
            if (passWordtxt.Text.Trim().Equals("Password"))
            {
                passWordtxt.Text = "";
                passWordtxt.isPassword = true;
                showBtn1.Visible = false;
            }
        }

        private void passWtxt_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(passWordtxt.Text))
            {
                passWordtxt.Text = "Password";
                passWordtxt.isPassword = false;
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            bool emptyFields = lastNameTxt.Text.Equals("") || firstNameTxt.Text.Equals("") || ageTxt.Text.Equals("") || contactNumTxt.Text.Equals("") || houseNumTxt.Text.Equals("") || streetNameTxt.Text.Equals("") || brgyTxt.Text.Equals("") || cityTxt.Text.Equals("") || uNametxt.Text.Equals("") || passWordtxt.Text.Equals("") || (!(male.Checked) && !(female.Checked));
            char genderSymbol = 'a';
            if (emptyFields == true)//if empty fields
            {
                MetroFramework.MetroMessageBox.Show(this, "Kindly fill-out all fields", "e-Ventory", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
               
                if (validations.userNameExists(uNametxt.Text.Trim(), DBConnection.connect()) == true)//if username alredy exists
                {
                    MetroFramework.MetroMessageBox.Show(this, "Username already exists", "e-Ventory", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    uNametxt.Text = "";
                    uNametxt.Focus();
                }
                else
                {
                    if (male.Checked)
                    {
                        genderSymbol = 'M';
                    }
                    else if (female.Checked)
                    {
                        genderSymbol = 'F';
                    }
                    
                        insertStatements.insertAdmin(DBConnection.connect(), adminIDTxt.Text.Trim(), lastNameTxt.Text.Trim(), firstNameTxt.Text.Trim(), genderSymbol, ageTxt.Text.Trim(), contactNumTxt.Text.Trim(), houseNumTxt.Text.Trim(), streetNameTxt.Text.Trim(), brgyTxt.Text.Trim(), cityTxt.Text.Trim(), uNametxt.Text.Trim(), passWordtxt.Text.Trim(), fbUsername.Text.Trim(), fbPassword.Text.Trim());
                        insertStatements.insertSystemLog(DBConnection.connect(), "Account creation", firstNameTxt.Text + " " + lastNameTxt.Text, dataLib.currentDateAndTime());
                        MetroFramework.MetroMessageBox.Show(this, "Account successfully created!", "e-Ventory", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        idGenerator();
                        clearInputs();
                }
            }
        }

        public void idGenerator()
        {
            int lastID = 0;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    SqlDataAdapter dataAdapterAdminCount = new SqlDataAdapter("SELECT * FROM tb_adminInformations", con);
                    DataTable adminCountTable = new DataTable();
                    dataAdapterAdminCount.Fill(adminCountTable);
                    adminCount =  adminCountTable.Rows.Count;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "dataAdapterSuperAdminID");
            }
            finally
            {
                con.Close();
            }

            if (adminCount == 0)
            {
                adminIDTxt.Text = "1";
            }
            else
            {

                try
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                        SqlCommand getLastID = new SqlCommand("SELECT TOP 1 adminID FROM tb_adminInformations ORDER BY adminID DESC", con);
                        getLastID.CommandType = CommandType.Text;
                        SqlDataReader reader = getLastID.ExecuteReader();

                        while (reader.Read())
                        {
                            lastID = (int)reader["adminID"];
                        }
                        int nextID = lastID + 1;
                        adminIDTxt.Text = nextID.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "dataAdapterIDGenerator");
                }
                finally
                {
                    con.Close();
                }
            }
        }

        public void clearInputs()
        {
            lastNameTxt.Text = "Last Name";
            firstNameTxt.Text = "First Name";
            male.Checked = false;
            female.Checked = false;
            ageTxt.Text = "Age";
            contactNumTxt.Text = "Contact Number";
            houseNumTxt.Text = "House No";
            streetNameTxt.Text = "Street Name";
            brgyTxt.Text = "Barangay";
            cityTxt.Text = "City";
            uNametxt.Text = "Username";
            passWordtxt.Text = "Password";
            fbUsername.Text = "Facebook Username";
            fbPassword.Text = "FB Password";

        }

        private void fbUsername_Enter(object sender, EventArgs e)
        {
            if (fbUsername.Text.Trim().Equals("Facebook Username"))
            {
                fbUsername.Text = "";
            }
        }

        private void fbUsername_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(fbUsername.Text))
            {
                fbUsername.Text = "Facebook Username";
            }
        }

        private void fbPassword_Enter(object sender, EventArgs e)
        {
            if (fbPassword.Text.Trim().Equals("FB Password"))
            {
                fbPassword.Text = "";
                fbPassword.isPassword = true;
                showBtn.Visible = false;
            }
        }

        private void fbPassword_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(fbPassword.Text))
            {
                fbPassword.Text = "FB Password";
                fbPassword.isPassword = false;
            }
        }

        private void fbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData != Keys.Back)
            {
                showBtn.Visible = true;
            }
            else
            {
                if (fbPassword.Text.Equals(""))
                {
                    showBtn.Visible = false;
                }
            }
        }

        private void hideBtn_Click(object sender, EventArgs e)
        {
            fbPassword.isPassword = true;
            showBtn.Visible = true;
            hideBtn.Visible = false;
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            fbPassword.isPassword = false;
            showBtn.Visible = false;
            hideBtn.Visible = true;
        }

        private void passWordtxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData != Keys.Back)
            {
                showBtn1.Visible = true;
            }
            else
            {
                if (passWordtxt.Text.Equals(""))
                {
                    showBtn1.Visible = false;
                }
            }
        }

        private void hideBtn1_Click(object sender, EventArgs e)
        {
            passWordtxt.isPassword = true;
            showBtn1.Visible = true;
            hideBtn1.Visible = false;
        }

        private void showBtn1_Click(object sender, EventArgs e)
        {
            passWordtxt.isPassword = false;
            showBtn1.Visible = false;
            hideBtn1.Visible = true;
        }
    }
}
