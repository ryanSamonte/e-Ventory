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
using eVentoryLibraries;
using System.Globalization;
using System.Media;

namespace projectTemp.User_Control
{
    public partial class addEvent : UserControl
    {
        SqlConnection con = new SqlConnection(DBConnection.connect());
        public addEvent()
        {
            InitializeComponent();
            idGenerator();
            dateStart.Value = DateTime.Now;
            dateFinish.Value = DateTime.Now;
        }

        private void eventNameTxt_Enter(object sender, EventArgs e)
        {
            if (eventNameTxt.Text.Trim().Equals("Event Name"))
            {
                eventNameTxt.Text = "";
            }
        }

        private void eventNameTxt_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(eventNameTxt.Text))
            {
                eventNameTxt.Text = "Event Name";
            }
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

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string timeStart = hrStart.Text.Trim() + ":" + minStart.Text.Trim();
            string timeFinish = hrFinish.Text.Trim() + ":" + minFinish.Text.Trim();
            bool emptyFields = eventNameTxt.Text.Trim().Equals("") || eventDescTxt.Text.Trim().Equals("") || hrStart.Text.Trim().Equals("") || minStart.Text.Trim().Equals("") || hrFinish.Text.Trim().Equals("") || minFinish.Text.Trim().Equals("") || venueTxt.Text.Trim().Equals("") || capacityTxt.Text.Trim().Equals("") || priceTxt.Text.Trim().Equals("") || fbGrpIdTxt.Text.Trim().Equals("");
            if(emptyFields == true)
            {
                MetroFramework.MetroMessageBox.Show(this, "Kindly fill out all fields", "e-Ventory", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (validations.invalidTimeInput(hrStart.Text.Trim(), minStart.Text.Trim(), hrFinish.Text.Trim(), minFinish.Text.Trim()) == true)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Invalid time input", "e-Ventory", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  }
                else
                {
                    if (validations.invalidDateInput(DateTime.Parse(dateStart.Value.ToShortDateString()), DateTime.Parse(dateFinish.Value.ToShortDateString()), DateTime.Today) == true || validations.invalidDateandTimeInput(DateTime.Today, DateTime.Parse(dateStart.Value.ToShortDateString()), DateTime.ParseExact(timeStart, "HH:mm", CultureInfo.InvariantCulture), DateTime.Now.ToString("HH:mm")) == true)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Invalid date input", "e-Ventory", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if(validations.oneDayEvent(dateStart.Value.ToShortDateString(), dateFinish.Value.ToShortDateString()) == true)
                        {
                            if (validations.existingOneDayEvent(DBConnection.connect(), DateTime.Parse(dateStart.Value.ToShortDateString()), DateTime.ParseExact(timeStart, "HH:mm", CultureInfo.InvariantCulture), DateTime.ParseExact(timeFinish, "HH:mm", CultureInfo.InvariantCulture), venueTxt.Text.Trim()) >= 1)
                            {
                                MetroFramework.MetroMessageBox.Show(this, "Event already exists!", "e-Ventory", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                if (dataLib.existingEventName(DBConnection.connect(), eventNameTxt.Text.Trim()) >= 1)
                                {
                                    int eventCode = dataLib.getEventCode(DBConnection.connect(), eventNameTxt.Text.Trim());
                                    insertStatements.insertSchedule(DBConnection.connect(), DateTime.Parse(dateStart.Value.ToShortDateString()), DateTime.Parse(dateFinish.Value.ToShortDateString()), DateTime.ParseExact(timeStart, "HH:mm", CultureInfo.InvariantCulture), DateTime.ParseExact(timeFinish, "HH:mm", CultureInfo.InvariantCulture), venueTxt.Text.Trim(), eventCode);
                                    int schedID = dataLib.getSchedID(DBConnection.connect(), DateTime.Parse(dateStart.Value.ToShortDateString()), DateTime.Parse(dateFinish.Value.ToShortDateString()), DateTime.ParseExact(timeStart, "HH:mm", CultureInfo.InvariantCulture), DateTime.ParseExact(timeFinish, "HH:mm", CultureInfo.InvariantCulture), venueTxt.Text.Trim(), eventCode);
                                    insertStatements.insertEventInfo(DBConnection.connect(), eventNameTxt.Text.Trim(), eventDescTxt.Text.Trim(), schedID, false, eventCode);
                                    decimal price = 0;
                                    if (freeChkbox.Checked)
                                    {
                                        price = 0;
                                    }
                                    else
                                    {
                                        price = Convert.ToDecimal(priceTxt.Text.Trim());
                                    }
                                    updateStatement.updateSchedule(DBConnection.connect(), Convert.ToInt32(capacityTxt.Text.Trim()), fbGrpIdTxt.Text.Trim(), price, 0, schedID);
                                    insertStatements.insertSystemLog(DBConnection.connect(), "'" + eventNameTxt.Text.Trim() + "'" + " event created", dataLib.loggedAdminName(DBConnection.connect(), dataLib.getLoggedAdminID(DBConnection.connect())), dataLib.currentDateAndTime());
                                    MetroFramework.MetroMessageBox.Show(this, "Event successfully created!", "e-Ventory", MessageBoxButtons.OK, MessageBoxIcon.Question);
                                    idGenerator();
                                    clearInputs();
                                }
                                else
                                {
                                    int eventCode = Convert.ToInt32(eventCodeTxt.Text);
                                    insertStatements.insertSchedule(DBConnection.connect(), DateTime.Parse(dateStart.Value.ToShortDateString()), DateTime.Parse(dateFinish.Value.ToShortDateString()), DateTime.ParseExact(timeStart, "HH:mm", CultureInfo.InvariantCulture), DateTime.ParseExact(timeFinish, "HH:mm", CultureInfo.InvariantCulture), venueTxt.Text.Trim(), eventCode);
                                    int schedID = dataLib.getSchedID(DBConnection.connect(), DateTime.Parse(dateStart.Value.ToShortDateString()), DateTime.Parse(dateFinish.Value.ToShortDateString()), DateTime.ParseExact(timeStart, "HH:mm", CultureInfo.InvariantCulture), DateTime.ParseExact(timeFinish, "HH:mm", CultureInfo.InvariantCulture), venueTxt.Text.Trim(), eventCode);
                                    insertStatements.insertEventInfo(DBConnection.connect(), eventNameTxt.Text.Trim(), eventDescTxt.Text.Trim(), schedID, false, eventCode);
                                    decimal price = 0;
                                    if (freeChkbox.Checked)
                                    {
                                        price = 0;
                                    }
                                    else
                                    {
                                        price = Convert.ToDecimal(priceTxt.Text.Trim());
                                    }

                                    updateStatement.updateSchedule(DBConnection.connect(), Convert.ToInt32(capacityTxt.Text.Trim()), fbGrpIdTxt.Text.Trim(), price, 0, schedID);
                                    insertStatements.insertSystemLog(DBConnection.connect(), "'" + eventNameTxt.Text.Trim() + "'" + " event created", dataLib.loggedAdminName(DBConnection.connect(), dataLib.getLoggedAdminID(DBConnection.connect())), dataLib.currentDateAndTime());
                                    MetroFramework.MetroMessageBox.Show(this, "Event successfully created!", "e-Ventory", MessageBoxButtons.OK, MessageBoxIcon.Question);
                                    idGenerator();
                                    clearInputs();
                                }
                            }
                        }
                        else
                        {
                            if (validations.existingMultiDayEvent(DBConnection.connect(), DateTime.Parse(dateStart.Value.ToShortDateString()), DateTime.Parse(dateFinish.Value.ToShortDateString()), DateTime.ParseExact(timeStart, "HH:mm", CultureInfo.InvariantCulture), DateTime.ParseExact(timeFinish, "HH:mm", CultureInfo.InvariantCulture), venueTxt.Text.Trim()) >= 1)
                            {
                                MetroFramework.MetroMessageBox.Show(this, "Event already exists!", "e-Ventory", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                if (dataLib.existingEventName(DBConnection.connect(), eventNameTxt.Text.Trim()) >= 1)
                                {
                                    int eventCode = dataLib.getEventCode(DBConnection.connect(), eventNameTxt.Text.Trim());
                                    insertStatements.insertSchedule(DBConnection.connect(), DateTime.Parse(dateStart.Value.ToShortDateString()), DateTime.Parse(dateFinish.Value.ToShortDateString()), DateTime.ParseExact(timeStart, "HH:mm", CultureInfo.InvariantCulture), DateTime.ParseExact(timeFinish, "HH:mm", CultureInfo.InvariantCulture), venueTxt.Text.Trim(), eventCode);
                                    int schedID = dataLib.getSchedID(DBConnection.connect(), DateTime.Parse(dateStart.Value.ToShortDateString()), DateTime.Parse(dateFinish.Value.ToShortDateString()), DateTime.ParseExact(timeStart, "HH:mm", CultureInfo.InvariantCulture), DateTime.ParseExact(timeFinish, "HH:mm", CultureInfo.InvariantCulture), venueTxt.Text.Trim(), eventCode);
                                    insertStatements.insertEventInfo(DBConnection.connect(), eventNameTxt.Text.Trim(), eventDescTxt.Text.Trim(), schedID, false, eventCode);
                                    decimal price = 0;
                                    if (freeChkbox.Checked)
                                    {
                                        price = 0;
                                    }
                                    else
                                    {
                                        price = Convert.ToDecimal(priceTxt.Text.Trim());
                                    }
                                    updateStatement.updateSchedule(DBConnection.connect(), Convert.ToInt32(capacityTxt.Text.Trim()), fbGrpIdTxt.Text.Trim(), price, 0, schedID);
                                    insertStatements.insertSystemLog(DBConnection.connect(), "'" + eventNameTxt.Text.Trim() + "'" + " event created", dataLib.loggedAdminName(DBConnection.connect(), dataLib.getLoggedAdminID(DBConnection.connect())), dataLib.currentDateAndTime());
                                    MetroFramework.MetroMessageBox.Show(this, "Event successfully created!", "e-Ventory", MessageBoxButtons.OK, MessageBoxIcon.Question);
                                    idGenerator();
                                    clearInputs();
                                }
                                else
                                {
                                    int eventCode = Convert.ToInt32(eventCodeTxt.Text);
                                    insertStatements.insertSchedule(DBConnection.connect(), DateTime.Parse(dateStart.Value.ToShortDateString()), DateTime.Parse(dateFinish.Value.ToShortDateString()), DateTime.ParseExact(timeStart, "HH:mm", CultureInfo.InvariantCulture), DateTime.ParseExact(timeFinish, "HH:mm", CultureInfo.InvariantCulture), venueTxt.Text.Trim(), eventCode);
                                    int schedID = dataLib.getSchedID(DBConnection.connect(), DateTime.Parse(dateStart.Value.ToShortDateString()), DateTime.Parse(dateFinish.Value.ToShortDateString()), DateTime.ParseExact(timeStart, "HH:mm", CultureInfo.InvariantCulture), DateTime.ParseExact(timeFinish, "HH:mm", CultureInfo.InvariantCulture), venueTxt.Text.Trim(), eventCode);
                                    insertStatements.insertEventInfo(DBConnection.connect(), eventNameTxt.Text.Trim(), eventDescTxt.Text.Trim(), schedID, false, eventCode);
                                    decimal price = 0;
                                    if (freeChkbox.Checked)
                                    {
                                        price = 0;
                                    }
                                    else
                                    {
                                        price = Convert.ToDecimal(priceTxt.Text.Trim());
                                    }

                                    updateStatement.updateSchedule(DBConnection.connect(), Convert.ToInt32(capacityTxt.Text.Trim()), fbGrpIdTxt.Text.Trim(), price, 0, schedID);
                                    insertStatements.insertSystemLog(DBConnection.connect(), "'" + eventNameTxt.Text.Trim() + "'" + " event created", dataLib.loggedAdminName(DBConnection.connect(), dataLib.getLoggedAdminID(DBConnection.connect())), dataLib.currentDateAndTime());
                                    MetroFramework.MetroMessageBox.Show(this, "Event successfully created!", "e-Ventory", MessageBoxButtons.OK, MessageBoxIcon.Question);
                                    idGenerator();
                                    clearInputs();
                                }
                            }
                        }
                    }
               }
          }
     }


        void idGenerator()
        {
            int lastID = 0;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    SqlDataAdapter dataAdapterEventCount = new SqlDataAdapter("SELECT * FROM tb_EventInfo", con);
                    dataAdapterEventCount.SelectCommand.CommandType = CommandType.Text;
                    DataTable eventCountTable = new DataTable();
                    dataAdapterEventCount.Fill(eventCountTable);
                    if (eventCountTable.Rows.Count == 0)
                    {
                        eventCodeTxt.Text = "1";
                    }
                    else
                    {

                        try
                        {
                            if (con.State == ConnectionState.Closed)
                            {
                                con.Open();
                                SqlCommand getLastID = new SqlCommand("SELECT TOP 1 eventCode FROM tb_EventInfo ORDER BY eventCode DESC", con);
                                getLastID.CommandType = CommandType.Text;
                                SqlDataReader reader = getLastID.ExecuteReader();

                                while (reader.Read())
                                {
                                    lastID = (int)reader["eventCode"];
                                }
                                int nextID = lastID + 1;
                                eventCodeTxt.Text = nextID.ToString();
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "dataAdapterSuperAdminID");
            }
            finally
            {
                con.Close();
            }
        }

        void clearInputs()
        {
            eventNameTxt.Text = "Event Name";
            eventDescTxt.Text = "";
            dateStart.Value = DateTime.Now;
            dateFinish.Value = DateTime.Now;
            hrStart.Text = "";
            hrFinish.Text = "";
            minStart.Text = "";
            minFinish.Text = "";
            venueTxt.Text = "Venue";
            capacityTxt.Text = "Capacity";
            priceTxt.Text = "Price";
            freeChkbox.Checked = false;
            fbGrpIdTxt.Text = "Facebook Group ID";
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            clearInputs();
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
    }
}
