using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace eVentoryLibraries
{
    class deleteStatements
    {
    }

    public class deleteStatement
    {
        public static bool deleteEventInfo(string connection, string schedID)
        {
            bool hadRowAffected = true;
            SqlConnection con = new SqlConnection(connection);

            try
            {
                if(con.State == ConnectionState.Closed)
                {
                    con.Open();

                    SqlCommand deleteCmd = new SqlCommand(@"DELETE FROM tb_EventInfo
                                                            WHERE scheduleID = @scheduleID", con);
                    deleteCmd.Parameters.AddWithValue("@scheduleID", schedID);
                    int row = deleteCmd.ExecuteNonQuery();

                    if(row >= 1)
                    {
                        hadRowAffected = true;
                    }
                    else
                    {
                        hadRowAffected = false;
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

            return hadRowAffected;
        }

        public static bool deleteSchedule(string connection, string schedID)
        {
            bool hadRowAffected = true;
            SqlConnection con = new SqlConnection(connection);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();

                    SqlCommand deleteCmd = new SqlCommand(@"DELETE FROM tb_Schedule
                                                            WHERE scheduleID = @scheduleID", con);
                    deleteCmd.Parameters.AddWithValue("@scheduleID", schedID);
                    int row = deleteCmd.ExecuteNonQuery();
                    if(row >= 1)
                    {
                        hadRowAffected = true;
                    }
                    else
                    {
                        hadRowAffected = false;
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

            return hadRowAffected;
        }

        public static bool deleteSystemLogs(string connection, string logID)
        {
            bool isDeleted = true;

            SqlConnection con = new SqlConnection(connection);

            try
            {
                if(con.State == ConnectionState.Closed)
                {
                    con.Open();
                    SqlCommand deleteLog = new SqlCommand(@"DELETE FROM tb_systemLogs
                                                            WHERE logID = @logID", con);

                    deleteLog.Parameters.AddWithValue("@logID", logID);

                    int row = deleteLog.ExecuteNonQuery();

                    if(row >= 1)
                    {
                        isDeleted = true;
                    }
                    else
                    {
                        isDeleted = false;
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

            return isDeleted;
        }

        public static void deleteAllLoggedAdmin(string connection)
        {
            SqlConnection con = new SqlConnection(connection);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    SqlCommand deleteLoggedAdmin = new SqlCommand("DELETE FROM tb_loggedAdmin", con);
                    deleteLoggedAdmin.CommandType = CommandType.Text;
                    deleteLoggedAdmin.ExecuteNonQuery();
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

        public static bool deleteParticipant(string connection, string schedID)
        {
            bool hadRowAffected = true;
            SqlConnection con = new SqlConnection(connection);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();

                    SqlCommand deleteCmd = new SqlCommand(@"DELETE FROM tb_participantInformations
                                                            WHERE scheduleID = @scheduleID", con);
                    deleteCmd.Parameters.AddWithValue("@scheduleID", schedID);
                    int row = deleteCmd.ExecuteNonQuery();
                    if (row >= 1)
                    {
                        hadRowAffected = true;
                    }
                    else
                    {
                        hadRowAffected = false;
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

            return hadRowAffected;
        }

        public static bool deleteTicket(string connection, string schedID)
        {
            bool hadRowAffected = true;
            SqlConnection con = new SqlConnection(connection);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();

                    SqlCommand deleteCmd = new SqlCommand(@"DELETE FROM tb_ticket
                                                            WHERE scheduleID = @scheduleID", con);
                    deleteCmd.Parameters.AddWithValue("@scheduleID", schedID);
                    int row = deleteCmd.ExecuteNonQuery();
                    if (row >= 1)
                    {
                        hadRowAffected = true;
                    }
                    else
                    {
                        hadRowAffected = false;
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

            return hadRowAffected;
        }
    }
}
