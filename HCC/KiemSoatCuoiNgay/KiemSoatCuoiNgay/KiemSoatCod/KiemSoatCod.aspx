<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="KiemSoatCod.aspx.cs" Inherits="KiemSoatCuoiNgay.KiemSoatCod.KiemSoatCod" %>
<%@ Register Assembly="Ext.Net" Namespace="Ext.Net" TagPrefix="ext" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
        <style type="text/css">
      .x-grid-body .x-grid-cell-Cost
        {
            background-color: #f1f2f4;
        }
        
        .x-grid-row-summary .x-grid-cell-Cost .x-grid-cell-inner
        {
            background-color: #e1e2e4;
        }
        
        .task .x-grid-cell-inner
        {
            padding-left: 15px;
        }
        
        .x-grid-row-summary .x-grid-cell-inner
        {
            font-weight: bold;
            font-size: 11px;
            background-color: #f1f2f4;
        }
        .x-grid-row-over .x-grid-cell-inner
        {
            font-weight: bold;
        }
        .x-column-header-inner .x-column-header-text
        {
            white-space: normal;
        }
        .completeInAn-row .x-grid-cell,.dirty-row .x-grid-rowwrap-div{
	      background-color: Lime !important;
	      
	      }	 
    </style>
  
    <script type="text/javascript" >
        var getRowClass = function (record) {
            if (record.data.Status == "1") {
                return "completeInAn-row";
            }
        };
        var onShow = function (toolTip, grid) {
            var view = grid.getView(),
                store = grid.getStore(),
                record = view.getRecord(view.findItemByChild(toolTip.triggerElement)),
                column = view.getHeaderByCell(toolTip.triggerElement),
                data = record.get(column.dataIndex);

            toolTip.update(data);
        };
        
    </script>
 
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <ext:ResourceManager ID="ResourceManager1" runat="server" />
    <asp:HiddenField ID="lblflag" runat="server" />
    <%----------read dữ liệu-----------%>
       <ext:Store ID="stodanhsach" OnReadData="DanhSachPhanTrang" runat="server" PageSize="1000" >
            <Model>
                <ext:Model ID="Modeldanhsach" runat="server" IDProperty="ID">
                    <Fields>
                        <ext:ModelField Name="ID" Type="Int" Mapping="ID" />                    
                        <ext:ModelField Name="Mail" Type="String" Mapping="Mail" />
                        <ext:ModelField Name="DiaChiVPS" Type="String" Mapping="DiaChiVPS" />
                        <ext:ModelField Name="TieuDe" Type="String" Mapping="TieuDe" />  
                        <ext:ModelField Name="NgayTao" Type="String" Mapping="NgayTao" /> 
                        <ext:ModelField Name="NoiDung" Type="String" Mapping="NoiDung" />    
                        <ext:ModelField Name="HinhAnh" Type="String" Mapping="HinhAnh" />    
                        <ext:ModelField Name="Tag" Type="String" Mapping="Tag" />
                        <ext:ModelField Name="LinkBaiViet" Type="String" Mapping="LinkBaiViet" />    
                        <ext:ModelField Name="LinkBaiViet" Type="String" Mapping="LinkBaiViet" />   
                        <ext:ModelField Name="Status" Type="String" Mapping="Status" />   
                                                          
                    </Fields>
                </ext:Model>
            </Model>
       </ext:Store>
       <ext:GridPanel ID="grdDanhSachTinTuc" runat="server" ColumnLines="true" Height="480"
       Margins="5 5 5 5" ContextMenuID="mnudanhsachkenh" StoreID="stodanhsachtintuc" Title="Danh sách tin tức"> 
               <TopBar>
                   <ext:Toolbar ID="Toolbar1" runat="server">
                         <Items>              
                          <ext:DateField ID="txtngay" runat="server" EnableKeyEvents="true" FieldLabel="Ngày"
                           LabelWidth="65"  Format="dd/MM/yyyy" Vtype="daterange"> 
                             <Listeners>
                                        <Change Handler="#{stodanhsachtintuc}.reload();"/>
                            </Listeners>                                             
                         </ext:DateField>    
                          <ext:ComboBox ID="cmbkenh" runat="server"  EmptyText="Chọn kênh..."   ForceSelection="true"
                            QueryMode="Local" TriggerAction="All" Width="130"  DisplayField="Mail" ValueField="ID" TypeAhead="true" >
                            <Store>
                                <ext:Store runat="server" ID="storedskenh">
                                    <Model>
                                        <ext:Model ID="Modeltrangthai" runat="server" IDProperty="ID">
                                            <Fields>
                                                <ext:ModelField Name="ID" Type="Int" Mapping="ID" />
                                                <ext:ModelField Name="Mail" Type="String" Mapping="Mail" />
                                            </Fields>
                                        </ext:Model>
                                    </Model>
                                </ext:Store>
                            </Store>
                                <Listeners>
                                            <Select Handler="#{stodanhsachtintuc}.reload();"/>
                                </Listeners> 
                        </ext:ComboBox>    
                          <ext:Radio ID="Radiochuarender" runat="server" BoxLabel="Chưa render" InputValue="ChuaRender" Name="fav-color" />
                          <ext:Radio ID="Radiodangrender" runat="server" BoxLabel="Đang render" InputValue="DangRender" Name="fav-color" />
                          <ext:Radio ID="Radiochuaup" runat="server" BoxLabel="Đã render chờ up" InputValue="ChuaUp" Name="fav-color" />
                          <ext:Radio ID="Radiodaup" runat="server" BoxLabel="Đã up" InputValue="DaUp" Name="fav-color" />
                            <ext:Button ID="btnhienthi" runat="server" Icon="ApplicationGo" IconAlign="Left" LabelStyle="color:Red;"
                               Text="Hiển thị" Width="150" >
                                        <DirectEvents>
                                                    <Click OnEvent="btnhienthi_Click">
                                                        <EventMask Msg="..." ShowMask="true" />                                                       
                                                    </Click>
                                        </DirectEvents>
                             </ext:Button>
                           <ext:Button ID="btnXoaDuLieuDaUp" runat="server" Icon="ApplicationGo" IconAlign="Left" LabelStyle="color:Red;"
                               Text="Xóa dữ liệu đã up" Width="150" >
                                        <DirectEvents>
                                                    <Click OnEvent="btnXoaDuLieuDaUp_Click">
                                                        <EventMask Msg="..." ShowMask="true" />                                                       
                                                    </Click>
                                        </DirectEvents>
                             </ext:Button>
                              <ext:Button ID="btnXoaVoiceDaRender" runat="server" Icon="ApplicationGo" IconAlign="Left" LabelStyle="color:Red;"
                               Text="Xóa voice đã render" Width="150" >
                                        <DirectEvents>
                                                    <Click OnEvent="btnXoaVoiceDaRender_Click">
                                                        <EventMask Msg="..." ShowMask="true" />                                                       
                                                    </Click>
                                        </DirectEvents>
                             </ext:Button>
                         </Items>
                   </ext:Toolbar>
                </TopBar>          
            <ColumnModel ID="ColumnModel1" runat="server">
                <Columns>               
                    <ext:RowNumbererColumn ID="ID" runat="server" Width="30" Text="STT" />                   
                    <ext:Column ID="Mail" runat="server" Align="Left" DataIndex="Mail" Text="Mail"
                        Width="200" />
                     <ext:Column ID="DiaChiVPS" runat="server" Align="Left" DataIndex="DiaChiVPS" Text="Địa chỉ VPS"
                        Width="100" />
                    <ext:Column ID="TieuDe" runat="server" Align="Left" DataIndex="TieuDe" Text="Tiêu đề"
                        Width="200" />
                    <ext:Column ID="NoiDung" runat="server" Align="Left" DataIndex="NoiDung" Text="Nội dung"
                        Width="150" /> 
                    <ext:Column ID="HinhAnh" runat="server" Align="Left" DataIndex="HinhAnh" Text="Hình ảnh"
                        Width="150" />  
                    <ext:Column ID="Tag" runat="server" Align="Left" DataIndex="Tag" Text="Tag"
                        Width="300" />   
                    <ext:Column ID="NgayTao" runat="server" Align="Left" DataIndex="NgayTao" Text="Ngày tạo"
                        Width="300" />    
                    <ext:Column ID="LinkBaiViet" runat="server" Align="Left" DataIndex="LinkBaiViet" Text="Link bài viết"
                        Width="150" />   
                  
                                                 
                </Columns>
            </ColumnModel>
            <SelectionModel>
                            <ext:RowSelectionModel ID="RowSelectionModel1" runat="server">
                            </ext:RowSelectionModel>
            </SelectionModel>
            <BottomBar>
                     <ext:PagingToolbar ID="PagingToolbar1" runat="server" HideRefresh="True">
                           <Plugins>
                            <ext:ProgressBarPager ID="ProgressBarPager1" runat="server" />
                          </Plugins>
                    </ext:PagingToolbar>
           </BottomBar>
    </ext:GridPanel>
    </div>
    </form>
</body>
</html>
