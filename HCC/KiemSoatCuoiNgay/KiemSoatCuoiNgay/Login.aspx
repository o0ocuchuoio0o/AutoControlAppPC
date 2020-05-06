<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="KiemSoatCuoiNgay.Login" %>

<%@ Register Assembly="Ext.Net" Namespace="Ext.Net" TagPrefix="ext" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Hệ thống kiểm soát cuối ngày BCCP</title>    
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
                             <ext:TextField ID="txtMaBuuCuc" runat="server"                                         
                            FieldLabel="Mã bưu cục :" AllowBlank="false" BlankText="mã bưu cục..." 
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
            </Buttons>  
    </ext:Window>
     <%---------------------%>

     
     
     
    </div>
    </form>
</body>
</html>
