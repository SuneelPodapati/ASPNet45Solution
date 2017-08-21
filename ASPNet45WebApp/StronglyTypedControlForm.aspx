<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StronglyTypedControlForm.aspx.cs" Inherits="ASPNet45WebApp.StronglyTypedControlForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Strongly Typed Data Control</h1>
        <div>
            <asp:Repeater runat="server" ID="CustRepeater" ItemType="ASPNet45WebApp.Models.Customer">
                <ItemTemplate>
                    <table border="1" style="width:30%">
                        <tr>
                            <td>
                                <ul>
                                    <li>CustomerID: <%# Eval("CustomerID") %> </li>
                                    <li>CompanyName: <%# Eval("CompanyName") %> </li>
                                    <li>ContactName: <%# Item.ContactName %> </li>
                                    <li>City: <%# Item.City %> </li>
                                    <li>Country: <%# Item.Country %> </li>
                                </ul>
                            </td>
                        </tr>
                    </table>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </form>
</body>
</html>
