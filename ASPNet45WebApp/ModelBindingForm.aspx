<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ModelBindingForm.aspx.cs" Inherits="ASPNet45WebApp.ModelBindingForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ModelBinding Page</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Country: <asp:DropDownList runat="server" ID="Country"
                SelectMethod="CountryDropDownList_GetCountry" AutoPostBack="true">
                <asp:ListItem Text="-Select-" />
            </asp:DropDownList>
            <asp:GridView runat="server" ID="CustomerGridView" 
                ItemType="ASPNet45WebApp.Models.Customer" DataKeyNames="CustomerID"
                SelectMethod="CustomerGridView_GetData"
                UpdateMethod="CustomerGridView_UpdateItem"

                AutoGenerateColumns="false"
                AutoGenerateEditButton ="true"
                AllowPaging="true" PageSize="10"
                >
                <Columns>
                    <asp:DynamicField DataField="CustomerID" ReadOnly="true" />
                    <asp:DynamicField DataField="CompanyName" />
                    <asp:DynamicField DataField="ContactName" />
                    <asp:DynamicField DataField="City" />
                    <asp:DynamicField DataField="Country" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
