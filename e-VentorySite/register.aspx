<%@ Page Language="C#" AutoEventWireup="true" CodeFile="register.aspx.cs" Inherits="register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>e-Ventory | REGISTER</title>
    <link rel="icon" href="..\Images\e-VentoryIcon.png"/>
    <link rel="stylesheet" href="//code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css"`/>
  <script src="https://code.jquery.com/jquery-1.12.4.js"></script>
  <script src="https://code.jquery.com/ui/1.12.1/jquery-ui.js"></script>
  <script src="https://unpkg.com/sweetalert/dist/sweetalert.min.js"></script>
    <script>
  $( function() {
    $( "#datepicker" ).datepicker();
  } );
    </script>
    <script>
  $( function() {
    $( "#datepicker1" ).datepicker();
  });
    </script>
    <script>
        function printpage() {
            var getpanel = document.getElementById("<%= Panel1.ClientID%>");
            var MainWindow = window.open('', '', 'height=500,width=800');
            MainWindow.document.write('<html><head><title>e-Ventory : EVENT MANAGEMENT SYSTEM</title>');
            MainWindow.document.write('</head><body>');
            MainWindow.document.write(getpanel.innerHTML);
            MainWindow.document.write('</body></html>');
            MainWindow.document.write('</br></br></br></br></br></br></br></br></br></br></br></br>Powered by: e-Ventory: EVENT MANAGEMENT SYSTEM</br></br>Developers:');
            MainWindow.document.write('</br>Bryan Julius A. Alano');
            MainWindow.document.write('</br>Kenneth H. Canada');
            MainWindow.document.write('</br>John Roderick T. Pepino');
            MainWindow.document.write('</br>Ryan Joseph R. Samonte');
            MainWindow.document.write('</br>Lowell Jay F. Vasquez');
            MainWindow.document.close();
            setTimeout(function () {
                MainWindow.print();
            }, 100);
            return false;
        }
    </script>

    <script>
        function alertMessage(message) {
            sweetAlert({
                text: message,
                icon: "success",
                button: "OK",
            });
        }
    </script>

    <script>
        function errorMessage(errMessage) {
            sweetAlert({
                text: errMessage,
                icon: "error",
                button: "OK",
            });
        }
    </script>

    <style type="text/css">
        .auto-style1 {
            margin-left: 100px;
            border-style: solid;
            border-width: 1px;
            border: 5px solid #22313F;
            
        }
        .auto-style5 {
            margin-left: 100px;
            height:10px;
        }
        .auto-style6 {
            width: 200px;
            text-align: right;
            height: 32px;
        }
        .auto-style7 {
            width: 324px;
            height: 32px;
        }
        .auto-style8 {
            height: 32px;
            width: 329px;
        }
        #Reset1 {
            width: 134px;
        }
        .auto-style9 {
            width: 324px;
            text-align: center;
        }
        .auto-style10 {
            width: 200px;
            text-align: center;
        }
        .buttonTable {
            margin-bottom:275px;
            margin-left: 500px;
            position:static;
        }

        .submitBtn{
            background-color: white;
            margin-top: 0px;
            margin-left: 500px; 
            color: black;
            width: 200px;
            height: 50px;
            font-family: 'Century Gothic';
            font-size: 20px; 
            border: 2px solid #22313F;
            -webkit-transition-duration: 0.4s; /* Safari */
            transition-duration: 0.4s;
            cursor: pointer;
        }

        .submitBtn:hover{
            background-color: #22313F;
            color: white;
        }

        .saveQRBtn{
            background-color: white; 
            color: black;
            margin-left: 500px;
            width: 200px;
            height: 50px;
            font-family: 'Century Gothic';
            font-size: 20px;  
            border: 2px solid #22313F;
            -webkit-transition-duration: 0.4s; /* Safari */
            transition-duration: 0.4s;
            cursor: pointer;
        }

        .saveQRBtn:hover{
            background-color: #22313F;
            color: white;
        }

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

        .auto-style11 {
               width: 329px;
        }

        .heading1{
               color: white;
               text-align: center;
               font-size: 30px;
               margin-top: 30px;
               background-color: #22313F;
               font-family: 'Century Gothic';
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
        .auto-style12 {
            text-align: left;
            height:10px;
            background-color:red;
        }

        .label{
            margin-left: 95px;
            margin-top: 0px;
            margin-bottom: 0px;
            font-family:'Century Gothic';
        }

        .label:hover{
            color: #6BB9F0;
        }

        .qrImage{
            margin-top: 20px;
        }
    </style>
</head>
<body>
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
            <li class="auto-style11"><a href ="..\Default.aspx">Home</a></li>
            <li class="auto-style11"><a href ="allEvents.aspx">Event List</a></li>
            <li class="auto-style11"><a href="..\register.aspx"  >Register</a></li>
            <li class="auto-style11"><a href="..\about.aspx">About</a></li>
        </ul>
    </div>
    <div class ="heading1">
    
        <h4>EVENT REGISTRATION</h4>
    </div>
        <br />
        <table>
            <tr>
                <td>
                    <img src="..\Images\instructionBannerFinal.png" alt="function 1" style="width:1328px;height:240px;margin-left:0px" />
                </td>
            </tr>
        </table>
        <table>
            <tr>
                <td class="auto-style6">Participant ID:</td>
                <td class="auto-style7">
                    <asp:Label ID="participantIdLbl" runat="server" Font-Bold="True" Font-Size="Larger"></asp:Label>
                </td>
            </tr>
            
        </table>
        <asp:Panel ID="Panel1" runat="server" Height="114px">
        <table class="auto-style1">
            <tr>
             
                <td class="auto-style8">
                    &nbsp;
                </td>
                <td class="auto-style8">
                    &nbsp;
                </td>
                <td>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Image ID="QRImage" runat="server" CssClass="qrImage"/>
                </td>
                    
            </tr>
            <tr>
                <td>
                    <h4 class="label">Last Name</h4>
                </td>
                <td class="auto-style5">
                    <asp:TextBox ID="lastNameTxt" runat="server" Width="280px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <h4 class="label">First Name</h4>
                </td>
                <td class="auto-style5">
                    <asp:TextBox ID="firstNameTxt" runat="server" Width="280px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="height:10px;">
                    <h4 class="label">Age</h4>
                </td>
                <td style="height:10px;">
                    <asp:TextBox ID="ageTxt" runat="server" Width="280px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <h4 class="label">Contact Number</h4>
                </td>
                <td style="height:10px;">
                    <asp:TextBox ID="emailAddTxt" runat="server" Width="280px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <h4 class="label">Event Name</h4>
                </td>
                <td class="auto-style5">
                    <asp:DropDownList ID="eventNameList" runat="server" Height="16px" Width="284px">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <h4 class="label">Start Date</h4>
                </td>
                <td>
                    <asp:TextBox ID ="datepicker" runat="server" ></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <h4 class="label">End Date</h4>
                </td>
                <td>
                    <asp:TextBox ID ="datepicker1" runat="server" ></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <h4 class="label">Start Time</h4>
                </td>
                <td class="auto-style5">
                    <asp:DropDownList ID="hrStart" runat="server" Height="16px" Width="65px">
                        <asp:ListItem Selected="True">00</asp:ListItem>
                        <asp:ListItem>01</asp:ListItem>
                        <asp:ListItem>02</asp:ListItem>
                        <asp:ListItem>03</asp:ListItem>
                        <asp:ListItem>04</asp:ListItem>
                        <asp:ListItem>05</asp:ListItem>
                        <asp:ListItem>06</asp:ListItem>
                        <asp:ListItem>07</asp:ListItem>
                        <asp:ListItem>09</asp:ListItem>
                        <asp:ListItem>10</asp:ListItem>
                        <asp:ListItem>11</asp:ListItem>
                        <asp:ListItem>12</asp:ListItem>
                        <asp:ListItem>13</asp:ListItem>
                        <asp:ListItem>14</asp:ListItem>
                        <asp:ListItem>15</asp:ListItem>
                        <asp:ListItem>16</asp:ListItem>
                        <asp:ListItem>17</asp:ListItem>
                        <asp:ListItem>18</asp:ListItem>
                        <asp:ListItem>19</asp:ListItem>
                        <asp:ListItem>20</asp:ListItem>
                        <asp:ListItem>21</asp:ListItem>
                        <asp:ListItem>22</asp:ListItem>
                        <asp:ListItem>23</asp:ListItem>
                        <asp:ListItem>24</asp:ListItem>
                    </asp:DropDownList>
                    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Larger" Text=":"></asp:Label>
                    <asp:DropDownList ID="minStart" runat="server" Height="16px" Width="65px">
                        <asp:ListItem>00</asp:ListItem>
                        <asp:ListItem>01</asp:ListItem>
                        <asp:ListItem>02</asp:ListItem>
                        <asp:ListItem>03</asp:ListItem>
                        <asp:ListItem>04</asp:ListItem>
                        <asp:ListItem>05</asp:ListItem>
                        <asp:ListItem>06</asp:ListItem>
                        <asp:ListItem>07</asp:ListItem>
                        <asp:ListItem>08</asp:ListItem>
                        <asp:ListItem>09</asp:ListItem>
                        <asp:ListItem>10</asp:ListItem>
                        <asp:ListItem>11</asp:ListItem>
                        <asp:ListItem>12</asp:ListItem>
                        <asp:ListItem>13</asp:ListItem>
                        <asp:ListItem>14</asp:ListItem>
                        <asp:ListItem>15</asp:ListItem>
                        <asp:ListItem>16</asp:ListItem>
                        <asp:ListItem>17</asp:ListItem>
                        <asp:ListItem>18</asp:ListItem>
                        <asp:ListItem>19</asp:ListItem>
                        <asp:ListItem>20</asp:ListItem>
                        <asp:ListItem>21</asp:ListItem>
                        <asp:ListItem>22</asp:ListItem>
                        <asp:ListItem>23</asp:ListItem>
                        <asp:ListItem>24</asp:ListItem>
                        <asp:ListItem>25</asp:ListItem>
                        <asp:ListItem>26</asp:ListItem>
                        <asp:ListItem>27</asp:ListItem>
                        <asp:ListItem>28</asp:ListItem>
                        <asp:ListItem>29</asp:ListItem>
                        <asp:ListItem>30</asp:ListItem>
                        <asp:ListItem>31</asp:ListItem>
                        <asp:ListItem>32</asp:ListItem>
                        <asp:ListItem>33</asp:ListItem>
                        <asp:ListItem>34</asp:ListItem>
                        <asp:ListItem>35</asp:ListItem>
                        <asp:ListItem>36</asp:ListItem>
                        <asp:ListItem>37</asp:ListItem>
                        <asp:ListItem>38</asp:ListItem>
                        <asp:ListItem>39</asp:ListItem>
                        <asp:ListItem>40</asp:ListItem>
                        <asp:ListItem>41</asp:ListItem>
                        <asp:ListItem>42</asp:ListItem>
                        <asp:ListItem>43</asp:ListItem>
                        <asp:ListItem>44</asp:ListItem>
                        <asp:ListItem>45</asp:ListItem>
                        <asp:ListItem>46</asp:ListItem>
                        <asp:ListItem>47</asp:ListItem>
                        <asp:ListItem>48</asp:ListItem>
                        <asp:ListItem>49</asp:ListItem>
                        <asp:ListItem>50</asp:ListItem>
                        <asp:ListItem>51</asp:ListItem>
                        <asp:ListItem>52</asp:ListItem>
                        <asp:ListItem>53</asp:ListItem>
                        <asp:ListItem>54</asp:ListItem>
                        <asp:ListItem>55</asp:ListItem>
                        <asp:ListItem>56</asp:ListItem>
                        <asp:ListItem>57</asp:ListItem>
                        <asp:ListItem>58</asp:ListItem>
                        <asp:ListItem>59</asp:ListItem>
                        <asp:ListItem>60</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <h4 class="label">End Time</h4>
                </td>
                <td class="auto-style5">
                    <asp:DropDownList ID="hrEnd" runat="server" Height="16px" Width="65px">
                        <asp:ListItem Selected="True">00</asp:ListItem>
                        <asp:ListItem>01</asp:ListItem>
                        <asp:ListItem>02</asp:ListItem>
                        <asp:ListItem>03</asp:ListItem>
                        <asp:ListItem>04</asp:ListItem>
                        <asp:ListItem>05</asp:ListItem>
                        <asp:ListItem>06</asp:ListItem>
                        <asp:ListItem>07</asp:ListItem>
                        <asp:ListItem>09</asp:ListItem>
                        <asp:ListItem>10</asp:ListItem>
                        <asp:ListItem>11</asp:ListItem>
                        <asp:ListItem>12</asp:ListItem>
                        <asp:ListItem>13</asp:ListItem>
                        <asp:ListItem>14</asp:ListItem>
                        <asp:ListItem>15</asp:ListItem>
                        <asp:ListItem>16</asp:ListItem>
                        <asp:ListItem>17</asp:ListItem>
                        <asp:ListItem>18</asp:ListItem>
                        <asp:ListItem>19</asp:ListItem>
                        <asp:ListItem>20</asp:ListItem>
                        <asp:ListItem>21</asp:ListItem>
                        <asp:ListItem>22</asp:ListItem>
                        <asp:ListItem>23</asp:ListItem>
                        <asp:ListItem>24</asp:ListItem>
                    </asp:DropDownList>
                    <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="Larger" Text=":"></asp:Label>
                    <asp:DropDownList ID="minEnd" runat="server" Height="16px" Width="65px">
                        <asp:ListItem>00</asp:ListItem>
                        <asp:ListItem>01</asp:ListItem>
                        <asp:ListItem>02</asp:ListItem>
                        <asp:ListItem>03</asp:ListItem>
                        <asp:ListItem>04</asp:ListItem>
                        <asp:ListItem>05</asp:ListItem>
                        <asp:ListItem>06</asp:ListItem>
                        <asp:ListItem>07</asp:ListItem>
                        <asp:ListItem>08</asp:ListItem>
                        <asp:ListItem>09</asp:ListItem>
                        <asp:ListItem>10</asp:ListItem>
                        <asp:ListItem>11</asp:ListItem>
                        <asp:ListItem>12</asp:ListItem>
                        <asp:ListItem>13</asp:ListItem>
                        <asp:ListItem>14</asp:ListItem>
                        <asp:ListItem>15</asp:ListItem>
                        <asp:ListItem>16</asp:ListItem>
                        <asp:ListItem>17</asp:ListItem>
                        <asp:ListItem>18</asp:ListItem>
                        <asp:ListItem>19</asp:ListItem>
                        <asp:ListItem>20</asp:ListItem>
                        <asp:ListItem>21</asp:ListItem>
                        <asp:ListItem>22</asp:ListItem>
                        <asp:ListItem>23</asp:ListItem>
                        <asp:ListItem>24</asp:ListItem>
                        <asp:ListItem>25</asp:ListItem>
                        <asp:ListItem>26</asp:ListItem>
                        <asp:ListItem>27</asp:ListItem>
                        <asp:ListItem>28</asp:ListItem>
                        <asp:ListItem>29</asp:ListItem>
                        <asp:ListItem>30</asp:ListItem>
                        <asp:ListItem>31</asp:ListItem>
                        <asp:ListItem>32</asp:ListItem>
                        <asp:ListItem>33</asp:ListItem>
                        <asp:ListItem>34</asp:ListItem>
                        <asp:ListItem>35</asp:ListItem>
                        <asp:ListItem>36</asp:ListItem>
                        <asp:ListItem>37</asp:ListItem>
                        <asp:ListItem>38</asp:ListItem>
                        <asp:ListItem>39</asp:ListItem>
                        <asp:ListItem>40</asp:ListItem>
                        <asp:ListItem>41</asp:ListItem>
                        <asp:ListItem>42</asp:ListItem>
                        <asp:ListItem>43</asp:ListItem>
                        <asp:ListItem>44</asp:ListItem>
                        <asp:ListItem>45</asp:ListItem>
                        <asp:ListItem>46</asp:ListItem>
                        <asp:ListItem>47</asp:ListItem>
                        <asp:ListItem>48</asp:ListItem>
                        <asp:ListItem>49</asp:ListItem>
                        <asp:ListItem>50</asp:ListItem>
                        <asp:ListItem>51</asp:ListItem>
                        <asp:ListItem>52</asp:ListItem>
                        <asp:ListItem>53</asp:ListItem>
                        <asp:ListItem>54</asp:ListItem>
                        <asp:ListItem>55</asp:ListItem>
                        <asp:ListItem>56</asp:ListItem>
                        <asp:ListItem>57</asp:ListItem>
                        <asp:ListItem>58</asp:ListItem>
                        <asp:ListItem>59</asp:ListItem>
                        <asp:ListItem>60</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <h4 class="label">Venue</h4>
                </td>
                <td class="auto-style5">
                    <asp:TextBox ID="venueTxt" runat="server" Width="280px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
          
            <tr>
                <td class="auto-style11">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style11">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>

        </table>
            </asp:Panel>
            <table class ="buttonTable">
                <tr>
                        <td>    
                            <asp:Button class="submitBtn" runat="server" OnClick="submitBtn_Click" Text="Submit"></asp:Button>
                        </td>
                </tr>
                <tr>
                        <td>
                            <asp:Button class="saveQRBtn" runat="server" Text="Save QR Code" ID="saveQR" OnClick="saveQR_Click"></asp:Button>
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
