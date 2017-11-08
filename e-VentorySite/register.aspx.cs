using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Web.Configuration;

public partial class register : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString);
    string successfulMessage = "";
    int checkCount = 0;
    int schedID = 0;
    double tickAmount = 0;
    string fbCode = "";

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            fillEventName();
            idGenerator();
        }
        
    }
    void fillEventName()
    {
        try
        {
            if(con.State == ConnectionState.Closed)
            {
                con.Open();

                SqlCommand getEventNames = new SqlCommand(@"SELECT DISTINCT eventName
                                                            FROM tb_eventInfo
                                                            WHERE isPastEvent != 1", con);


                SqlDataReader reader = getEventNames.ExecuteReader();

                while (reader.Read())
                {
                    eventNameList.Items.Add((string)reader["eventName"]);
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
    }

    void idGenerator()
    {
        int count = 0;
        int lastID = 0;
        try
        {
            if(con.State == ConnectionState.Closed)
            {
                con.Open();
                SqlCommand getPartTCount = new SqlCommand(@"SELECT COUNT(*) AS 'partTcount' FROM tb_participantInformations", con);

                SqlDataReader reader = getPartTCount.ExecuteReader();

                while (reader.Read())
                {
                    count = (int)reader["partTcount"];
                }
            }
        }
        catch(Exception ex)
        {
            Response.Write(ex.Message);
        }
        finally
        {
            con.Close();
        }

        if (count == 0)
        {
            participantIdLbl.Text = "1";
        }
        else
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();

                    SqlCommand getID = new SqlCommand(@"SELECT TOP 1 participantID FROM tb_participantInformations ORDER BY participantID DESC", con);

                    SqlDataReader reader2 = getID.ExecuteReader();

                    while (reader2.Read())
                    {
                        lastID = (int)reader2["participantID"];
                    }
                    int nextID = lastID + 1;
                    participantIdLbl.Text = nextID.ToString();
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }

    protected void submitBtn_Click(object sender, EventArgs e)
    {


        string timeStart = hrStart.SelectedItem.ToString() + ":" + minStart.SelectedItem.ToString();
        string timeEnd = hrEnd.SelectedItem.ToString() + ":" + minEnd.SelectedItem.ToString();
        bool emptyPartInput = lastNameTxt.Text == "" || firstNameTxt.Text == "" || ageTxt.Text == "" || emailAddTxt.Text == "" || datepicker.Text == "" || datepicker1.Text == "";

        if (emptyPartInput == true)
        {
            string errorM = "window.onload = function() { errorMessage('Kindly fill out all fields'); };";
            ClientScript.RegisterStartupScript(this.GetType(), "errorMessage", errorM, true);
        }
        else
        {
            //checkIfwronginput
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();

                    SqlCommand checkEventInfo = new SqlCommand(@"SELECT COUNT(*) AS 'eventCount'
                                                             FROM tb_EventInfo EI JOIN tb_Schedule S ON EI.scheduleID = s.scheduleID
                                                             WHERE ((eventName = @eventName AND dateStart = @dateStart) 
                                                             AND (dateEnd = @dateEnd AND timeStart = @timeStart))
                                                             AND (timeEnd = @timeEnd AND venueName = @venueName)", con);

                    checkEventInfo.Parameters.AddWithValue("@eventName", eventNameList.SelectedItem.ToString());
                    checkEventInfo.Parameters.AddWithValue("@dateStart", datepicker.Text);
                    checkEventInfo.Parameters.AddWithValue("@dateEnd", datepicker1.Text);
                    checkEventInfo.Parameters.AddWithValue("@timeStart", timeStart);
                    checkEventInfo.Parameters.AddWithValue("@timeEnd", timeEnd);
                    checkEventInfo.Parameters.AddWithValue("@venueName", venueTxt.Text);

                    SqlDataReader reader = checkEventInfo.ExecuteReader();

                    while (reader.Read())
                    {
                        checkCount = (int)reader["eventCount"];
                    }
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
            finally
            {
                con.Close();
            }

            if (checkCount == 0)
            {
                string errorM = "window.onload = function() { errorMessage('Event not existing. Make sure to input the right info about your chosen event'); };";
                ClientScript.RegisterStartupScript(this.GetType(), "errorMessage", errorM, true);
            }
            else
            {
                //getSchedID
                try
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();

                        SqlCommand getSchedID = new SqlCommand(@"SELECT S.scheduleID AS 'scheduleID', ticketAmount, fbGroupCode
                                                             FROM tb_EventInfo EI JOIN tb_Schedule S ON EI.scheduleID = S.scheduleID
                                                             WHERE ((eventName = @eventName AND dateStart = @dateStart) 
                                                             AND (dateEnd = @dateEnd AND timeStart = @timeStart))
                                                             AND (timeEnd = @timeEnd AND venueName = @venueName)", con);

                        getSchedID.Parameters.AddWithValue("@eventName", eventNameList.SelectedItem.ToString());
                        getSchedID.Parameters.AddWithValue("@dateStart", datepicker.Text);
                        getSchedID.Parameters.AddWithValue("@dateEnd", datepicker1.Text);
                        getSchedID.Parameters.AddWithValue("@timeStart", timeStart);
                        getSchedID.Parameters.AddWithValue("@timeEnd", timeEnd);
                        getSchedID.Parameters.AddWithValue("@venueName", venueTxt.Text);

                        SqlDataReader reader = getSchedID.ExecuteReader();

                        while (reader.Read())
                        {
                            schedID = (int)reader["scheduleID"];
                            tickAmount = Convert.ToDouble((decimal)reader["ticketAmount"]);
                            fbCode = (string)reader["fbGroupCode"];
                        }
                    }
                }
                catch (Exception ex)
                {
                    Response.Write("<script>alert('" + ex.Message + "');</script>");
                }
                finally
                {
                    con.Close();
                }

                //insertTo_tb_Ticket
                try
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();

                        SqlCommand insTicket = new SqlCommand(@"INSERT INTO tb_Ticket
                                                             VALUES(@schedID, @participantID,
                                                             @qrCode, @paymentStatus, @isScanned)", con);
                        insTicket.Parameters.AddWithValue("@schedID", schedID);
                        insTicket.Parameters.AddWithValue("@participantID", participantIdLbl.Text);
                        insTicket.Parameters.AddWithValue("@qrCode", participantIdLbl.Text + schedID.ToString());

                        string status = "";
                        if (tickAmount == 0)
                        {
                            status = "PAID";
                            successfulMessage = "SAVE YOUR QR TICKET NOW!, if you want to receive new updates about your chosen event you may join the Facebook Group https://www.facebook.com/groups/" + fbCode + "/";
                        }
                        else
                        {
                            status = "UNPAID";
                            successfulMessage = "SAVE YOUR QR VOUCHER NOW!, make sure to pay as soon as possible to complete your registration and join the Facebook Group https://www.facebook.com/groups/" + fbCode + "/ To keep updated about your chosen event.";
                        }
                        insTicket.Parameters.AddWithValue("@paymentStatus", status);
                        insTicket.Parameters.AddWithValue("@isScanned", false);
                        insTicket.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Response.Write("<script>alert('" + ex.Message + "');</script>");
                }
                finally
                {
                    con.Close();
                }

                //inserttoParticipant_tb
                try
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();

                        SqlCommand insParticipant = new SqlCommand(@"INSERT INTO tb_participantInformations
                                                                     VALUES(@participantID, @lastName,
                                                                     @firstName, @age, @scheduleID, @contactNum)", con);

                        insParticipant.Parameters.AddWithValue("@participantID", participantIdLbl.Text);
                        insParticipant.Parameters.AddWithValue("@lastName", lastNameTxt.Text);
                        insParticipant.Parameters.AddWithValue("@firstName", firstNameTxt.Text);
                        insParticipant.Parameters.AddWithValue("@age", ageTxt.Text);
                        insParticipant.Parameters.AddWithValue("@contactNum", emailAddTxt.Text);
                        insParticipant.Parameters.AddWithValue("@scheduleID", schedID);

                        insParticipant.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Response.Write("<script>alert('" + ex.Message + "');</script>");
                }
                finally
                {
                    con.Close();
                }


                QRCodeEncoder encoder = new QRCodeEncoder();

                Bitmap img = encoder.Encode(participantIdLbl.Text + schedID.ToString());

                img = new Bitmap(img, new Size(100, 100));
                System.IO.MemoryStream stream = new System.IO.MemoryStream();
                img.Save(stream, System.Drawing.Imaging.ImageFormat.Bmp);
                byte[] imageBytes = stream.ToArray();

                string path = Convert.ToBase64String(imageBytes);
                QRImage.ImageUrl = "data:image/png;base64," + path;
                
                string script = "window.onload = function() { alertMessage('" + successfulMessage + "'); };";
                ClientScript.RegisterStartupScript(this.GetType(), "alertMessage", script, true);
                idGenerator();
            }
        }
    }

    protected void saveQR_Click(object sender, EventArgs e)
    {
        Page.ClientScript.RegisterStartupScript(this.GetType(), "hwa", "printpage();window.location.href = 'register.aspx'", true);
    }
}