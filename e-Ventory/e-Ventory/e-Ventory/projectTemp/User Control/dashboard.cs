using System;
using System.Data;
using System.Windows.Forms;
using eVentoryLibraries;
using System.Data.SqlClient;

namespace projectTemp
{
    public partial class dashboard : UserControl
    {
        string eventName = "";
        SqlConnection con = new SqlConnection(DBConnection.connect());
        public dashboard()
        {
            InitializeComponent();
            timer1.Start();
            refreshCounts();
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            eventCountLbl.Text = dataLib.countAllEvents(DBConnection.connect()).ToString();
            adminCountLbl.Text = dataLib.countAllAdminAccounts(DBConnection.connect()).ToString();
            upcomingEvent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            this.dateLbl.Text = time.ToLongDateString();
            this.timeLbl.Text = time.ToLongTimeString();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            refreshCounts();
        }

        void refreshCounts()
        {
            eventCountLbl.Text = dataLib.countAllEvents(DBConnection.connect()).ToString();
            adminCountLbl.Text = dataLib.countAllAdminAccounts(DBConnection.connect()).ToString();
            updateStatement.updateEventStatus(DBConnection.connect());
            upcomingEvent();
        }

        void upcomingEvent()
        {
            if(dataLib.upcomingEventCount(DBConnection.connect()) <= 0)
            {
                noUpcomingEventLbl.Visible = true;
                noUpcomingEventLbl1.Visible = true;
                lbl1.Visible = false;
                lbl2.Visible = false;
                bunifuCustomLabel5.Visible = false;
                bunifuCustomLabel6.Visible = false;
                bunifuCustomLabel7.Visible = false;
                bunifuCustomLabel8.Visible = false;
                bunifuCustomLabel9.Visible = false;
                bunifuCustomLabel10.Visible = false;
                bunifuCustomLabel11.Visible = false;
            }
            else
            {
                noUpcomingEventLbl.Visible = false;
                noUpcomingEventLbl1.Visible = false;
                bunifuCustomLabel5.Visible = true;
                bunifuCustomLabel6.Visible = true;
                bunifuCustomLabel7.Visible = true;
                bunifuCustomLabel8.Visible = true;
                bunifuCustomLabel9.Visible = true;
                bunifuCustomLabel10.Visible = true;
                bunifuCustomLabel11.Visible = true;
                lbl1.Visible = true;
                lbl2.Visible = true;
                try
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                        SqlCommand getNearestEvent = new SqlCommand(@"SELECT TOP 1 eventName, dateStart, dateEnd, 
                                                                  CONVERT(varchar(15),timeStart,100) AS 'timeStart', 
                                                                  CONVERT(varchar(15),timeEnd,100) AS 'timeEnd', 
                                                                  venueName, ticketCapacity, ticketBought
                                                                  FROM tb_schedule S JOIN tb_EventInfo E ON S.scheduleID = E.scheduleID
                                                                  WHERE (DATEDIFF(DAY, GETDATE(), dateStart) IN (SELECT TOP 1 datediff(DAY, getdate(), dateStart) 
											                                                                     FROM tb_schedule S JOIN tb_EventInfo E
											                                                                     ON S.scheduleID = E.scheduleID
											                                                                     WHERE (isPastEvent != 1 AND datediff(DAY, getdate(), dateStart) >= 0) AND (CONVERT(DATETIME, CONVERT(CHAR(8), dateStart, 112)+ ' ' +CONVERT(CHAR(8), timeStart, 108)) !< GETDATE())
										                                                                         ORDER BY 1 ASC)) AND (isPastEvent != 1 AND CONVERT(DATETIME, CONVERT(CHAR(8), dateStart, 112)+ ' ' +CONVERT(CHAR(8), timeStart, 108)) !< GETDATE())
                                                                  ORDER BY (CONVERT(DATETIME, CONVERT(CHAR(8), dateStart, 112)+ ' ' +CONVERT(CHAR(8), timeStart, 108))) DESC", con);

                        SqlDataReader reader = getNearestEvent.ExecuteReader();

                        while (reader.Read())
                        {
                            eventName = (string)reader["eventName"];
                            dateStart.Text = ((DateTime)reader["dateStart"]).ToShortDateString();
                            dateEnd.Text = ((DateTime)reader["dateEnd"]).ToShortDateString();
                            timeStart.Text = ((string)reader["timeStart"]).ToString();
                            timeEnd.Text = ((string)reader["timeEnd"]).ToString();
                            venueLoc.Text = (string)reader["venueName"];
                            ticketCapacityLbl.Text = ((int)reader["ticketCapacity"]).ToString();
                            registeredCountLbl.Text = ((int)reader["ticketBought"]).ToString();
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

                eventNameLbl.Text = eventName;
                eventNameLbl1.Text = eventName;
            }
        }

        private void bunifuCustomLabel6_Click(object sender, EventArgs e)
        {

        }
    }
}
