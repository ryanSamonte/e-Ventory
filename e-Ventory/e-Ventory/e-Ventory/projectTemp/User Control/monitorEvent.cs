using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eVentoryLibraries;
using System.Data.SqlClient;
using System.Globalization;
using System.Media;

namespace projectTemp.User_Control
{
    public partial class monitorEvent : UserControl
    {
        SqlConnection con = new SqlConnection(DBConnection.connect());
        public int schedID = 0;
        public monitorEvent()
        {
            InitializeComponent();
        }

        private void monitorEvent_Load(object sender, EventArgs e)
        {
            fillResult();
            freeChkbox.Checked = false;
            dateStart.Value = DateTime.Now;
            dateEnd.Value = DateTime.Now;
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

        private void updateBtn_Click(object sender, EventArgs e)
        {
            string timeStart = hrStart.Text.Trim() + ":" + minStart.Text.Trim();
            string timeFinish = hrEnd.Text.Trim() + ":" + minEnd.Text.Trim();
            bool emptyFields = eventNameTxt.Text.Trim().Equals("") || descTxt.Text.Trim().Equals("") || hrStart.Text.Trim().Equals("") || minStart.Text.Trim().Equals("") || hrEnd.Text.Trim().Equals("") || minEnd.Text.Trim().Equals("") || venueTxt.Text.Trim().Equals("") || capacityTxt.Text.Trim().Equals("") || priceTxt.Text.Trim().Equals("") || fbGrpIdTxt.Text.Trim().Equals("");
            if (emptyFields == true)
            {
                MetroFramework.MetroMessageBox.Show(this, "Kindly choose the event info you want to update", "e-Ventory", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (validations.invalidTimeInput(hrStart.Text.Trim(), minStart.Text.Trim(), hrEnd.Text.Trim(), minEnd.Text.Trim()) == true)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Invalid time input", "e-Ventory", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (validations.invalidDateInput(DateTime.Parse(dateStart.Value.ToShortDateString()), DateTime.Parse(dateEnd.Value.ToShortDateString()), DateTime.Today) == true || validations.invalidDateandTimeInput(DateTime.Today, DateTime.Parse(dateStart.Value.ToShortDateString()), DateTime.ParseExact(timeStart, "HH:mm", CultureInfo.InvariantCulture), DateTime.Now.ToString("HH:mm")) == true)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Invalid date input", "e-Ventory", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (validations.existingOneDayEventUpdate(DBConnection.connect(), DateTime.Parse(dateStart.Value.ToShortDateString()), DateTime.ParseExact(timeStart, "HH:mm", CultureInfo.InvariantCulture), DateTime.ParseExact(timeFinish, "HH:mm", CultureInfo.InvariantCulture), venueTxt.Text.Trim(), Convert.ToInt32(schedIDTxt.Text)) >= 1 || validations.existingMultiDayEventUpdate(DBConnection.connect(), DateTime.Parse(dateStart.Value.ToShortDateString()), DateTime.Parse(dateEnd.Value.ToShortDateString()), DateTime.ParseExact(timeStart, "HH:mm", CultureInfo.InvariantCulture), DateTime.ParseExact(timeFinish, "HH:mm", CultureInfo.InvariantCulture), venueTxt.Text.Trim(), Convert.ToInt32(schedIDTxt.Text)) >= 1)
                        {
                            MetroFramework.MetroMessageBox.Show(this, "Event already exists!", "e-Ventory", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            updateStatement.updateEventInfo(DBConnection.connect(),descTxt.Text.Trim(), Convert.ToInt32(schedIDTxt.Text));
                            decimal price = 0;
                            if (freeChkbox.Checked)
                            {
                                price = 0;
                            }
                            else
                            {
                                price = Convert.ToDecimal(priceTxt.Text.Trim());
                            }
                            updateStatement.updateSchedule(DBConnection.connect(), DateTime.Parse(dateStart.Value.ToShortDateString()), DateTime.Parse(dateEnd.Value.ToShortDateString()), DateTime.ParseExact(timeStart, "HH:mm", CultureInfo.InvariantCulture), DateTime.ParseExact(timeFinish, "HH:mm", CultureInfo.InvariantCulture), venueTxt.Text.Trim(), Convert.ToInt32(capacityTxt.Text.Trim()), fbGrpIdTxt.Text.Trim(), price, Convert.ToInt32(schedIDTxt.Text));
                            insertStatements.insertSystemLog(DBConnection.connect(), "'" + eventNameTxt.Text.Trim() + "'" + " event updated", dataLib.loggedAdminName(DBConnection.connect(), dataLib.getLoggedAdminID(DBConnection.connect())), dataLib.currentDateAndTime());
                            MetroFramework.MetroMessageBox.Show(this, "Event successfully updated!", "e-Ventory", MessageBoxButtons.OK, MessageBoxIcon.Question);
                            fillResult();
                            clearInputs();
                        }
                    }
                }
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (schedIDTxt.Text.Equals(""))
            {
                MetroFramework.MetroMessageBox.Show(this, "Kindly choose the event info you want to delete", "e-Ventory", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                if(MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to delete "+"'"+eventNameTxt.Text.Trim()+"' informations?", "e-Ventory", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (((deleteStatement.deleteEventInfo(DBConnection.connect(), schedIDTxt.Text) == true) && (deleteStatement.deleteSchedule(DBConnection.connect(), schedIDTxt.Text) == true)) || ((deleteStatement.deleteParticipant(DBConnection.connect(), schedIDTxt.Text) == true) || (deleteStatement.deleteTicket(DBConnection.connect(), schedIDTxt.Text)) == true))
                    {
                        insertStatements.insertSystemLog(DBConnection.connect(), "'" + eventNameTxt.Text.Trim() + "'" + " event info deleted", dataLib.loggedAdminName(DBConnection.connect(), dataLib.getLoggedAdminID(DBConnection.connect())), dataLib.currentDateAndTime());
                        MetroFramework.MetroMessageBox.Show(this, "Event successfully deleted!", "e-Ventory", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        fillResult();
                        clearInputs();
                    }
                }
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
                                                                    WHERE eventName LIKE '%" + searchTxt.Text+ "%' AND isPastEvent != 1  ORDER BY 4 ASC", con);
                    
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

        private void venueTxt_Enter(object sender, EventArgs e)
        {
            if (venueTxt.Text.Trim().Equals("Venue"))
            {
                venueTxt.Text = "";
            }
        }

        private void venueTxt_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(venueTxt.Text))
            {
                venueTxt.Text = "Venue";
            }
        }

        private void capacityTxt_Enter(object sender, EventArgs e)
        {
            if (capacityTxt.Text.Trim().Equals("Capacity"))
            {
                capacityTxt.Text = "";
            }
        }

        private void capacityTxt_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(capacityTxt.Text))
            {
                capacityTxt.Text = "Capacity";
            }
        }

        private void priceTxt_Enter(object sender, EventArgs e)
        {
            if (priceTxt.Text.Trim().Equals("Price"))
            {
                priceTxt.Text = "";
            }
        }

        private void priceTxt_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(priceTxt.Text))
            {
                priceTxt.Text = "Price";
            }
        }

        private void fbGrpIdTxt_Enter(object sender, EventArgs e)
        {
            if (fbGrpIdTxt.Text.Trim().Equals("Facebook Group ID"))
            {
                fbGrpIdTxt.Text = "";
            }
        }

        private void fbGrpIdTxt_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(fbGrpIdTxt.Text))
            {
                fbGrpIdTxt.Text = "Facebook Group ID";
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            fillResult();
        }

        void clearInputs()
        {
            schedIDTxt.Text = "";
            eventNameTxt.Text = "";
            descTxt.Text = "";
            dateStart.Value = DateTime.Now;
            dateEnd.Value = DateTime.Now;
            hrStart.Text = "";
            hrEnd.Text = "";
            minStart.Text = "";
            minEnd.Text = "";
            venueTxt.Text = "Venue";
            capacityTxt.Text = "Capacity";
            priceTxt.Text = "Price";
            freeChkbox.Checked = false;
            fbGrpIdTxt.Text = "Facebook Group ID";
        }

        private void endEventBtn_Click(object sender, EventArgs e)
        {
            if (schedIDTxt.Text.Equals(""))
            {
                MetroFramework.MetroMessageBox.Show(this, "Kindly choose the event you want to end", "e-Ventory", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                if(validations.isStarting(DBConnection.connect(), Convert.ToInt32(schedIDTxt.Text)) == false)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Event not starting yet", "e-Ventory", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to end " + "'" + eventNameTxt.Text.Trim() + "' ?", "e-Ventory", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        updateStatement.updateEventStatus(DBConnection.connect(), Convert.ToInt32(schedIDTxt.Text));
                        insertStatements.insertSystemLog(DBConnection.connect(), "'" + eventNameTxt.Text.Trim() + "'" + " event ended", dataLib.loggedAdminName(DBConnection.connect(), dataLib.getLoggedAdminID(DBConnection.connect())), dataLib.currentDateAndTime());
                        deleteStatement.deleteParticipant(DBConnection.connect(), schedIDTxt.Text);
                        MetroFramework.MetroMessageBox.Show(this, "Event successfully ended!", "e-Ventory", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        fillResult();
                        clearInputs();
                    }
                }
                
            }
        }

        private void priceTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char gchar = e.KeyChar;


            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {

                if (gchar.Equals('.'))
                {

                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                    SystemSounds.Beep.Play();
                }
            }
        }

        private void capacityTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) == true || Char.IsSymbol(e.KeyChar) == true || Char.IsPunctuation(e.KeyChar) == true)
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
            }
            else
            {
                e.Handled = false;
            }
        }

        private void hrStart_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) == true || Char.IsSymbol(e.KeyChar) == true || Char.IsPunctuation(e.KeyChar) == true)
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
            }
            else
            {
                e.Handled = false;
            }
        }

        private void minStart_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) == true || Char.IsSymbol(e.KeyChar) == true || Char.IsPunctuation(e.KeyChar) == true)
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
            }
            else
            {
                e.Handled = false;
            }
        }

        private void hrEnd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) == true || Char.IsSymbol(e.KeyChar) == true || Char.IsPunctuation(e.KeyChar) == true)
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
            }
            else
            {
                e.Handled = false;
            }
        }

        private void minEnd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) == true || Char.IsSymbol(e.KeyChar) == true || Char.IsPunctuation(e.KeyChar) == true)
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
            }
            else
            {
                e.Handled = false;
            }
        }

        private void searchResult_Click(object sender, EventArgs e)
        {
            if (searchResult.CurrentRow.Index != -1)
            {
                schedID = Convert.ToInt32(searchResult.CurrentRow.Cells[0].Value);
                searchResult.CurrentRow.DefaultCellStyle.BackColor = Color.FromArgb(107, 185, 240);
                searchResult.CurrentRow.DefaultCellStyle.ForeColor = Color.Black;
                schedIDTxt.Text = schedID.ToString();
                try
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                        SqlCommand retrieveAllInfos = new SqlCommand(@"SELECT eventName, [description], dateStart, dateEnd, 
                                                                   LEFT(timeStart, 2) AS 'hrTimestart', SUBSTRING(CAST(
                                                                   timeStart AS varchar(15)), 4,2) AS 'minTimestart',LEFT
                                                                   (timeEnd, 2) AS 'hrTimeend', SUBSTRING(CAST(timeEnd AS 
                                                                   varchar(15)), 4,2) AS 'minTimeend', venueName, 
                                                                   ticketCapacity, ticketAmount, fbGroupCode 
                                                                   FROM tb_EventInfo EI JOIN tb_Schedule S ON EI.scheduleID = s.scheduleID
                                                                   WHERE EI.scheduleID = @scheduleID", con);

                        retrieveAllInfos.Parameters.AddWithValue("@scheduleID", schedID);

                        SqlDataReader reader = retrieveAllInfos.ExecuteReader();

                        while (reader.Read())
                        {
                            eventNameTxt.Text = (string)reader["eventName"];
                            descTxt.Text = (string)reader["description"];
                            dateStart.Value = (DateTime)reader["dateStart"];
                            dateEnd.Value = (DateTime)reader["dateEnd"];
                            hrStart.Text = ((string)reader["hrTimestart"]);
                            minStart.Text = ((string)reader["minTimestart"]);
                            hrEnd.Text = ((string)reader["hrTimeend"]);
                            minEnd.Text = ((string)reader["minTimeend"]);
                            venueTxt.Text = (string)reader["venueName"];
                            capacityTxt.Text = ((int)reader["ticketCapacity"]).ToString();
                            priceTxt.Text = ((Decimal)reader["ticketAmount"]).ToString();
                            if (Convert.ToDouble(priceTxt.Text) == 0.00)
                            {
                                freeChkbox.Checked = true;
                            }
                            else
                            {
                                freeChkbox.Checked = false;
                            }
                            fbGrpIdTxt.Text = (string)reader["fbGroupCode"];

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
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
