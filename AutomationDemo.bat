@ECHO OFF
ECHO Demo Automation Execution Started.

set testcategory=SignIn
set dllpath=D:\OneDrive - Constellation HomeBuilder Systems\Automation\AutomationDemo\bin\Debug\AutomationDemo.dll
set trxerpath=D:\OneDrive - Constellation HomeBuilder Systems\Automation\AutomationDemo\bin\Debug
set reportpath=D:\OneDrive - Constellation HomeBuilder Systems\Automation\AutomationDemo\Reporting
set vsCmdRunner=C:\Program Files\Microsoft Visual Studio\2022\Community\Common7\Tools\VsDevCmd.bat

call "%vsCmdRunner%"
VSTest.Console.exe "%dllpath%" /TestCaseFilter:"TestCategory=%testcategory%" /Logger:"trx;LogFileName=%reportpath%\Test1.trx"

cd "%trxerpath%"
TrxerConsole.exe "%reportpath%"\Test1.trx

PAUSE