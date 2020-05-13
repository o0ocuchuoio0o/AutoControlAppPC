<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DanhSachNguoiDung.aspx.cs" Inherits="TheVoice.QuanLy.DanhSachNguoiDung" %>
<%@ Register Assembly="Ext.Net" Namespace="Ext.Net" TagPrefix="ext" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
      <div>
    <ext:ResourceManager ID="ResourceManager1" runat="server" />
    <asp:HiddenField ID="lblflag" runat="server" />
    <%----------read dữ liệu-----------%>
    <ext:Store ID="stodanhsachnguoidung" OnReadData="DanhSachNguoiDungPhanTrang" runat="server" PageSize="1000" >
            <Model>
                <ext:Model ID="Modeldanhsachdieutin" runat="server" IDProperty="ID">
                    <Fields>
                        <ext:ModelField Name="IDNguoiDung" Type="String" Mapping="IDNguoiDung" />                    
                        <ext:ModelField Name="TaiKhoan" Type="String" Mapping="TaiKhoan" />
                        <ext:ModelField Name="MatKhau" Type="String" Mapping="MatKhau" />
                        <ext:ModelField Name="NgayBatDau" Type="String" Mapping="NgayBatDau" />  
                        <ext:ModelField Name="NgayKetThuc" Type="String" Mapping="NgayKetThuc" /> 
                        <ext:ModelField Name="SoLuongUp" Type="Int" Mapping="SoLuongUp" />                                            
                    </Fields>
                </ext:Model>
            </Model>
       </ext:Store>
    <ext:GridPanel ID="grdDanhSachNguoiDung" runat="server"  ColumnWidth="1" ColumnLines="true" Height="480"
       Margins="5 5 5 5" ContextMenuID="mnudanhsachkenh" StoreID="stodanhsachnguoidung" Title="Danh sách người dùng"> 
               <TopBar>
                   <ext:Toolbar ID="Toolbar1" runat="server">
                         <Items>                      
                            <ext:Button ID="btnthemnguoidung" runat="server" Icon="ApplicationGo" IconAlign="Left" LabelStyle="color:Red;"
                               Text="Thêm kênh" Width="150" >
                                        <DirectEvents>
                                                    <Click OnEvent="btnthemnguoidung_Click">
                                                        <EventMask Msg="..." ShowMask="true" />                                                       
                                                    </Click>
                                        </DirectEvents>
                             </ext:Button>
                         </Items>
                   </ext:Toolbar>
                </TopBar>          
            <ColumnModel ID="ColumnModel1" runat="server">
                <Columns>                
                    <ext:CommandColumn ID="CMDSua" runat="server" Flex="1" Text="Sửa thông tin"  DataIndex="IDNguoiDung" Width="150" >
                                    <Commands>
                                        <ext:GridCommand Icon="EmailEdit" CommandName="Edit" />
                                    </Commands>
                                    <DirectEvents>
                                        <Command OnEvent="Cmd_SuaChiTiet" >
                                            <ExtraParams>
                                                <ext:Parameter Name="IDNguoiDung" Value="record.data.IDNguoiDung" Mode="Raw" />
                                                <ext:Parameter Name="TaiKhoan" Value="record.data.TaiKhoan" Mode="Raw" />
                                                <ext:Parameter Name="MatKhau" Value="record.data.MatKhau" Mode="Raw" />
                                                <ext:Parameter Name="NgayBatDau" Value="record.data.NgayBatDau" Mode="Raw" />
                                                <ext:Parameter Name="NgayKetThuc" Value="record.data.NgayKetThuc" Mode="Raw" />
                                                <ext:Parameter Name="SoLuongUp" Value="record.data.SoLuongUp" Mode="Raw" />
                                            </ExtraParams>
                                        </Command>
                                    </DirectEvents>
                    </ext:CommandColumn>   
                    <ext:RowNumbererColumn ID="IDNguoiDung" runat="server" Width="30" Text="STT" />
                    <ext:Column ID="TaiKhoan" runat="server" Align="Left" DataIndex="TaiKhoan" Text="Tài khoản"
                        Width="200" />
                     <ext:Column ID="MatKhau" runat="server" Align="Left" DataIndex="MatKhau" Text="Mật khẩu"
                        Width="200" />
                    <ext:Column ID="NgayBatDau" runat="server" Align="Left" DataIndex="NgayBatDau" Text="Ngày bắt đầu"
                        Width="150" />
                    <ext:Column ID="NgayKetThuc" runat="server" Align="Left" DataIndex="NgayKetThuc" Text="Ngày kết thúc"
                        Width="150" /> 
                    <ext:Column ID="SoLuongUp" runat="server" Align="Left" DataIndex="SoLuongUp" Text="Số lượng up"
                        Width="150" />                     
                    <ext:CommandColumn ID="CommandColumnXoa" runat="server" Flex="1" Text="Xóa người dùng"  DataIndex="IDNguoiDung" >
                                    <Commands>
                                        <ext:GridCommand Icon="DatabaseDelete" CommandName="delete" />
                                    </Commands>
                                    <DirectEvents>
                                        <Command OnEvent="Cmd_XoaNguoidung" >
                                            <ExtraParams>
                                                <ext:Parameter Name="IDNguoiDung" Value="record.data.IDNguoiDung" Mode="Raw" />                                              
                                            </ExtraParams>
                                        </Command>
                                    </DirectEvents>
                    </ext:CommandColumn>                       
                </Columns>
            </ColumnModel>            
            <BottomBar>
                     <ext:PagingToolbar ID="PagingToolbar1" runat="server" HideRefresh="True">
                           <Plugins>
                            <ext:ProgressBarPager ID="ProgressBarPager1" runat="server" />
                          </Plugins>
                    </ext:PagingToolbar>
           </BottomBar>

    </ext:GridPanel>
      
  
    <%----------Khai báo cửa sổ thêm,sửa thông tin kênh-----------%>
     <ext:Window ID="wThemSuaNguoiDung" runat="server" Icon="Accept" Title="Thêm,Sửa thông tin người dùng"
        Closable="false" Width="500" Height="370" Resizable="false" Padding="5" Hidden="true"
        Layout="Form" ButtonAlign="Center">
        <Items>
            <ext:Panel ID="Panel5" runat="server" Height="400" Width="500" ActiveIndex="0" DefaultBorder="false"
                DefaultPadding="5">
                <Items>
                    <ext:Panel ID="Panel6" runat="server" Header="false" Border="false">
                        <Content>     
                            <center><b>
                            <ext:Hidden ID="lblBienID" runat="server"/></b></center>                         
                             
                    <ext:FieldSet ID="FieldSetthongtinkenh" runat="server" ColumnWidth="1"
                    Title="Thông tin người dùng"  MarginSpec="0 0 0 2" 
                    ButtonAlign="Left">                    
                    <Items>                     
                       <ext:TextField ID="txtTaiKhoan" Name="TaiKhoan" runat="server" Width="250" FieldLabel="Tài khoản" LabelStyle="color:Red;" />
                       <ext:TextField ID="txtMatKhau" Name="MatKhau"  Width="250"  runat="server" FieldLabel="Mật khẩu" />
                       <ext:DateField ID="txtNgayBatDau" runat="server" EnableKeyEvents="true" FieldLabel="Ngày bắt đầu"
                           LabelWidth="65"  Format="dd/MM/yyyy" Vtype="daterange">                                                              
                       </ext:DateField>    
                        <ext:DateField ID="txtNgayKetThuc" runat="server" EnableKeyEvents="true" FieldLabel="Ngày kết thúc"
                           LabelWidth="65"  Format="dd/MM/yyyy" Vtype="daterange">                                                              
                       </ext:DateField>
                       <ext:NumberField ID="txtSoLuongUp" Name="SoLuongUp"  Width="350"  runat="server" FieldLabel="Số lượng up" /> 
                      
                    </Items>
                </ext:FieldSet>
                          
                        </Content>
                    </ext:Panel>
                </Items>
            </ext:Panel>
        </Items>
        <Buttons>
            <ext:Button ID="btnthemmoi" runat="server" Text="Thêm mới người dùng" Icon="DatabaseConnect">
                <DirectEvents>
                    <Click OnEvent="btnthemmoi_Click" IsUpload="true" >
                        <EventMask ShowMask="true" Msg="..." />
                    </Click>
                </DirectEvents>
            </ext:Button>
            <ext:Button ID="btnsuathongtinnguoidung" runat="server" Text="Sửa thông tin người dùng" Icon="DatabaseEdit">
                <DirectEvents>
                    <Click OnEvent="btnsuathongtinnguoidung_Click" IsUpload="true" >
                        <EventMask ShowMask="true" Msg="..." />
                    </Click>
                </DirectEvents>
            </ext:Button>
             <ext:Button ID="btndong" runat="server" Text="Đóng" Icon="Delete">
                <DirectEvents>
                    <Click OnEvent="btndong_Click">
                        <EventMask ShowMask="true" Msg="..." />
                    </Click>
                </DirectEvents>
            </ext:Button>
        </Buttons>
    </ext:Window>       
    </div>
    </form>
</body>
</html>
