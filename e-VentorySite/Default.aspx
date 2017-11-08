<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>e-Ventory | HOME</title>
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
        .mySlides {display:none}

/* Slideshow container */
        .slideshow-container {
            max-width: 1000px;
            position: relative;
            margin: auto;
        }

/* Caption text */
        .text {
            color: #f2f2f2;
            font-size: 15px;
            padding: 8px 12px;
            position: absolute;
            bottom: 8px;
            width: 100%;
            text-align: center;
        }

/* Number text (1/3 etc) */
         .numbertext {
            color: #f2f2f2;
            font-size: 12px;
            padding: 8px 12px;
            position: absolute;
            top: 0;
        }

/* The dots/bullets/indicators */
         .dot {
            height: 13px;
            width: 13px;
            margin: 0 2px;
            background-color: #bbb;
            border-radius: 50%;
            display: inline-block;
            transition: background-color 0.6s ease;
        }

        .active {
            background-color: #717171;
        }

/* Fading animation */
        .fade {
            -webkit-animation-name: fade;
            -webkit-animation-duration: 1.5s;
            animation-name: fade;
            animation-duration: 1.5s;
        }

        @-webkit-keyframes fade {
            from {opacity: .4} 
            to {opacity: 1}
        }

        @keyframes fade {
            from {opacity: .4} 
            to {opacity: 1}
        }       

        .header2{
            text-align:center;
            font-family:'Century Gothic';
            color: #2D3E50;
        }

        .footer{
            margin-left: 920px;
            font-family:'Century Gothic';
            color:#2D3E50;
            font-size:medium;
        }

        .header1{
            text-align:center;
            font-family:'Century Gothic';
            color: #2D3E50;
            margin-left: 62px;
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

    <div class="slideshow-container">

<div class="mySlides fade" style ="text-align:center">
  <div class="numbertext"></div>
  <img src="..\..\Images/Banner 1.jpg" style="width:100%"/>
</div>

<div class="mySlides fade" style ="text-align:center">
  <div class="numbertext"></div>
    <img src="..\..\Images\Banner 2.jpg" style="width: 100%"/>
</div>


<div class="mySlides fade" style ="text-align:center">
  <div class="numbertext"></div>
  <img src="..\..\Images\Banner 3.jpg" style="width:100%"/>
</div>
</div>
<br/>

<div style="text-align:center">
  <span class="dot"></span> 
  <span class="dot"></span> 
  <span class="dot"></span>
</div>
        <div class ="header2">
            <h1>___________________________________________________________________________</h1>
        </div>

        <div class ="header1">
            <h1>e-Ventory Application</h1>
        </div>
        <table class ="function">
                <tr>
                    <td>
                        <img src="..\Images\Function 1.png" alt="function 1" style="width:220px;height:220px;margin-left:100px" />
                    </td>

                    <td>
                        <img src="..\Images\Function 2.png" alt="function 2" style="width:220px;height:220px;margin-left:80px" />
                    </td>

                    <td>
                        <img src="..\Images\Function 3.png" alt="function 3" style="width:220px;height:220px;margin-left:80px" />
                    </td>

                    <td>
                        <img src="..\Images\Function 4.png" alt="function 4" style="width:220px;height:220px;margin-left:80px" />
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
<script>
var slideIndex = 0;
showSlides();

function showSlides() {
    var i;
    var slides = document.getElementsByClassName("mySlides");
    var dots = document.getElementsByClassName("dot");
    for (i = 0; i < slides.length; i++) {
       slides[i].style.display = "none";  
    }
    slideIndex++;
    if (slideIndex > slides.length) {slideIndex = 1}    
    for (i = 0; i < dots.length; i++) {
        dots[i].className = dots[i].className.replace(" active", "");
    }
    slides[slideIndex-1].style.display = "block";  
    dots[slideIndex-1].className += " active";
    setTimeout(showSlides, 5000); // Change image every 2 seconds
}
</script>
    </form>
</body>
</html>
