<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Mindteck.aspx.cs" Inherits="Myfirstweb.Mindteck" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
              <table align="center">
               <caption bgcolor="Red">Customer Details<asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
               </caption>
               <tr>
                   <td>Name:</td>
                   <td> <asp:TextBox ID="textName" runat="server"></asp:TextBox></td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1"
                            runat="server"  ControlToValidate="textName" ErrorMessage ="Enter name"></asp:RequiredFieldValidator>
                   </td>
                    
                   
               </tr>
                <tr>
                   <td>Adress:</td>
                   <td> <asp:TextBox ID="textAdress" runat="server"></asp:TextBox></td>
                     <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2"
                            runat="server"  ControlToValidate="textAdress" ErrorMessage ="Enter Valid Adress"></asp:RequiredFieldValidator>
                   </td>
                    
               </tr>
                 <tr>
                   <td>Price Date:</td>
                   <td> <asp:TextBox ID="textPriceDate" runat="server"></asp:TextBox></td>
                      <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3"
                            runat="server"  ControlToValidate="textPriceDate" ErrorMessage ="Enter Valid Price"></asp:RequiredFieldValidator>
                   </td>
                     
                     
               </tr>
                <tr>
                    <td>Brand Nmae</td>
                   <td> <asp:TextBox ID="textBrandName" runat="server"></asp:TextBox></td>
                     <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4"
                            runat="server"  ControlToValidate="textBrandName" ErrorMessage ="Enter Valid Brand Name"></asp:RequiredFieldValidator>
                   </td>
                  
                   
               </tr>
                 <tr>
                     <td>State:</td>
                     <td><asp:DropDownList ID="textstate" runat="server">
                         <asp:ListItem>Andhra Pradesh</asp:ListItem>
                         <asp:ListItem>Arunachal Pradesh</asp:ListItem>
                         <asp:ListItem>West Bengal</asp:ListItem>
                         <asp:ListItem>Karnataka</asp:ListItem>
                         </asp:DropDownList></td>
                    
                 </tr>
                  <tr>
        <td>
            Gender:
        </td>
        <td>
            <asp:RadioButton ID="rbMale" Text="Male" runat="server" GroupName="Gender" />
            <asp:RadioButton ID="rbFemale" Text="Female" runat="server" GroupName="Gender" />
        </td>
    </tr>
                   <tr>
                       <td>Status:</td>
                       <td>
                           <asp:CheckBox ID="CheckBox1" runat="server" Text="Active" />
                           <asp:CheckBox ID="CheckBox2" runat="server" Text="Inactive" />
                       </td>
                           
                           
                   <tr>
                       <td>Time:</td>
                       <td>
                           <asp:TextBox ID="texttime" runat="server"></asp:TextBox>

                       </td>
                         
                   </tr>
                   <tr>
                       <td></td>
                       <td>
                           <asp:Button ID="btnsv" runat="server" Text="Save" OnClick="btnsv_Click" /></td>
                   </tr>
               
           </table>
        </div>
    </form>
</body>
</html>
