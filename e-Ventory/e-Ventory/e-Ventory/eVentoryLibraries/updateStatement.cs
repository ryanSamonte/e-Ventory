using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace eVentoryLibraries
{
    public class updateStatement
    {
        public static void updateSchedule(string connection, DateTime dateStart, DateTime dateEnd, DateTime timeStart, DateTime timeEnd, string venue, int capacity, string fbcode, decimal amount, int scheduleID)
        {
            SqlConnection con = new SqlConnection(@connection);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    SqlCommand updateSchedule_T = new SqlCommand(@"UPDATE tb_Schedule
                                                                   SET dateStart = @dateStart, dateEnd = @dateEnd, timeStart = @timeStart, 
                                                                   timeEnd = @timeEnd, venueName = @venueName,
                                                                   ticketCapacity = @ticketCapacity, fbGroupCode = @fbGroupCode, 
                                                                   ticketAmount = @ticketAmount
                                                                   WHERE scheduleID = @scheduleID", con);

                    updateSchedule_T.Parameters.AddWithValue("@dateStart", dateStart);
                    updateSchedule_T.Parameters.AddWithValue("@dateEnd", dateEnd);
                    updateSchedule_T.Parameters.AddWithValue("@timeStart", timeStart);
                    updateSchedule_T.Parameters.AddWithValue("@timeEnd", timeEnd);
                    updateSchedule_T.Parameters.AddWithValue("@venueName", venue);
                    updateSchedule_T.Parameters.AddWithValue("@ticketCapacity", capacity);
                    updateSchedule_T.Parameters.AddWithValue("@fbGroupCode", fbcode);
                    updateSchedule_T.Parameters.AddWithValue("@ticketAmount", amount);
                    updateSchedule_T.Parameters.AddWithValue("@scheduleID", scheduleID);

                    updateSchedule_T.ExecuteNonQuery();
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

        public static void updateSchedule(string connection, int capacity, string fbcode, decimal amount, int bought, int scheduleID)
        {
            SqlConnection con = new SqlConnection(@connection);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    SqlCommand insertOthertoSchedule = new SqlCommand(@"UPDATE tb_Schedule
                                                                        SET ticketCapacity = @ticketCapacity, fbGroupCode = @fbGroupCode, ticketAmount = @ticketAmount, ticketBought = @ticketBought
                                                                        WHERE scheduleID = @scheduleID", con);

                    insertOthertoSchedule.Parameters.AddWithValue("ticketCapacity", capacity);
                    insertOthertoSchedule.Parameters.AddWithValue("@fbGroupCode", fbcode);
                    insertOthertoSchedule.Parameters.AddWithValue("@ticketAmount", amount);
                    insertOthertoSchedule.Parameters.AddWithValue("@ticketBought", bought);
                    insertOthertoSchedule.Parameters.AddWithValue("@scheduleID", scheduleID);

                    insertOthertoSchedule.ExecuteNonQuery();
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

        public static void updateEventInfo(string connection, string description, int scheduleID)
        {
            SqlConnection con = new SqlConnection(@connection);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();

                    SqlCommand insertEventInf = new SqlCommand(@"UPDATE tb_EventInfo
                                                                 SET description = @description
                                                                 WHERE scheduleID = @scheduleID", con);
                    
                    insertEventInf.Parameters.AddWithValue("@description", description);
                    insertEventInf.Parameters.AddWithValue("@scheduleID", scheduleID);
                    
                    insertEventInf.ExecuteNonQuery();
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

        public static void updateEventStatus(string connection)
        {
            SqlConnection con = new SqlConnection(@connection);

            try
            {
                if(con.State == ConnectionState.Closed)
                {
                    con.Open();

                    SqlCommand updateIsPastEvent = new SqlCommand(@"UPDATE tb_EventInfo  
                                                                    SET isPastEvent = '1'
                                                                    WHERE scheduleID IN (SELECT S.scheduleID
                                                                                         FROM tb_schedule S JOIN tb_EventInfo E ON S.scheduleID = E.scheduleID
                                                                                         WHERE CONVERT(DATETIME, CONVERT(CHAR(8), dateEnd, 112)+ ' ' +CONVERT(CHAR(8), timeEnd, 108)) <= GETDATE() 
                                                                                         AND CONVERT(DATETIME, CONVERT(CHAR(8), dateEnd, 112)+ ' ' +CONVERT(CHAR(8), timeEnd, 108)) < GETDATE())", con);
                    
                    updateIsPastEvent.ExecuteNonQuery();
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

        public static void updateEventStatus(string connection, int schedID)
        {
            SqlConnection con = new SqlConnection(@connection);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();

                    SqlCommand updateIsPastEvent = new SqlCommand(@"UPDATE tb_EventInfo  
                                                                    SET isPastEvent = '1'
                                                                    WHERE scheduleID = @scheduleID", con);

                    updateIsPastEvent.Parameters.AddWithValue("@scheduleID", schedID);
                    updateIsPastEvent.ExecuteNonQuery();
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

        public static void updateTicketBought(string connection, int newticketbought, int scheduleID)
        {
            SqlConnection con = new SqlConnection(@connection);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();

                    SqlCommand updateCapacity = new SqlCommand(@"UPDATE tb_Schedule
                                                                 SET ticketBought = @ticketBought
                                                                 WHERE scheduleID = @scheduleID", con);

                    updateCapacity.Parameters.AddWithValue("@ticketBought", newticketbought);
                    updateCapacity.Parameters.AddWithValue("@scheduleID", scheduleID);

                    updateCapacity.ExecuteNonQuery();
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

        public static void updateQRCode(string connection, string newQrCode, int participantID)
        {
            SqlConnection con = new SqlConnection(@connection);

            try
            {
                if(con.State == ConnectionState.Closed)
                {
                    con.Open();

                    SqlCommand newQRCodecmd = new SqlCommand(@"UPDATE tb_Ticket
                                                            SET qrCode = @qrCode
                                                            WHERE participantID = @participantID", con);

                    newQRCodecmd.Parameters.AddWithValue("@qrCode", newQrCode);
                    newQRCodecmd.Parameters.AddWithValue("@participantID", participantID);

                    newQRCodecmd.ExecuteNonQuery();
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

        public static void updatePaymentStatus(string connection, int participantID)
        {
            SqlConnection con = new SqlConnection(@connection);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();

                    SqlCommand newPymntStatus = new SqlCommand(@"UPDATE tb_Ticket
                                                                 SET paymentStatus = 'PAID'
                                                                 WHERE participantID = @participantID", con);

                    newPymntStatus.Parameters.AddWithValue("@participantID", participantID);

                    newPymntStatus.ExecuteNonQuery();
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

        public static void updateIsScanned(string connection, int participantID, bool isScanned)
        {
            SqlConnection con = new SqlConnection(@connection);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();

                    SqlCommand updtIsScanned = new SqlCommand(@"UPDATE tb_Ticket
                                                                 SET isScanned = @isScanned
                                                                 WHERE participantID = @participantID", con);

                    updtIsScanned.Parameters.AddWithValue("@isScanned", isScanned);
                    updtIsScanned.Parameters.AddWithValue("@participantID", participantID);

                    updtIsScanned.ExecuteNonQuery();
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