<%@ Page Language="C#" AutoEventWireup="true" CodeFile="allEvents.aspx.cs" Inherits="allEvents" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>e-Ventory | EVENT LIST</title>
    <link rel="icon" href="..\Images\e-VentoryIcon.png"/>
</head>
<body style ="background-color: #FFF">
    <style>
        .table {
                display: table;
                margin: -6px 0px 0px 1px;
            }
         
         body {
                font-family: Verdana,Arial;
         }
         
         ul {
                list-style-type: none;
                margin: 0 auto;
                width: 1333px;
                padding: 0;
                overflow: hidden;
                background-color: #22313F;
         }

         li {
                display:inline-table;
                
                
         }

         li a {
               display: block;
               color: #E4F1FE;
               text-align: center;
               padding: 20px;
               text-decoration: none;
        }

        li a:hover {
               background-color: #34495E;
        }

        .gridView{
            margin-top: 0px;
            width: 1335px;
            border-collapse:collapse;
        }
        
        .gridView td{
            padding: 10px;
            border-bottom: 1px solid #000;
        }
        
        .gridView th{
            padding: 10px;
            border-bottom: 1px solid #000;
        }

        .header{
           font-family: 'Century Gothic';
           color: #2C3E50;
           border: none 0px transparent;
           height: 25px;
           text-align: center;
           font-size: 15px;
        }

        .rows{
            font-family: Arial;
            padding-bottom: 15px;
            padding-top:100px;
            border-right: #fff;
            border-left: #fff;
            text-align:center;
        }

        .rows:hover{
            background-color: #2C3E50;
            color: white;
            cursor: text;
            border-right: #2C3E50;
            border-left: #2C3E50;
        }

        .auto-style1 {
               width: 329px;
        }

        .header1{
            text-align:center;
            font-family:'Century Gothic';
            color: #2D3E50;
            margin-left: 60px;
        }

        .footer{
            margin-left: 920px;
            font-family:'Century Gothic';
            color:#2D3E50;
            font-size:medium;
        }
    </style>
    <table>
        <tr>
            <td>
                <a href ="..\Default.aspx">
                    <img src="..\Images\e-VentoryIcon.png" alt="e-Ventory Logo" style="width:150px;height:145px;" />
                </a>
            </td>
            <td>
                    <img src="..\Images\e-VentoryHeader.jpg" alt="e-Ventory Logo" style="width:1177px;height:145px;"/>
            </td>
        </tr>
    </table>
    <form id="form1" runat="server">
    <div class="table">
        <ul>
            <li class="auto-style1"><a href ="..\Default.aspx">Home</a></li>
            <li class="auto-style1"><a href ="allEvents.aspx">Event List</a></li>
            <li class="auto-style1"><a href="..\register.aspx"  >Register</a></li>
            <li class="auto-style1"><a href="..\about.aspx">About</a></li>
        </ul>
    </div>

        <asp:GridView ID="GridView1" runat="server" CssClass ="gridView" AutoGenerateColumns ="false" HeaderStyle-CssClass = "header" RowStyle-CssClass ="rows">
             <Columns>
                <asp:BoundField DataField="EVENT NAME" HeaderText="Event Name" />
                <asp:BoundField DataField="DESCRIPTION" HeaderText="Description" />
                <asp:BoundField DataField="START DATE" HeaderText="Start Date" />
                <asp:BoundField DataField="END DATE" HeaderText="End Date" />
                <asp:BoundField DataField="START TIME" HeaderText="Start Time" /> 
                <asp:BoundField DataField="END TIME" HeaderText="End Time" />
                <asp:BoundField DataField="VENUE" HeaderText="Venue" />
                <asp:BoundField DataField="TICKET AMOUNT" HeaderText="Ticket Amount" />        
             </Columns>
        </asp:GridView>

        <table>
        <tr>
            <td>
                <div class ="header1">
                    <h1>___________________________________________________________________________</h1>
                </div>
            </td>
        </tr>
        <tr>
            <td>
                <div class ="footer">
                    <h6>e-Ventory © 2017     ALANO-CANADA-PEPINO-SAMONTE-VASQUEZ</h6>
                </div>
            </td>
        </tr>
    </table>
    </form>
</body>
</html>
