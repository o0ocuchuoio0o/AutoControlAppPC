<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DanhSachNoiDung.aspx.cs" Inherits="TheVoice.NoiDung.DanhSachNoiDung" %>
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
            if (record.data.TrangThai == "0") {
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
       <ext:Store ID="stodanhsachtintuc" OnReadData="DanhSachTinTucPhanTrang" runat="server" PageSize="1000" >
            <Model>
                <ext:Model ID="Modeldanhsachtintuc" runat="server" IDProperty="ID">
                    <Fields>
                        <ext:ModelField Name="ID" Type="String" Mapping="ID" />                    
                        <ext:ModelField Name="NoiDung" Type="String" Mapping="NoiDung" />
                        <ext:ModelField Name="TrangThai" Type="String" Mapping="TrangThai" />
                        <ext:ModelField Name="LinkVoice" Type="String" Mapping="LinkVoice" />  
                        <ext:ModelField Name="NgonNgu" Type="String" Mapping="NgonNgu" /> 
                        <ext:ModelField Name="GioiTinh" Type="String" Mapping="GioiTinh" /> 
                    </Fields>
                </ext:Model>
            </Model>
       </ext:Store>
       <ext:GridPanel ID="grdDanhSachTinTuc" runat="server" ColumnLines="true" Height="480"
       Margins="5 5 5 5" ContextMenuID="mnudanhsachkenh" StoreID="stodanhsachtintuc" Title="Danh sách bài viết"> 
               <TopBar>
                   <ext:Toolbar ID="Toolbar1" runat="server">
                         <Items>              
                          <ext:DateField ID="txtngay" runat="server" EnableKeyEvents="true" FieldLabel="Ngày"
                           LabelWidth="65"  Format="dd/MM/yyyy" Vtype="daterange">                                                                     
                         </ext:DateField>    
                         <ext:Button ID="btnhienthi" runat="server" Icon="ApplicationGo" IconAlign="Left" LabelStyle="color:Red;"
                               Text="Hiển thị" Width="150" >
                                        <DirectEvents>
                                                    <Click OnEvent="btnhienthi_Click">
                                                        <EventMask Msg="..." ShowMask="true" />                                                       
                                                    </Click>
                                        </DirectEvents>
                             </ext:Button>
                          
                         </Items>
                   </ext:Toolbar>
                </TopBar>          
            <ColumnModel ID="ColumnModel1" runat="server">
                <Columns>               
                    <ext:RowNumbererColumn ID="ID" runat="server" Width="70" Text="STT" />                   
                     <ext:CommandColumn ID="cmblayfilevoice" runat="server" Width="30" Text="File voice"  DataIndex="LinkVoice" >
                                    <Commands>
                                           <ext:GridCommand Icon="FilmSave" CommandName="connect" />
                                    </Commands>
                                    <DirectEvents>
                                        <Command OnEvent="cmblayfilevoice_Down" IsUpload="true" >
                                            <ExtraParams>
                                                <ext:Parameter Name="LinkVoice" Value="record.data.LinkVoice" Mode="Raw" />                                              
                                            </ExtraParams>
                                        </Command>
                                    </DirectEvents>
                    </ext:CommandColumn>  
                    <ext:Column ID="NoiDung" runat="server" Align="Left" DataIndex="NoiDung" Text="Nội dung"
                        Width="250" /> 
                    <ext:Column ID="TrangThai" runat="server" Align="Left" DataIndex="TrangThai" Text="Trạng thái"
                        Width="70" />
                    <ext:Column ID="NgonNgu" runat="server" Align="Left" DataIndex="NgonNgu" Text="Ngôn ngữ"
                        Width="150" />   
                    <ext:Column ID="GioiTinh" runat="server" Align="Left" DataIndex="GioiTinh" Text="Giới tính"
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
