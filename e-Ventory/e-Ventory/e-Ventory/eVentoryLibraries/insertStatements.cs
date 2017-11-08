using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace eVentoryLibraries
{
    public class insertStatements
    {
        public static void insertAdmin(string connection, string adminID, string lastname, string firstname, char gender, string age, string contactnum, string housenum, string streetname, string brgy, string city, string username, string password, string fbUname, string fbPassWord)
        {
            SqlConnection con = new SqlConnection(connection);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    SqlCommand insertSuperAdmin = new SqlCommand("INSERT INTO tb_adminInformations(adminID, lastName, firstName, gender, age, contactNumber, houseNumber, streetName, barangayName, cityName, userName, [passWord], fbUname, fbPassWord) VALUES(@adminID, @lastName, @firstName, @gender, @age, @contactNumber, @houseNumber, @streetName, @barangayName, @cityName, @userName, @passWord, @fbUname, @fbPassWord)", con);
                    insertSuperAdmin.CommandType = CommandType.Text;
                    insertSuperAdmin.Parameters.AddWithValue("@adminID", adminID);
                    insertSuperAdmin.Parameters.AddWithValue("@lastName", lastname);
                    insertSuperAdmin.Parameters.AddWithValue("@firstName", firstname);
                    insertSuperAdmin.Parameters.AddWithValue("@gender", gender);
                    insertSuperAdmin.Parameters.AddWithValue("@age", age);
                    insertSuperAdmin.Parameters.AddWithValue("@contactNumber", contactnum);
                    insertSuperAdmin.Parameters.AddWithValue("@houseNumber", housenum);
                    insertSuperAdmin.Parameters.AddWithValue("@streetName", streetname);
                    insertSuperAdmin.Parameters.AddWithValue("@barangayName", brgy);
                    insertSuperAdmin.Parameters.AddWithValue("@cityName", city);
                    insertSuperAdmin.Parameters.AddWithValue("@userName", username);
                    insertSuperAdmin.Parameters.AddWithValue("@passWord", password);
                    insertSuperAdmin.Parameters.AddWithValue("@fbUname", fbUname);
                    insertSuperAdmin.Parameters.AddWithValue("@fbPassWord", fbPassWord);
                    insertSuperAdmin.ExecuteNonQuery();
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

        public static void insertSystemLog(string connection, string description, string adminName, DateTime date_and_time)
        {
            SqlConnection con = new SqlConnection(connection);
            try
            {
                if(con.State == ConnectionState.Closed)
                {
                    con.Open();
                    SqlCommand insertSignInLog = new SqlCommand("INSERT INTO tb_systemLogs(logDescription, adminName, timestamp) VALUES(@logDescription, @adminName, @timestamp)", con);
                    insertSignInLog.CommandType = CommandType.Text;
                    insertSignInLog.Parameters.AddWithValue("@logDescription", description);
                    insertSignInLog.Parameters.AddWithValue("@adminName", adminName);
                    insertSignInLog.Parameters.Add("@timestamp", SqlDbType.DateTime).Value = date_and_time;
                    insertSignInLog.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {

            }
            finally
            {
                con.Close();
            }
        }

        public static void insertLoggedAdmin(string connection, string id, string username)
        {
            SqlConnection con = new SqlConnection(connection);

            try
            {
                if(con.State == ConnectionState.Closed)
                {
                    con.Open();
                    SqlCommand insertLoggedAd = new SqlCommand("INSERT INTO tb_loggedAdmin(adminID, userName) VALUES(@adminID, @userName)", con);
                    insertLoggedAd.CommandType = CommandType.Text;
                    insertLoggedAd.Parameters.AddWithValue("@adminID", Convert.ToInt32(id));
                    insertLoggedAd.Parameters.AddWithValue("@userName", username);
                    insertLoggedAd.ExecuteNonQuery();
                }

            }
            catch(Exception ex)
            {


            }
            finally
            {
                con.Close();
            }
        }

        public static void insertSchedule(string connection, DateTime dateStart, DateTime dateEnd, DateTime timeStart, DateTime timeEnd, string venue, int eventCode)
        {
            SqlConnection con = new SqlConnection(connection);

            try
            {
                if(con.State == ConnectionState.Closed)
                {
                    con.Open();
                    SqlCommand insertToSchedule = new SqlCommand(@"INSERT INTO tb_Schedule
                                                                   VALUES(@dateStart, @dateEnd, @timeStart, @timeEnd,
                                                                   @venueName, @eventID, @ticketCapacity,
                                                                   @fbGroupCode, @ticketAmount, @ticketBought)", con);

                    insertToSchedule.Parameters.AddWithValue("@dateStart", dateStart);
                    insertToSchedule.Parameters.AddWithValue("@dateEnd", dateEnd);
                    insertToSchedule.Parameters.AddWithValue("@timeStart", timeStart);
                    insertToSchedule.Parameters.AddWithValue("@timeEnd", timeEnd);
                    insertToSchedule.Parameters.AddWithValue("@venueName", venue);
                    insertToSchedule.Parameters.AddWithValue("@eventID", eventCode);
                    insertToSchedule.Parameters.AddWithValue("@ticketCapacity", 0);
                    insertToSchedule.Parameters.AddWithValue("@fbGroupCode", "temp");
                    insertToSchedule.Parameters.AddWithValue("@ticketAmount", 0);
                    insertToSchedule.Parameters.AddWithValue("@ticketBought", 0);

                    insertToSchedule.ExecuteNonQuery();
                }

            }
            catch(Exception ex)
            {

            }
            finally
            {
                con.Close();
            }
        }

        public static void insertEventInfo(string connection, string eventname, string description, int scheduleID, bool isPastEvent, int eventcode)
        {
            SqlConnection con = new SqlConnection(connection);

            try
            {
                if(con.State == ConnectionState.Closed)
                {
                    con.Open();

                    SqlCommand insertEventInf = new SqlCommand(@"INSERT INTO tb_EventInfo
                                                                 VALUES(@eventName, @description, @scheduleID, @isPastEvent, @eventCode)", con);

                    insertEventInf.Parameters.AddWithValue("@eventName", eventname);
                    insertEventInf.Parameters.AddWithValue("@description", description);
                    insertEventInf.Parameters.AddWithValue("@scheduleID", scheduleID);
                    insertEventInf.Parameters.AddWithValue("@isPastEvent", isPastEvent);
                    insertEventInf.Parameters.AddWithValue("@eventCode", eventcode);

                    insertEventInf.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {

            }
            finally
            {
                con.Close();
            }
        }

        public static void insertTicket(string connection, int schedID, string participantID, string qrCode, double tickAmount, bool isScanned)
        {
            SqlConnection con = new SqlConnection(connection);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();

                    SqlCommand insTicket = new SqlCommand(@"INSERT INTO tb_Ticket
                                                             VALUES(@schedID, @participantID,
                                                             @qrCode, @paymentStatus, @isScanned)", con);
                    insTicket.Parameters.AddWithValue("@schedID", schedID);
                    insTicket.Parameters.AddWithValue("@participantID", participantID);
                    insTicket.Parameters.AddWithValue("@qrCode", qrCode);
                    string status = "";
                    if (tickAmount == 0)
                    {
                        status = "PAID";
                    }
                    else
                    {
                        status = "UNPAID";
                    }
                    insTicket.Parameters.AddWithValue("@paymentStatus", status);
                    insTicket.Parameters.AddWithValue("@isScanned", isScanned);

                    insTicket.ExecuteNonQuery();
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

        public static void insertParticipant(string connection, string participantID, string lastname, string firstname, string age, string contact, int schedID)
        {
            SqlConnection con = new SqlConnection(connection);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();

                    SqlCommand insParticipant = new SqlCommand(@"INSERT INTO tb_participantInformations
                                                             VALUES(@participantID, @lastName,
                                                             @firstName, @age, @scheduleID, @contactNum)", con);

                    insParticipant.Parameters.AddWithValue("@participantID", participantID);
                    insParticipant.Parameters.AddWithValue("@lastName", lastname);
                    insParticipant.Parameters.AddWithValue("@firstName", firstname);
                    insParticipant.Parameters.AddWithValue("@age", age);
                    insParticipant.Parameters.AddWithValue("@contactNum", contact);
                    insParticipant.Parameters.AddWithValue("@scheduleID", schedID);

                    insParticipant.ExecuteNonQuery();
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
    }
}
