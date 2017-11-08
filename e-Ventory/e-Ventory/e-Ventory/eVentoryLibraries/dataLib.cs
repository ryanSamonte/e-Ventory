using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace eVentoryLibraries
{
    public class dataLib
    {
        public static bool logInVerification(string username, string password, string connection)
        {
            bool logInState = true;
            SqlConnection con = new SqlConnection(connection);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    SqlDataAdapter loginVerification = new SqlDataAdapter("SELECT * FROM tb_adminInformations WHERE userName = @userName AND passWord = @passWord", con);
                    loginVerification.SelectCommand.CommandType = CommandType.Text;
                    loginVerification.SelectCommand.Parameters.AddWithValue("@userName", username);
                    loginVerification.SelectCommand.Parameters.AddWithValue("@passWord", password);
                    DataTable tableAccounts = new DataTable();
                    loginVerification.Fill(tableAccounts);

                    if (tableAccounts.Rows.Count == 1)
                    {
                        logInState = true;
                    }
                    else
                    {
                        logInState = false;
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

            return logInState;
        }

        public static int countAllAdminAccounts(string connection)
        {
            int adminAccountctr = 0;
            SqlConnection con = new SqlConnection(connection);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    SqlCommand AdminCount = new SqlCommand("SELECT COUNT(*) AS 'AdminCount' FROM tb_adminInformations", con);
                    AdminCount.CommandType = CommandType.Text;
                    SqlDataReader reader = AdminCount.ExecuteReader();

                    while (reader.Read())
                    {
                        adminAccountctr = Convert.ToInt32(reader["AdminCount"].ToString());
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

            return adminAccountctr;
        }

        public static DateTime currentDateAndTime()
        {
            return DateTime.Now;
        }

        public static DataTable retrieveSystemLogs(string connection)
        {
            SqlConnection con = new SqlConnection(connection);
            DataTable logsTable = new DataTable();
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    SqlDataAdapter sysLogs = new SqlDataAdapter("SELECT * FROM tb_systemLogs", con);
                    sysLogs.SelectCommand.CommandType = CommandType.Text;
                    sysLogs.Fill(logsTable);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {

            }
            return logsTable;
        }

        public static string getLoggedID(string connection, string username)
        {
            SqlConnection con = new SqlConnection(connection);
            string loggedID = "";
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    SqlCommand getID = new SqlCommand("SELECT adminID FROM tb_adminInformations WHERE userName = @userName", con);
                    getID.CommandType = CommandType.Text;
                    getID.Parameters.AddWithValue("@userName", username);
                    SqlDataReader reader = getID.ExecuteReader();

                    while (reader.Read())
                    {
                        loggedID = reader[0].ToString();
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

            return loggedID;
        }

        public static int existingEventName(string connection, string eventname)
        {
            int count = 0;
            SqlConnection con = new SqlConnection(connection);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    SqlCommand checkEventName = new SqlCommand(@"SELECT COUNT(*) AS 'eventNameCount' 
                                                                 FROM tb_EventInfo 
                                                                 WHERE eventName = @eventName
                                                                 AND isPastEvent != 1", con);
                    checkEventName.Parameters.AddWithValue("@eventName", eventname);
                    SqlDataReader reader = checkEventName.ExecuteReader();

                    while (reader.Read())
                    {
                        count = (int)reader["eventNameCount"];
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
            return count;
        }

        public static int getEventCode(string connection, string eventname)
        {
            SqlConnection con = new SqlConnection(connection);
            int eventCode = 0;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    SqlCommand getEvCode = new SqlCommand(@"SELECT eventCode FROM tb_EventInfo WHERE eventName = @eventName", con);
                    getEvCode.Parameters.AddWithValue("@eventName", eventname);

                    SqlDataReader reader = getEvCode.ExecuteReader();

                    while (reader.Read())
                    {
                        eventCode = (int)reader["eventCode"];
                    }
                }
            }
            catch
            {

            }
            finally
            {
                con.Close();
            }
            return eventCode;
        }

        public static int getSchedID(string connection, DateTime dateStart, DateTime dateEnd, DateTime timeStart, DateTime timeEnd, string venue, int eventCode)
        {
            SqlConnection con = new SqlConnection(connection);
            int schedID = 0;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    SqlCommand findSchedID = new SqlCommand(@"SELECT scheduleID
                                                              FROM tb_Schedule
                                                              WHERE dateStart = @dateStart AND
                                                                    dateEnd = @dateEnd AND
                                                                    timeStart = CAST (@timeStart AS time) AND
                                                                    timeEnd = CAST (@timeEnd AS time) AND
                                                                    venueName = @venueName AND
                                                                    eventID = @eventID", con);

                    findSchedID.Parameters.AddWithValue("@dateStart", dateStart);
                    findSchedID.Parameters.AddWithValue("@dateEnd", dateEnd);
                    findSchedID.Parameters.AddWithValue("@timeStart", timeStart);
                    findSchedID.Parameters.AddWithValue("@timeEnd", timeEnd);
                    findSchedID.Parameters.AddWithValue("@venueName", venue);
                    findSchedID.Parameters.AddWithValue("@eventID", eventCode);

                    SqlDataReader reader = findSchedID.ExecuteReader();

                    while (reader.Read())
                    {
                        schedID = (int)reader["scheduleID"];
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

            return schedID;
        }

        public static int getLoggedAdminID(string connection)
        {
            SqlConnection con = new SqlConnection(connection);
            int id = 0;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    SqlCommand getAdminID = new SqlCommand(@"SELECT adminID FROM tb_loggedAdmin", con);

                    SqlDataReader reader = getAdminID.ExecuteReader();

                    while (reader.Read())
                    {
                        id = (int)reader["adminID"];
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

            return id;
        }

        public static string loggedAdminName(string connection, int adminid)
        {
            SqlConnection con = new SqlConnection(connection);
            string lastName = "";
            string firstName = "";
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    SqlCommand getName = new SqlCommand(@"SELECT lastName, firstName 
                                                          FROM tb_adminInformations
                                                          WHERE adminID = @adminID", con);

                    getName.Parameters.AddWithValue("@adminID", adminid);

                    SqlDataReader reader = getName.ExecuteReader();

                    while (reader.Read())
                    {
                        lastName = (string)reader["lastName"];
                        firstName = (string)reader["firstName"];
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

            return firstName + " " + lastName;
        }

        public static DataTable viewAll(string connection)
        {
            SqlConnection con = new SqlConnection(connection);
            DataTable allEvents = new DataTable();
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    SqlDataAdapter viewAllEvents = new SqlDataAdapter(@"SELECT EI.scheduleID, eventName, [description], 
                                                                        dateStart, dateEnd, timeStart, timeEnd, 
                                                                        venueName, ticketCapacity, ticketAmount, fbGroupCode 
                                                                        FROM tb_EventInfo EI JOIN tb_Schedule S 
                                                                        ON EI.scheduleID = s.scheduleID
                                                                        WHERE isPastEvent != 1
                                                                        ORDER BY CONVERT(CHAR(8), dateStart, 112)+ ' ' +CONVERT(CHAR(8), timeStart, 108) ASC", con);
                    viewAllEvents.Fill(allEvents);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                con.Close();
            }

            return allEvents;
        }

        public static int countAllEvents(string connection)
        {
            SqlConnection con = new SqlConnection(connection);
            int eventCount = 0;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();

                    SqlCommand countallEvents = new SqlCommand(@"SELECT COUNT(*) AS 'eventCount'
                                                                 FROM tb_EventInfo EI JOIN tb_Schedule S ON EI.scheduleID = s.scheduleID
                                                                 WHERE isPastEvent != 1", con);

                    SqlDataReader reader = countallEvents.ExecuteReader();

                    while (reader.Read())
                    {
                        eventCount = (int)reader["eventCount"];
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

            return eventCount;
        }

        public static bool isQRCodeExists(string connection, string detectedCode)
        {
            SqlConnection con = new SqlConnection(connection);

            bool isExisting = true;
            int count = 0;

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();

                    SqlCommand qrCodeCount = new SqlCommand(@"SELECT COUNT(*) AS 'qrCodeCount'
                                                              FROM tb_Ticket
                                                              WHERE qrCode = @qrCode", con);

                    qrCodeCount.Parameters.AddWithValue("@qrCode", detectedCode);

                    SqlDataReader reader = qrCodeCount.ExecuteReader();

                    while (reader.Read())
                    {
                        count = (int)reader["qrCodeCount"];
                    }

                    if (count >= 1)
                    {
                        isExisting = true;
                    }
                    else
                    {
                        isExisting = false;
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

            return isExisting;
        }

        public static bool isAlreadyPaid(string connection, string detectedCode)
        {
            SqlConnection con = new SqlConnection(connection);

            bool isPaid = true;
            int count = 0;

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();

                    SqlCommand paidCount = new SqlCommand(@"SELECT COUNT(*) AS 'qrCodeCount'
                                                              FROM tb_Ticket
                                                              WHERE qrCode = @qrCode AND paymentStatus = @paymentStatus", con);

                    paidCount.Parameters.AddWithValue("@qrCode", detectedCode);
                    paidCount.Parameters.AddWithValue("@paymentStatus", "PAID");

                    SqlDataReader reader = paidCount.ExecuteReader();

                    while (reader.Read())
                    {
                        count = (int)reader["qrCodeCount"];
                    }

                    if (count >= 1)
                    {
                        isPaid = true;
                    }
                    else
                    {
                        isPaid = false;
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

            return isPaid;
        }

        public static bool isPastEvent(string connection, int schedID)
        {
            SqlConnection con = new SqlConnection(connection);

            bool isPastAlready = true;

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();

                    SqlCommand isPast = new SqlCommand(@"SELECT isPastEvent
                                                         FROM tb_EventInfo
                                                         WHERE scheduleID = @scheduleID", con);

                    isPast.Parameters.AddWithValue("@scheduleID", schedID);

                    SqlDataReader reader = isPast.ExecuteReader();

                    while (reader.Read())
                    {
                        isPastAlready = (bool)reader["isPastEvent"];
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

            return isPastAlready;
        }

        public static bool isFullEvent(string connection, int scheduleID)
        {
            SqlConnection con = new SqlConnection(connection);

            bool isFull = true;
            int capacity = 0, bought = 0;

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();

                    SqlCommand getTicketCapandCount = new SqlCommand(@"SELECT ticketCapacity, ticketBought
                                                                       FROM tb_Schedule
                                                                       WHERE scheduleID = @scheduleID", con);

                    getTicketCapandCount.Parameters.AddWithValue("@scheduleID", scheduleID);

                    SqlDataReader reader = getTicketCapandCount.ExecuteReader();

                    while (reader.Read())
                    {
                        capacity = (int)reader["ticketCapacity"];
                        bought = (int)reader["ticketBought"];
                    }

                    if (capacity == bought)
                    {
                        isFull = true;
                    }
                    else
                    {
                        isFull = false;
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

            return isFull;
        }

        public static int participantID(string connection, string detectedCode)
        {
            SqlConnection con = new SqlConnection(connection);

            int id = 0;

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();

                    SqlCommand partID = new SqlCommand(@"SELECT participantID
                                                              FROM tb_Ticket
                                                              WHERE qrCode = @qrCode", con);

                    partID.Parameters.AddWithValue("@qrCode", detectedCode);

                    SqlDataReader reader = partID.ExecuteReader();

                    while (reader.Read())
                    {
                        id = (int)reader["participantID"];
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

            return id;
        }

        public static string participantName(string connection, int participantID)
        {
            SqlConnection con = new SqlConnection(connection);

            string lastname = "";
            string firstname = "";

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();

                    SqlCommand partName = new SqlCommand(@"SELECT lastName, firstName
                                                              FROM tb_participantInformations
                                                              WHERE participantID = @participantID", con);

                    partName.Parameters.AddWithValue("@participantID", participantID);

                    SqlDataReader reader = partName.ExecuteReader();

                    while (reader.Read())
                    {
                        lastname = (string)reader["lastName"];
                        firstname = (string)reader["firstName"];
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

            return firstname + " " + lastname;
        }

        public static int age(string connection, int participantID)
        {
            SqlConnection con = new SqlConnection(connection);

            int age = 0;


            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();

                    SqlCommand partName = new SqlCommand(@"SELECT age
                                                              FROM tb_participantInformations
                                                              WHERE participantID = @participantID", con);

                    partName.Parameters.AddWithValue("@participantID", participantID);

                    SqlDataReader reader = partName.ExecuteReader();

                    while (reader.Read())
                    {
                        age = (int)reader["age"];
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

            return age;
        }

        public static string contactNum(string connection, int participantID)
        {
            SqlConnection con = new SqlConnection(connection);

            string contactNum = "";

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();

                    SqlCommand partName = new SqlCommand(@"SELECT contactNum
                                                              FROM tb_participantInformations
                                                              WHERE participantID = @participantID", con);

                    partName.Parameters.AddWithValue("@participantID", participantID);

                    SqlDataReader reader = partName.ExecuteReader();

                    while (reader.Read())
                    {
                        contactNum = (string)reader["contactNum"];
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

            return contactNum;
        }

        public static int schedIDFromQR(string connection, string detectedCode)
        {
            SqlConnection con = new SqlConnection(connection);

            int schedID = 0;

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();

                    SqlCommand getschedID = new SqlCommand(@"SELECT schedID
                                                              FROM tb_Ticket
                                                              WHERE qrCode = @qrCode", con);

                    getschedID.Parameters.AddWithValue("@qrCode", detectedCode);

                    SqlDataReader reader = getschedID.ExecuteReader();

                    while (reader.Read())
                    {
                        schedID = (int)reader["schedID"];
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

            return schedID;
        }

        public static string eventName(string connection, int schedid)
        {
            SqlConnection con = new SqlConnection(connection);

            string eventName = "";

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();

                    SqlCommand eventNamecmd = new SqlCommand(@"SELECT eventName
                                                              FROM tb_EventInfo
                                                              WHERE scheduleID = @scheduleID", con);

                    eventNamecmd.Parameters.AddWithValue("@scheduleID", schedid);

                    SqlDataReader reader = eventNamecmd.ExecuteReader();

                    while (reader.Read())
                    {
                        eventName = (string)reader["eventName"];
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

            return eventName;
        }

        public static string dateStart(string connection, int schedid)
        {
            SqlConnection con = new SqlConnection(connection);

            string dateStart = "";

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();

                    SqlCommand dateStartcmd = new SqlCommand(@"SELECT FORMAT(dateStart, 'MMMM dd, yyyy') AS 'dateStart'
                                                              FROM tb_Schedule
                                                              WHERE scheduleID = @scheduleID", con);

                    dateStartcmd.Parameters.AddWithValue("@scheduleID", schedid);

                    SqlDataReader reader = dateStartcmd.ExecuteReader();

                    while (reader.Read())
                    {
                        dateStart = (string)reader["dateStart"];
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

            return dateStart;
        }

        public static string dateEnd(string connection, int schedid)
        {
            SqlConnection con = new SqlConnection(connection);

            string dateEnd = "";

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();

                    SqlCommand dateEndcmd = new SqlCommand(@"SELECT FORMAT(dateEnd, 'MMMM dd, yyyy') AS 'dateEnd'
                                                              FROM tb_Schedule
                                                              WHERE scheduleID = @scheduleID", con);

                    dateEndcmd.Parameters.AddWithValue("@scheduleID", schedid);

                    SqlDataReader reader = dateEndcmd.ExecuteReader();

                    while (reader.Read())
                    {
                        dateEnd = (string)reader["dateEnd"];
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

            return dateEnd;
        }

        public static string timeStart(string connection, int schedid)
        {
            SqlConnection con = new SqlConnection(connection);

            string hour = "";
            string min = "";
            string timeStart = "";

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();

                    SqlCommand timeStartcmd = new SqlCommand(@"SELECT LEFT(timeStart, 2) AS 'hrTimestart', SUBSTRING(CAST(timeStart 
                                                               AS varchar(15)), 4,2) AS 'minTimestart'
                                                               FROM tb_Schedule
                                                               where scheduleID = @scheduleID", con);

                    timeStartcmd.Parameters.AddWithValue("@scheduleID", schedid);

                    SqlDataReader reader = timeStartcmd.ExecuteReader();

                    while (reader.Read())
                    {
                        hour = (string)reader["hrTimestart"];
                        min = (string)reader["minTimestart"];
                        timeStart = hour + ":" + min;
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

            return timeStart;
        }

        public static string timeEnd(string connection, int schedid)
        {
            SqlConnection con = new SqlConnection(connection);

            string hour = "";
            string min = "";
            string timeEnd = "";

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();

                    SqlCommand timeEndcmd = new SqlCommand(@"SELECT LEFT(timeEnd, 2) AS 'hrTimeend', SUBSTRING(CAST(timeEnd 
                                                             AS varchar(15)), 4,2) AS 'minTimeend'
                                                             FROM tb_Schedule
                                                             where scheduleID = @scheduleID", con);

                    timeEndcmd.Parameters.AddWithValue("@scheduleID", schedid);

                    SqlDataReader reader = timeEndcmd.ExecuteReader();

                    while (reader.Read())
                    {
                        hour = (string)reader["hrTimeend"];
                        min = (string)reader["minTimeend"];
                        timeEnd = hour + ":" + min;
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

            return timeEnd;
        }

        public static string venue(string connection, int schedid)
        {
            SqlConnection con = new SqlConnection(connection);

            string venue = "";

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();

                    SqlCommand venueNamecmd = new SqlCommand(@"SELECT venueName
                                                              FROM tb_Schedule
                                                              WHERE scheduleID = @scheduleID", con);

                    venueNamecmd.Parameters.AddWithValue("@scheduleID", schedid);

                    SqlDataReader reader = venueNamecmd.ExecuteReader();

                    while (reader.Read())
                    {
                        venue = (string)reader["venueName"];
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

            return venue;
        }

        public static string fbGroupID(string connection, int schedid)
        {
            SqlConnection con = new SqlConnection(connection);

            string fbGroupID = "";

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();

                    SqlCommand fbCodecmd = new SqlCommand(@"SELECT fbGroupCode
                                                              FROM tb_Schedule
                                                              WHERE scheduleID = @scheduleID", con);

                    fbCodecmd.Parameters.AddWithValue("@scheduleID", schedid);

                    SqlDataReader reader = fbCodecmd.ExecuteReader();

                    while (reader.Read())
                    {
                        fbGroupID = (string)reader["fbGroupCode"];
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

            return fbGroupID;
        }

        public static double ticketAmount(string connection, int schedID)
        {
            SqlConnection con = new SqlConnection(connection);

            double amount = 0;

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();

                    SqlCommand eventNamecmd = new SqlCommand(@"SELECT ticketAmount
                                                              FROM tb_Schedule
                                                              WHERE scheduleID = @scheduleID", con);

                    eventNamecmd.Parameters.AddWithValue("@scheduleID", schedID);

                    SqlDataReader reader = eventNamecmd.ExecuteReader();

                    while (reader.Read())
                    {
                        amount = Convert.ToDouble((decimal)reader["ticketAmount"]);
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

            return amount;
        }

        public static DataTable viewAllNotFullEvents(string connection)
        {
            SqlConnection con = new SqlConnection(connection);
            DataTable allEvents = new DataTable();
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    SqlDataAdapter viewAllEvents = new SqlDataAdapter(@"SELECT EI.scheduleID, eventName, [description],
                                                                        FORMAT(dateStart, 'MMMM dd, yyyy') AS 'dateStart', FORMAT(dateEnd, 'MMMM dd, yyyy') AS 'dateEnd', 
                                                                        timeStart, timeEnd,
                                                                        venueName, ticketCapacity, ticketAmount, fbGroupCode                                                                    
                                                                        FROM tb_EventInfo EI JOIN tb_Schedule S ON EI.scheduleID = s.scheduleID
                                                                        WHERE (isPastEvent != 1 AND ticketCapacity != ticketBought)                                                                                                                                               
                                                                        AND ((DATEADD(HOUR,-2,(CONVERT(DATETIME, CONVERT(CHAR(8), dateStart, 112) 
                                                                        + ' ' + CONVERT(CHAR(8), timeStart, 108)))) !< GETDATE()))
                                                                        ORDER BY FORMAT(dateStart, 'yyyy-MM-dd') ASC", con);
                    viewAllEvents.Fill(allEvents);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                con.Close();
            }

            return allEvents;
        }

        public static int ticketBoughtCount(string connection, int scheduleID)
        {
            SqlConnection con = new SqlConnection(connection);

            int tickBought = 0;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();

                    SqlCommand getTicketBoughtCount = new SqlCommand(@"SELECT ticketBought FROM tb_Schedule
                                                                       WHERE scheduleID = @scheduleID", con);

                    getTicketBoughtCount.Parameters.AddWithValue("@scheduleID", scheduleID);

                    SqlDataReader reader = getTicketBoughtCount.ExecuteReader();

                    while (reader.Read())
                    {
                        tickBought = (int)reader["ticketBought"];
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


            return tickBought;
        }

        public static DataTable fillParticipantTable(string connection, int schedID, string status)
        {
            SqlConnection con = new SqlConnection(connection);
            DataTable result = new DataTable();

            try
            {
                if(con.State == ConnectionState.Closed)
                {
                    con.Open();

                    SqlDataAdapter participantResult = new SqlDataAdapter(@"SELECT firstName, lastName, age, contactNum
                                                                            FROM tb_participantInformations P JOIN tb_Ticket T
                                                                            ON P.participantID = T.participantID
                                                                            WHERE P.scheduleID = @scheduleID AND T.paymentStatus = @paymentStatus", con);

                    participantResult.SelectCommand.Parameters.AddWithValue("@scheduleID", schedID);
                    participantResult.SelectCommand.Parameters.AddWithValue("@paymentStatus", status);

                    participantResult.Fill(result);
                }
            }
            catch(Exception ex)
            {

            }
            finally
            {
                con.Close();
            }

            return result;
        }

        public static int countUnpaidParticipants(string connection, int scheduleID)
        {
            SqlConnection con = new SqlConnection(connection);
            int unpaidCount = 0;

            try
            {
                if(con.State == ConnectionState.Closed)
                {
                    con.Open();

                    SqlCommand getUnpaidCount = new SqlCommand(@"SELECT COUNT(participantID) AS 'UNPAID'
                                                                 FROM tb_Ticket
                                                                 WHERE schedID = @schedID
                                                                 AND paymentStatus = 'UNPAID'", con);

                    getUnpaidCount.Parameters.AddWithValue("@schedID", scheduleID);

                    SqlDataReader reader = getUnpaidCount.ExecuteReader();

                    while (reader.Read())
                    {
                        unpaidCount = (int)reader["UNPAID"];
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

            return unpaidCount;
        }

        public static DataTable systemLogsSearchResult(string connection, DateTime fromdate, DateTime todate)
        {
            SqlConnection con = new SqlConnection(connection);
            DataTable rangeResult = new DataTable();
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    SqlDataAdapter searchLogs = new SqlDataAdapter(@"SELECT * FROM tb_systemLogs
                                                                     WHERE timestamp BETWEEN @fromDate AND @toDate", con);

                    searchLogs.SelectCommand.Parameters.AddWithValue("@fromDate", fromdate);
                    searchLogs.SelectCommand.Parameters.AddWithValue("@toDate", todate);

                    searchLogs.Fill(rangeResult);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                con.Close();
            }

            return rangeResult;
        }

        public static DataTable viewAllEventsToday(string connection, DateTime datetoday)
        {
            SqlConnection con = new SqlConnection(connection);
            DataTable eventsToday = new DataTable();
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    SqlDataAdapter eventsNow = new SqlDataAdapter(@"SELECT EI.scheduleID, eventName, [description], dateStart, dateEnd, timeStart, timeEnd
                                                                    FROM tb_EventInfo EI JOIN tb_Schedule S ON EI.scheduleID = s.scheduleID
                                                                    WHERE isPastEvent != 1 AND @dateToday BETWEEN dateStart AND dateEnd", con);
                    eventsNow.SelectCommand.Parameters.AddWithValue("@dateToday", datetoday);

                    eventsNow.Fill(eventsToday);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                con.Close();
            }

            return eventsToday;
        }

        public static bool isScannedAlready(string connection, string detectedCode)
        {
            bool isScanned = true;
            int count = 0;

            SqlConnection con = new SqlConnection(connection);


            try
            {
                if(con.State == ConnectionState.Closed)
                {
                    con.Open();
                    SqlCommand isScannedCount = new SqlCommand(@"SELECT COUNT(*) AS 'isScannedCount' FROM tb_Ticket
                                                                 WHERE (qrCode = @qrCode AND paymentStatus = 'PAID') AND isScanned = 1", con);

                    isScannedCount.Parameters.AddWithValue("@qrCode", detectedCode);

                    SqlDataReader reader = isScannedCount.ExecuteReader();

                    while (reader.Read())
                    {
                        count = (int)reader["isScannedCount"];
                    }

                    if(count >= 1)
                    {
                        isScanned = true;
                    }
                    else
                    {
                        isScanned = false;
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

            return isScanned;
        }

        public static int upcomingEventParticipantCount(string connection)
        {
            SqlConnection con = new SqlConnection(connection);
            int count = 0;

            try
            {
                if(con.State == ConnectionState.Closed)
                {
                    con.Open();

                    SqlCommand partCountUpcomingevent = new SqlCommand(@"SELECT COUNT(*) AS 'partCount'
                                                                         FROM tb_participantInformations P JOIN tb_Ticket T
                                                                         ON P.participantID = T.participantID
                                                                         WHERE scheduleID = (SELECT TOP 1 S.scheduleID
					                                                                         FROM tb_schedule S JOIN tb_EventInfo E ON S.scheduleID = E.scheduleID
					                                                                         WHERE (DATEDIFF(DAY, GETDATE(), dateStart) IN (SELECT TOP 1 datediff(DAY, getdate(), dateStart) 
																                                                                            FROM tb_schedule S JOIN tb_EventInfo E
																                                                                            ON S.scheduleID = E.scheduleID
																                                                                            WHERE (isPastEvent != 1 AND datediff(DAY, getdate(), dateStart) >= 0) AND (CONVERT(DATETIME, CONVERT(CHAR(8), dateStart, 112)+ ' ' +CONVERT(CHAR(8), timeStart, 108)) !< GETDATE())
																                                                                            ORDER BY 1 ASC)) AND (isPastEvent != 1 AND CONVERT(DATETIME, CONVERT(CHAR(8), dateStart, 112)+ ' ' +CONVERT(CHAR(8), timeStart, 108)) !< GETDATE())
					                                                                         ORDER BY timeStart ASC)
                                                                         AND paymentStatus = 'PAID'", con);

                    SqlDataReader reader = partCountUpcomingevent.ExecuteReader();

                    while (reader.Read())
                    {
                        count = (int)reader["partCount"];
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

            return count;
        }

        public static int upcomingEventCount(string connection)
        {
            SqlConnection con = new SqlConnection(connection);

            int upcomingEvCount = 0;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();

                    SqlCommand getUpcomingCount = new SqlCommand(@"SELECT COUNT(*) AS 'upcomingEventCount'
                                                                   FROM tb_schedule S JOIN tb_EventInfo E ON S.scheduleID = E.scheduleID
                                                                   WHERE (DATEDIFF(DAY, GETDATE(), dateStart) IN (SELECT TOP 1 datediff(DAY, getdate(), dateStart) 
											                                                                      FROM tb_schedule S JOIN tb_EventInfo E
											                                                                      ON S.scheduleID = E.scheduleID
											                                                                      WHERE (isPastEvent != 1 AND datediff(DAY, getdate(), dateStart) >= 0) AND (CONVERT(DATETIME, CONVERT(CHAR(8), dateStart, 112)+ ' ' +CONVERT(CHAR(8), timeStart, 108)) !< GETDATE())
										                                                                          ORDER BY 1 ASC)) AND (isPastEvent != 1 AND CONVERT(DATETIME, CONVERT(CHAR(8), dateStart, 112)+ ' ' +CONVERT(CHAR(8), timeStart, 108)) !< GETDATE())", con);

                    SqlDataReader reader = getUpcomingCount.ExecuteReader();

                    while (reader.Read())
                    {
                        upcomingEvCount = (int)reader["upcomingEventCount"];
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


            return upcomingEvCount;
        }
    }
}
