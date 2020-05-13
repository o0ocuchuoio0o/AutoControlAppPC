<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TheVoice.Default" %>
<%@ Register Assembly="Ext.Net" Namespace="Ext.Net" TagPrefix="ext" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
     <title>Hệ thống lấy voice </title>
     <link rel="SHORTCUT ICON" href="Resuorces/icons/reward.ico"/>  
      <link href="Resuorces/css/main.css" rel="stylesheet" type="text/css" />
      <script type="text/javascript">
          var addTab123 = function (id, url, TieuDe) {
              var tab = App.TabPanelChinh.getComponent(id);

              if (!tab) {
                  tab = App.TabPanelChinh.add(new Ext.Panel({
                      id: id,
                      title: TieuDe,
                      closable: true,
                      autoLoad: {
                          url: url,
                          showMask: true,
                          maskMsg: "Nạp ứng dụng..."
                      }
                  }));
              }

              App.TabPanelChinh.setActiveTab(tab);
          };
          var DangXuat_Click = function (item) {
              location.href = "Login.aspx";
          };
          var DatLaiDoCao = function () {
              var myWidth = 0, myHeight = 0;
              if (typeof (window.innerWidth) == 'number') {
                  //Non-IE
                  myWidth = window.innerWidth;
                  myHeight = window.innerHeight;
              } else if (document.documentElement && (document.documentElement.clientWidth || document.documentElement.clientHeight)) {
                  //IE 6+ in 'standards compliant mode'
                  myWidth = document.documentElement.clientWidth;
                  myHeight = document.documentElement.clientHeight;
              } else if (document.body && (document.body.clientWidth || document.body.clientHeight)) {
                  //IE 4 compatible
                  myWidth = document.body.clientWidth;
                  myHeight = document.body.clientHeight;
              }

              App.TabPanelChinh.Height = myHeight - 70;
          };
    </script> 
</head>
<body>
    <form id="form1" runat="server">
    <div>
       <ext:ResourceManager ID="ResourceManager1" runat="server" />     
    <ext:viewport runat="server" ID="vchinh">                
        <Items>
            <ext:Panel ID="Panel1" 
				runat="server" 
				Header="false"
				Region="North"
				Border="false"
				Height="69">
				<Content>
					<div id="titlebar">
						<div id="left">
							<div class="minor">Hệ thống lấy voice</div>
							<div class="title"></div>							
						</div>
					</div>
				</Content>    
			</ext:Panel>
            <ext:Toolbar ID="ToolbarMenu" runat="server">   
                   <Items>
                       
                    </Items>                 
             </ext:Toolbar>
            <ext:TabPanel ID="TabPanelChinh" 
                runat="server" 
                Region="Center"
                Weight="0">
                 <Items>                                              
                </Items>
               <BottomBar>
                <ext:StatusBar ID="StatusBar4" CtCls="word-status" runat="server" DefaultText="Bình thường">
                    <Items>
                        <ext:ToolbarTextItem ID="clock" runat="server" Text=" " CtCls="x-status-text-panel" />
                    </Items>
                </ext:StatusBar>
            </BottomBar>       
             </ext:TabPanel>
        </Items>
    </ext:viewport>

    <ext:TaskManager ID="TaskManager1" runat="server">
            <Tasks>
                <ext:Task AutoRun="true" Interval="1000">
                    <Listeners>
                        <Update Handler="#{clock}.setText(Ext.Date.format(new Date(), 'g:i:s A - d/m/Y'));" />
                    </Listeners>
                </ext:Task>
            </Tasks>
        </ext:TaskManager>
    </div>
    </form>
</body>
</html>