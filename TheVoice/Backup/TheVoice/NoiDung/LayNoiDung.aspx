<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LayNoiDung.aspx.cs" Inherits="TheVoice.NoiDung.LayNoiDung" %>
<%@ Register Assembly="Ext.Net" Namespace="Ext.Net" TagPrefix="ext" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
         <asp:HiddenField ID="lblNguoiDung" runat="server" />
         <ext:ResourceManager ID="ResourceManager1" runat="server" />
         <ext:FormPanel ID="FormPanel1" runat="server"  Width="975" BodyPadding="2" Layout="ColumnLayout">        
             <Items>                    
                    <ext:ComboBox ID="cmbngonngu" runat="server" AllowBlank="false" DisplayField="NgonNgu" Width="350"
                            FieldLabel="Chọn ngôn ngữ:"  EmptyText="Chọn ngôn ngữ..." ForceSelection="true" QueryMode="Local"
                            Style="text-align: left" TriggerAction="All" TypeAhead="true" ValueField="NgonNgu"  >
                            <Store>
                                <ext:Store ID="Storengonngu" runat="server">
                                    <Model>
                                        <ext:Model ID="Modellinkwebsite" runat="server" IDProperty="NgonNgu">
                                            <Fields>  
                                                 <ext:ModelField Mapping="NgonNgu" Name="NgonNgu" Type="String" />
                                            </Fields>
                                        </ext:Model>
                                    </Model>
                                </ext:Store>
                            </Store>        
                    </ext:ComboBox>   
                    <ext:ComboBox ID="cmbgioitinh" runat="server" AllowBlank="false" DisplayField="GioiTinh" Width="350"
                            FieldLabel="Chọn giới tính:"  EmptyText="Chọn giới tính..." ForceSelection="true" QueryMode="Local"
                            Style="text-align: left" TriggerAction="All" TypeAhead="true" ValueField="GioiTinh"  >
                            <Store>
                                <ext:Store ID="Storegioitinh" runat="server">
                                    <Model>
                                        <ext:Model ID="Model1" runat="server" IDProperty="GioiTinh">
                                            <Fields>  
                                                 <ext:ModelField Mapping="GioiTinh" Name="GioiTinh" Type="String" />
                                            </Fields>
                                        </ext:Model>
                                    </Model>
                                </ext:Store>
                            </Store>        
                    </ext:ComboBox>                   
                   <ext:TextArea ID="txtNoiDung" Name="NoiDung" Width="700" Height="400" runat="server" FieldLabel="Nội dung" LabelStyle="color:Red;" />
                  
             </Items>   
              <Buttons>
                <ext:Button ID="btnThemBaiViet" runat="server" Text="Thêm bài viết" Icon="DiskUpload" >
                            <DirectEvents>
                                <Click OnEvent="btnThemBaiViet_Click" IsUpload="true">
                                    <EventMask ShowMask="true" Msg="..." />
                                </Click>
                            </DirectEvents>
                </ext:Button>
               
            </Buttons>  
         </ext:FormPanel>
    </div>
    </form>
</body>
</html>
