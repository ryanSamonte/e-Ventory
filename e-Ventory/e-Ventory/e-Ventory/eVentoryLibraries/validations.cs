using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Globalization;

namespace eVentoryLibraries
{
    public class validations
    {
        public static bool userNameExists(string username, string connection)
        {
            bool userNamedidExist = true;
            int userNamecount = 0;
            SqlConnection con = new SqlConnection(@connection);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    SqlCommand usernameCheck = new SqlCommand("SELECT COUNT(*) FROM tb_adminInformations WHERE userName = @userName", con);
                    usernameCheck.CommandType = CommandType.Text;
                    usernameCheck.Parameters.AddWithValue("@userName", username);
                    SqlDataReader reader = usernameCheck.ExecuteReader();

                    while (reader.Read())
                    {
                        userNamecount = Convert.ToInt32(reader[0].ToString());
                    }
                    if (userNamecount >= 1)
                    {
                        userNamedidExist = true;
                    }
                    else
                    {
                        userNamedidExist = false;
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

            return userNamedidExist;
        }

        public static bool invalidDateInput(DateTime datestart, DateTime datefinish, DateTime datetoday)
        {
            bool invalidDate = true;
            if(datestart < datetoday || datefinish < datetoday || datestart > datefinish)
            {
                invalidDate = true;
            }

            else
            {
                invalidDate = false;
            }
            return invalidDate;
        }

        public static bool invalidTimeInput(string hrStart, string minStart, string hrFinish, string minFinish)
        {
            bool invalidTime = true;

            if(Convert.ToInt32(hrStart) >= 24 || Convert.ToInt32(minStart) > 59 || Convert.ToInt32(hrFinish) >= 24 || Convert.ToInt32(minFinish) > 59 || Convert.ToInt32(hrStart) > Convert.ToInt32(hrFinish))
            {
                invalidTime = true;
            }
            else
            {
                invalidTime = false;
            }
            return invalidTime;
        }

        public static bool invalidDateandTimeInput(DateTime datetoday, DateTime datestart, DateTime timestart, string timenow)
        {
            bool invalidDandT = true;

            if(datetoday == datestart && timestart < DateTime.ParseExact(timenow, "HH:mm", CultureInfo.InvariantCulture))
            {
                invalidDandT = true;
            }
            else
            {
                invalidDandT = false;
            }

            return invalidDandT;
        }

        public static bool oneDayEvent(string datestart, string datefinish)
        {
            bool isOneDay = true;

            if (datestart.Equals(datefinish))
            {
                isOneDay = true;
            }
            else
            {
                isOneDay = false;
            }
            return isOneDay;
        }

        public static int existingOneDayEvent(string connection, DateTime date, DateTime timeStart, DateTime timeFinish, string venue)
        {
            SqlConnection con = new SqlConnection(@connection);
            int countExistingEvents = 0;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    SqlCommand checkEvents = new SqlCommand(@"SELECT COUNT(*) AS 'countEvents'
                                                              FROM tb_EventInfo EI JOIN tb_Schedule S 
                                                              ON EI.scheduleID = s.scheduleID
                                                              WHERE (venueName = @venueName and isPastEvent != 1)
                                                              and (((@dateStart between dateStart 
                                                              and dateEnd)) and ((((CAST(@timeStart AS time) BETWEEN timeStart 
                                                              and timeEnd) or (CAST(@timeEnd AS time) BETWEEN timeStart and timeEnd))) 
                                                              or ((timeStart BETWEEN CAST(@timeStart AS time) and CAST(@timeEnd AS time)) 
                                                              or (timeEnd  BETWEEN CAST(@timeStart AS time) and CAST(@timeEnd AS time)))))", con);
                    
                    checkEvents.Parameters.AddWithValue("@dateStart", date);
                    checkEvents.Parameters.AddWithValue("@timeStart", timeStart);
                    checkEvents.Parameters.AddWithValue("@timeEnd", timeFinish);
                    checkEvents.Parameters.AddWithValue("@venueName", venue);
                    SqlDataReader reader = checkEvents.ExecuteReader();

                    while (reader.Read())
                    {
                        countExistingEvents = (int)reader["countEvents"];
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

            return countExistingEvents;
        }

        public static int existingMultiDayEvent(string connection, DateTime dateStart, DateTime dateFinish, DateTime timeStart, DateTime timeFinish, string venue)
        {
            SqlConnection con = new SqlConnection(@connection);
            int countExistingEvents = 0;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    SqlCommand checkEvents = new SqlCommand(@"SELECT COUNT(*) AS 'countEvents'
								                              FROM tb_EventInfo EI JOIN tb_Schedule S 
								                              ON EI.scheduleID = s.scheduleID
								                              WHERE (venueName = @venueName and isPastEvent != 1)
								                              and ((((@dateStart between dateStart and dateEnd) or (@dateEnd between dateStart and dateEnd)) 
								                              and ((CAST(@timeStart AS time) BETWEEN timeStart and timeEnd) or (CAST(@timeEnd AS time) BETWEEN 
								                              timeStart and timeEnd))) or (((dateStart between @dateStart and @dateEnd) or (dateEnd between 
								                              @dateStart and @dateEnd)) and ((timeStart BETWEEN CAST(@timeStart AS time) and CAST(@timeEnd AS 
								                              time)) or (timeEnd  BETWEEN CAST(@timeStart AS time) and CAST(@timeEnd AS time)))))", con);
                    
                    checkEvents.Parameters.AddWithValue("@dateStart", dateStart);
                    checkEvents.Parameters.AddWithValue("@dateEnd", dateFinish);
                    checkEvents.Parameters.AddWithValue("@timeStart", timeStart);
                    checkEvents.Parameters.AddWithValue("@timeEnd", timeFinish);
                    checkEvents.Parameters.AddWithValue("@venueName", venue);
                    SqlDataReader reader = checkEvents.ExecuteReader();

                    while (reader.Read())
                    {
                        countExistingEvents = (int)reader["countEvents"];
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

            return countExistingEvents;
        }

        public static int existingOneDayEventUpdate(string connection, DateTime date, DateTime timeStart, DateTime timeFinish, string venue, int schedid)
        {
            SqlConnection con = new SqlConnection(@connection);
            int countExistingEvents = 0;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    SqlCommand checkEvents = new SqlCommand(@"SELECT COUNT(*) AS 'countEvents'
                                                              FROM tb_EventInfo EI JOIN tb_Schedule S 
                                                              ON EI.scheduleID = s.scheduleID
                                                              WHERE ((isPastEvent != 1 and venueName = @venueName) and (EI.scheduleID != @scheduleID))
                                                              and (((@dateStart between dateStart 
                                                              and dateEnd)) and ((((CAST(@timeStart AS time) BETWEEN timeStart 
                                                              and timeEnd) or (CAST(@timeEnd AS time) BETWEEN timeStart and timeEnd))) 
                                                              or ((timeStart BETWEEN CAST(@timeStart AS time) and CAST(@timeEnd AS time)) 
                                                              or (timeEnd  BETWEEN CAST(@timeStart AS time) and CAST(@timeEnd AS time)))))", con);

                    checkEvents.Parameters.AddWithValue("@dateStart", date);
                    checkEvents.Parameters.AddWithValue("@timeStart", timeStart);
                    checkEvents.Parameters.AddWithValue("@timeEnd", timeFinish);
                    checkEvents.Parameters.AddWithValue("@venueName", venue);
                    checkEvents.Parameters.AddWithValue("@scheduleID", schedid);
                    SqlDataReader reader = checkEvents.ExecuteReader();

                    while (reader.Read())
                    {
                        countExistingEvents = (int)reader["countEvents"];
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

            return countExistingEvents;
        }

        public static int existingMultiDayEventUpdate(string connection, DateTime dateStart, DateTime dateFinish, DateTime timeStart, DateTime timeFinish, string venue, int schedid)
        {
            SqlConnection con = new SqlConnection(@connection);
            int countExistingEvents = 0;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    SqlCommand checkEvents = new SqlCommand(@"SELECT COUNT(*) AS 'countEvents'
                                                              FROM tb_Schedule
                                                              WHERE ((isPastEvent != 1 and venueName = @venueName) and (EI.scheduleID != @scheduleID))
                                                              and ((((@dateStart between dateStart and dateEnd) or (@dateEnd between dateStart and dateEnd)) 
								                              and ((CAST(@timeStart AS time) BETWEEN timeStart and timeEnd) or (CAST(@timeEnd AS time) BETWEEN 
								                              timeStart and timeEnd))) or (((dateStart between @dateStart and @dateEnd) or (dateEnd between 
								                              @dateStart and @dateEnd)) and ((timeStart BETWEEN CAST(@timeStart AS time) and CAST(@timeEnd AS 
								                              time)) or (timeEnd  BETWEEN CAST(@timeStart AS time) and CAST(@timeEnd AS time)))))", con);

                    checkEvents.Parameters.AddWithValue("@dateStart", dateStart);
                    checkEvents.Parameters.AddWithValue("@dateEnd", dateFinish);
                    checkEvents.Parameters.AddWithValue("@timeStart", timeStart);
                    checkEvents.Parameters.AddWithValue("@timeEnd", timeFinish);
                    checkEvents.Parameters.AddWithValue("@venueName", venue);
                    checkEvents.Parameters.AddWithValue("@scheduleID", schedid);
                    SqlDataReader reader = checkEvents.ExecuteReader();

                    while (reader.Read())
                    {
                        countExistingEvents = (int)reader["countEvents"];
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

            return countExistingEvents;
        }

        public static bool isStarting(string connection, int schedID)
        {
            SqlConnection con = new SqlConnection(connection);
            int count = 0;
            bool isStarting = true;

            try
            {
                if(con.State == ConnectionState.Closed)
                {
                    con.Open();
                    SqlCommand startingCount = new SqlCommand(@"SELECT COUNT(*) AS 'countEvent'
                                                                FROM tb_schedule S JOIN tb_EventInfo E ON S.scheduleID = E.scheduleID
                                                                WHERE S.scheduleID = @scheduleID AND (SELECT CONVERT(DATETIME, CONVERT(CHAR(8), dateStart, 112)+ ' ' +CONVERT(CHAR(8), timeStart, 108))
							                                                                          FROM tb_schedule S JOIN tb_EventInfo E ON S.scheduleID = E.scheduleID
							                                                                          WHERE S.scheduleID = @scheduleID) < GETDATE();", con);

                    startingCount.Parameters.AddWithValue("@scheduleID", schedID);

                    SqlDataReader reader = startingCount.ExecuteReader();

                    while (reader.Read())
                    {
                        count = (int)reader["countEvent"];
                    }

                    if(count >= 1)
                    {
                        isStarting = true;
                    }
                    else
                    {
                        isStarting = false;
                    }
                }
            }
            catch(Exception ex)
            {

            }
            finally
            {
                con.Close();
            }

            return isStarting;
        }
    }
}
