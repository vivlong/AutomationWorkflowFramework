
#define MyAppName "AutomationWorkflowFramework"
#define MyAppVersion "1.0.0.42"
#define MyAppPublisher "SDOT"
#define MyAppURL "http://www.sysfreight.net"
#define MyAppExeName "SAWF.exe"

[Setup]
; 注: AppId的值为单独标识该应用程序。
; 不要为其他安装程序使用相同的AppId值。
; (生成新的GUID，点击 工具|在IDE中生成GUID。)
AppId={{7C261B6E-1C0E-4B7B-9A4E-5A456F6BCEDF}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={pf}\{#MyAppName}
DefaultGroupName={#MyAppName}
AllowNoIcons=yes
LicenseFile=F:\projects\AutomationWorkflowFramework\License.txt
OutputDir=C:\Users\Administrator\Desktop
OutputBaseFilename=AWF
SetupIconFile=F:\projects\AutomationWorkflowFramework\install.ico
Compression=lzma
SolidCompression=yes

[Languages]
Name: "chinesesimp"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked; OnlyBelowVersion: 0,6.1
Name: "quicklaunchicon"; Description: "{cm:CreateQuickLaunchIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "F:\projects\AutomationWorkflowFramework\AWF\bin\Debug\SAWF.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\projects\AutomationWorkflowFramework\AWF\bin\Debug\SAWF.exe.config"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\projects\AutomationWorkflowFramework\AWF\bin\Debug\SAWF.exe.l4n"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\projects\AutomationWorkflowFramework\AWF\bin\Debug\SAWF.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\projects\AutomationWorkflowFramework\AWF\bin\Debug\build.bat"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\projects\AutomationWorkflowFramework\AWF\bin\Debug\DevComponents.DotNetBar2.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\projects\AutomationWorkflowFramework\AWF\bin\Debug\ICSharpCode.SharpZipLib.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\projects\AutomationWorkflowFramework\AWF\bin\Debug\log4net.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\projects\AutomationWorkflowFramework\AWF\bin\Debug\NPOI.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\projects\AutomationWorkflowFramework\AWF\bin\Debug\Microsoft.SqlServer.ConnectionInfo.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\projects\AutomationWorkflowFramework\AWF\bin\Debug\Microsoft.SqlServer.Dmf.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\projects\AutomationWorkflowFramework\AWF\bin\Debug\Microsoft.SqlServer.Management.Sdk.Sfc.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\projects\AutomationWorkflowFramework\AWF\bin\Debug\Microsoft.SqlServer.RegSvrEnum.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\projects\AutomationWorkflowFramework\AWF\bin\Debug\Microsoft.SqlServer.ServiceBrokerEnum.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\projects\AutomationWorkflowFramework\AWF\bin\Debug\Microsoft.SqlServer.Smo.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\projects\AutomationWorkflowFramework\AWF\bin\Debug\Microsoft.SqlServer.SmoExtended.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\projects\AutomationWorkflowFramework\AWF\bin\Debug\Microsoft.SqlServer.SqlClrProvider.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\projects\AutomationWorkflowFramework\AWF\bin\Debug\Microsoft.SqlServer.SqlEnum.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\projects\AutomationWorkflowFramework\AWF\bin\Debug\Newtonsoft.Json.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\projects\AutomationWorkflowFramework\AWF\bin\Debug\Newtonsoft.Json.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\projects\AutomationWorkflowFramework\AWF\bin\Debug\Newtonsoft.Json.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\projects\AutomationWorkflowFramework\AWF\bin\Debug\publish.bat"; DestDir: "{app}"; Flags: ignoreversion
; 注意: 不要在任何共享系统文件上使用“Flags: ignoreversion”

[Icons]
Name: "{group}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{group}\{cm:UninstallProgram,{#MyAppName}}"; Filename: "{uninstallexe}"
Name: "{commondesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon
Name: "{userappdata}\Microsoft\Internet Explorer\Quick Launch\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: quicklaunchicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent

