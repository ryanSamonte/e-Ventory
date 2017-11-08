using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using eVentoryLibraries;
using Mmosoft.Facebook.Sdk;

namespace projectTemp.Forms
{
    public partial class announcementUserControl : UserControl
    {
        SqlConnection con = new SqlConnection(DBConnection.connect());
        public announcementUserControl()
        {
            InitializeComponent();
            fillResult();
            getFacebookAccount();
        }
        
        void fillResult()
        {
            searchResult.DataSource = dataLib.viewAll(DBConnection.connect());
            searchResult.Columns["scheduleID"].Visible = false;
            searchResult.Columns["eventName"].HeaderText = "EVENT NAME";
            searchResult.Columns["description"].HeaderText = "DESCRIPTION";
            searchResult.Columns["dateStart"].HeaderText = "START DATE";
            searchResult.Columns["dateEnd"].HeaderText = "END DATE";
            searchResult.Columns["timeStart"].HeaderText = "START TIME";
            searchResult.Columns["timeEnd"].HeaderText = "END TIME";
            searchResult.Columns["venueName"].HeaderText = "VENUE";
            searchResult.Columns["ticketCapacity"].HeaderText = "PARTICIPANTS";
            searchResult.Columns["ticketAmount"].HeaderText = "TICKET FEE";
            searchResult.Columns["fbGroupCode"].HeaderText = "FB GROUP CODE";
        }

        private void searchResult_Click(object sender, EventArgs e)
        {
            if (searchResult.CurrentRow.Index != -1)
            {
                fbCodeLbl.Text = searchResult.CurrentRow.Cells[10].Value.ToString();
                searchResult.CurrentRow.DefaultCellStyle.BackColor = Color.FromArgb(107, 185, 240);
                searchResult.CurrentRow.DefaultCellStyle.ForeColor = Color.Black;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void postBtn_Click(object sender, EventArgs e)
        {
            if (fbCodeLbl.Text.Equals(""))
            {
                MetroFramework.MetroMessageBox.Show(this, "Kindly choose an event", "e-Ventory", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (messageTxt.Text.Equals(""))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Kindly type your announcement", "e-Ventory", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        var fb = new FacebookClient(user: userName.Text.Trim(), password: password.Text.Trim());
                        fb.PostToGroup(messageTxt.Text.Trim(), fbCodeLbl.Text.Trim());
                    }
                    catch (Exception ex)
                    {
                        MetroFramework.MetroMessageBox.Show(this, ex.Message, "e-Ventory", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Announcement successfully posted!", "e-Ventory", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                }
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            fillResult();
            getFacebookAccount();
        }

        void getFacebookAccount()
        {
            try
            {
                if(con.State == ConnectionState.Closed)
                {
                    con.Open();

                    SqlCommand getFB = new SqlCommand(@"SELECT fbUname, fbPassWord
                                                        FROM tb_adminInformations
                                                        WHERE adminID = @adminID", con);

                    getFB.Parameters.AddWithValue("@adminID", dataLib.getLoggedAdminID(DBConnection.connect()));

                    SqlDataReader reader = getFB.ExecuteReader();

                    while (reader.Read())
                    {
                        userName.Text = (string)reader["fbUname"];
                        password.Text = (string)reader["fbPassWord"];
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void searchTxt_Enter(object sender, EventArgs e)
        {
            if (searchTxt.Text.Trim().Equals("Event Name"))
            {
                searchTxt.Text = "";
            }
        }

        private void searchTxt_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(searchTxt.Text))
            {
                searchTxt.Text = "Event Name";
                fillResult();
            }
        }

        private void searchTxt_OnValueChanged(object sender, EventArgs e)
        {
            DataTable eventNameResult = new DataTable(); ;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    SqlDataAdapter resultSet = new SqlDataAdapter(@"SELECT EI.scheduleID, eventName, [description], 
                                                                    dateStart, dateEnd, timeStart, timeEnd, 
                                                                    venueName, ticketCapacity, ticketAmount, fbGroupCode
                                                                    FROM tb_EventInfo EI JOIN tb_Schedule S ON EI.scheduleID = s.scheduleID
                                                                    WHERE eventName LIKE '%" + searchTxt.Text + "%' AND isPastEvent != 1  ORDER BY 4 ASC", con);

                    resultSet.Fill(eventNameResult);

                    if(eventNameResult.Rows.Count > 0 || searchTxt.Text.Equals("Event Name"))
                    {
                        searchResult.Visible = true;
                        searchResult.DataSource = eventNameResult;
                        searchResult.Columns["scheduleID"].Visible = false;
                        searchResult.Columns["eventName"].HeaderText = "EVENT NAME";
                        searchResult.Columns["description"].HeaderText = "DESCRIPTION";
                        searchResult.Columns["dateStart"].HeaderText = "START DATE";
                        searchResult.Columns["dateEnd"].HeaderText = "END DATE";
                        searchResult.Columns["timeStart"].HeaderText = "START TIME";
                        searchResult.Columns["timeEnd"].HeaderText = "END TIME";
                        searchResult.Columns["venueName"].HeaderText = "VENUE";
                        searchResult.Columns["ticketCapacity"].HeaderText = "PARTICIPANTS";
                        searchResult.Columns["ticketAmount"].HeaderText = "TICKET FEE";
                        searchResult.Columns["fbGroupCode"].HeaderText = "FB GROUP CODE";
                        noResFoundLbl.Visible = false;
                    }
                    else
                    {
                        searchResult.Visible = false;
                        noResFoundLbl.Visible = true;
                    }
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                con.Close();
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            fbCodeLbl.Text = "";
            messageTxt.Text = "";
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            password.isPassword = false;
            showBtn.Visible = false;
            hideBtn.Visible = true;
        }

        private void password_Enter(object sender, EventArgs e)
        {
            if (password.Text.Equals("Password"))
            {
                password.Text = "";
                password.isPassword = true;
                showBtn.Visible = false;
            }
        }

        private void password_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(password.Text))
            {
                password.isPassword = false;
                password.Text = "Password";
            }
        }

        private void userName_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(userName.Text))
            {
                userName.Text = "FB Username";
            }
        }

        private void userName_Enter(object sender, EventArgs e)
        {
            if (userName.Text.Equals("FB Username"))
            {
                userName.Text = "";
            }
        }

        private void hideBtn_Click(object sender, EventArgs e)
        {
            password.isPassword = true;
            showBtn.Visible = true;
            hideBtn.Visible = false;
        }

        private void password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData != Keys.Back)
            {
                showBtn.Visible = true;
            }
            else
            {
                if (password.Text.Equals(""))
                {
                    showBtn.Visible = false;
                }
            }
        }

        private void searchResult_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            searchResult.CurrentRow.DefaultCellStyle.SelectionBackColor = Color.FromArgb(44, 62, 80);
            searchResult.CurrentRow.DefaultCellStyle.SelectionForeColor = Color.White;
        }
    }
}
