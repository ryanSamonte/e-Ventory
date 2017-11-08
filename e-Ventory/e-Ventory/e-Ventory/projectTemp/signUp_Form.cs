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

namespace projectTemp
{
    public partial class signUp_Form : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=PEPS;Initial Catalog=e-VentoryDB;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public signUp_Form()
        {
            InitializeComponent();
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
            if (houseNumTxt.Text.Trim().Equals(houseNumTxt.Text))
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
            if (streetNameTxt.Text.Trim().Equals(streetNameTxt.Text))
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
            if (brgyTxt.Text.Trim().Equals(brgyTxt.Text))
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
            if (cityTxt.Text.Trim().Equals(cityTxt.Text))
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

        private void submitButton_Click(object sender, EventArgs e)
        {

        }
    }
}
