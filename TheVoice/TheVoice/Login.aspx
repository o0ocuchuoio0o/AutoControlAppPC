<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TheVoice.Login" %>

<%@ Register Assembly="Ext.Net" Namespace="Ext.Net" TagPrefix="ext" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
      <div>
     <ext:ResourceManager ID="ResourceManager1" runat="server" />
     
     <%----------cửa sổ đăng nhập-----------%>
     <ext:Window  ID="wDangNhap" runat="server"  Icon="Lock"
            Title="Đăng nhập Hệ thống"   Width="350"   Hidden="true"
            Modal="true"                        
            Resizable="false"
            Padding="5"
            Layout="Form" AutoHeight="True" ButtonAlign="Center" Closable="False">
            <Items>
                <ext:Panel ID="pnlDangNhap" runat="server" Header="false" Border="false"  Layout="FitLayout">
                          <Content>
                           <ext:Panel ID="Panel1" runat="server" Border="false" Header="false" Layout="FormLayout" AnchorHorizontal="100%" ButtonAlign="Center">
                            <Items>                            
                             <ext:TextField ID="txtTaiKhoan" runat="server"                                         
                            FieldLabel="Tài khoản :" AllowBlank="false" BlankText="Account..." 
                            AnchorHorizontal="100%" LabelStyle="color: #000000;" />  
                             <ext:TextField ID="txtMatKhau" runat="server" InputType="Password"                                      
                            FieldLabel="Mật khẩu :" AllowBlank="false" BlankText="Pass..." 
                            AnchorHorizontal="100%" LabelStyle="color: #000000;" />  
                           
                             </Items>
                           </ext:Panel>

                           </Content>
                    </ext:Panel>
            </Items>
            <Buttons>
                <ext:Button ID="btnfDangNhap" runat="server" Text="Đăng nhập" Icon="Accept">
                   <DirectEvents>
                        <Click OnEvent="btnfDangNhap_Click">
                            <EventMask ShowMask="true" Msg="Kiểm tra Đăng nhập..."/>
                        </Click>
                    </DirectEvents>
                </ext:Button>
                <ext:Button ID="btnDangKy" runat="server" Text="Đăng ký tài khoản" Icon="Help">
                   <DirectEvents>
                        <Click OnEvent="btnDangKy_Click">
                            <EventMask ShowMask="true" Msg="Hệ thống đăng ký..."/>
                        </Click>
                    </DirectEvents>
                </ext:Button>              
            </Buttons>  
    </ext:Window>
     <%---------------------%>

     
     
     
    </div>
    </form>
</body>
</html>
