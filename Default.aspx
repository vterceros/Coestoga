<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication2._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

<h1></h1>
<hr/>
<h2></h2>

    <table class='output' border='1'>
    <tr>
        <th>Store Name</th>
        <th>City</th>
        <th>Country</th>
        <th>Email Address</th>
        <th>Invoice Date</th>
        <th>Item Description</th>
        <th>Category</th>
        <th>Price USD</th>
    </tr>

<%
    using (WebApplication2.Model.MIModel context = new WebApplication2.Model.MIModel())
    {
        var items = context.StorePurchasesView.ToList();

        foreach (var item in items)
        {

%>    
        <tr>
            <td> <% = item.StoreName  %>  </td>
            <td> <% = item.City %>  </td>
            <td> <% = item.Country  %>  </td>
            <td> <% = item.EmailAddress %>  </td>
            <td> <% = item.InvoiceDate  %>  </td>
            <td> <% = item.ItemDescription  %>  </td>
            <td> <% = item.Category %>  </td>
            <td> <% = item.UnitPriceUSD %>  </td>
        </tr>
<% 
        }
    }
%>


</table>

<br/><hr/>

<p class="footer"><ahref="../MI/index.html">Return to the Morgan Importing Home Page</a></p>
<hr/>    

</asp:Content>
