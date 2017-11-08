<%@ Page Language="C#" AutoEventWireup="true" CodeFile="about.aspx.cs" Inherits="about" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>e-Ventory | ABOUT</title>
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

        .auto-style1 {
               width: 329px;
        }

        .aboutHeader{
                color: white;
                text-align: center;
                font-size: 30px;
                margin-top: 30px;
                background-color: #22313F;
                font-family: 'Century Gothic';
        }
        .aboutPicture{
                width:1177px;
                height:600px;
                margin-left:71px;  
        }
        .developersPicture{
                width:100px;
                height:60px;
                margin-left:85px  
        }

        .tooltip {
                position: relative;
                display: inline-block;
                border-bottom: 1px dotted black;
        }

        .tooltip .tooltiptext {
                visibility: hidden;
                color: #fff;
                text-align: center;
                border-radius: 6px;
                padding: 5px 0px;
    /* Position the tooltip */
                position: absolute;
                top: 280px;
        }

        .tooltip .tooltiptext1{
            visibility: hidden;
                /*padding: 5px 0px;*/ 
                color: #fff;
                text-align: center;
                border-radius: 6px;

    /* Position the tooltip */
                position: absolute;
                top: 304px;
            font-size: 15px;
            font-family: 'Century Gothic';
        }

        .tooltip:hover .tooltiptext {
                visibility: visible;
        }
        .tooltip:hover .tooltiptext1 {
                visibility: visible;
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
            <li class="auto-style1"><a href ="..\allEvents.aspx">Event List</a></li>
            <li class="auto-style1"><a href="..\register.aspx">Register</a></li>
            <li class="auto-style1"><a href="..\about.aspx">About</a></li>
        </ul>
    </div>

    <div class ="aboutHeader">
        <h4>What is e-Ventory?</h4>
    </div>

    <table class="aboutPicture">
            <tr>
                <td>
                    <img src="..\Images\About.jpg" alt="aboutPic"/>
                </td>
            </tr>
    </table>

    <div class ="aboutHeader">
        <h4>Developers</h4>
    </div>

    <!--<table class="developersPicture">-->
         <table>   
            <tr>
                <td>
                   <div class="tooltip">
                       <img src="..\Images\Peps.jpg" alt="developersPic" style="width:255px;height:600px;margin-left:85px;"/>
                       <span class="tooltiptext"><img src="..\Images\AppEngPeps.png" alt="pepsAppEng"/></span>
                   </div>

                   <div class="tooltip">
                       <img src="..\Images\Lowell.jpg" alt="developersPic" style="width:188px;height:600px;margin-left:-6px;"/>
                       <span class="tooltiptext"><img src="..\Images\TechDocJay.png" alt="aboutPic" style="margin-left:-110px;"/></span>
                   </div>

                   <div class="tooltip">
                       <img src="..\Images\Ryan.jpg" alt="developersPic" style="width:241px;height:600px;margin-left:-6px;"/>
                       <span class="tooltiptext"><img src="..\Images\ProjLeadRyan.png" alt="aboutPic" style="margin-left:-50px;"/></span>
                   </div>
                   
                   <div class="tooltip">
                       <img src="..\Images\Bryan.jpg" alt="developersPic" style="width:233px;height:600px;margin-left:-6px;"/>
                       <span class="tooltiptext"><img src="..\Images\DataEngBryandNeth.png" alt="aboutPic" style="margin-left:-60px;"/></span>
                   </div>

                   <div class="tooltip">
                       <img src="..\Images\Kenneth.jpg" alt="developersPic" style="width:233px;height:600px;margin-left:-6px;"/>
                       <span class="tooltiptext"><img src="..\Images\DataEngBryandNeth1.png" alt="aboutPic" style="margin-left:20px;"/></span>
                   </div>
                </td>
            </tr>
    </table>

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
