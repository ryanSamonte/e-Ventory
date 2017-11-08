using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Web.Configuration;

public partial class allEvents : System.Web.UI.Page
{

    SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {
        fillTable();
    }

    void fillTable()
    {
        try
        {
            if(con.State == ConnectionState.Closed)
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(@"SELECT eventName AS 'EVENT NAME', [description] AS 'DESCRIPTION',
                                                  FORMAT(dateStart, 'MMMM dd, yyyy') AS 'START DATE', 
                                                  FORMAT(dateEnd, 'MMMM dd, yyyy') AS 'END DATE', 
                                                  CONVERT(varchar(15),timeStart,100) AS 'START TIME', CONVERT(varchar(15),timeEnd,100) AS 'END TIME', 
                                                  venueName AS 'VENUE', 
                                                  ticketAmount AS 'TICKET AMOUNT'
                                                  FROM tb_EventInfo EI JOIN tb_Schedule S ON EI.scheduleID = s.scheduleID
                                                  WHERE (isPastEvent != 1 AND ticketCapacity != ticketBought)                                                                                                                                               
                                                  AND ((DATEADD(HOUR,-2,(CONVERT(DATETIME, CONVERT(CHAR(8), dateStart, 112) 
                                                  + ' ' + CONVERT(CHAR(8), timeStart, 108)))) !< GETDATE()))
                                                  ORDER BY FORMAT(dateStart, 'yyyy-MM-dd') ASC", con);

                GridView1.DataSource = cmd.ExecuteReader();

                GridView1.DataBind();
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
    }
}