<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="WebCrudOperations.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

</head>
<body>
    <form id="form1" runat="server">
        <div>
 <asp:GridView ID="GridShow" runat="server" AutoGenerateColumns="False" OnRowCancelingEdit="cancel" OnRowDeleting="Delete" OnRowEditing="Edit" OnRowUpdating="Updated">
      <Columns>
                    <asp:BoundField DataField="id" HeaderText="İD" />
                    <asp:BoundField DataField="CompanyName" HeaderText="Şirkət Adı" />
                    <asp:BoundField DataField="ContactName" HeaderText="Ad-Soyad" />
                    <asp:BoundField DataField="ContactTitle" HeaderText="Pozisiya" />
                    <asp:BoundField DataField="Adress" HeaderText="Ünvan" />
                    <asp:BoundField DataField="City" HeaderText="Şəhər" />
                    <asp:CommandField ShowEditButton="true" ButtonType="Button" >
                    <ControlStyle BackColor="Green" />
                    </asp:CommandField>
                    <asp:CommandField ShowDeleteButton="true" ButtonType="Button" >
                    <ControlStyle BackColor="Red" />
                    </asp:CommandField>
                </Columns>
 </asp:GridView>
        </div>
    </form>
</body>
</html>
