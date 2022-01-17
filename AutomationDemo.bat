@ECHO OFF
ECHO Demo Automation Execution Started.

set testCategory1=SignIn
set testCategory2=SignInTwo
set dllpath=D:\OneDrive - Constellation HomeBuilder Systems\Automation\AutomationDemo\bin\Debug\AutomationDemo.dll
set trxerpath=D:\OneDrive - Constellation HomeBuilder Systems\Automation\AutomationDemo\bin\Debug
set reportpath=D:\OneDrive - Constellation HomeBuilder Systems\Automation\AutomationDemo\Reporting
set vsCmdRunner=C:\Program Files\Microsoft Visual Studio\2022\Community\Common7\Tools\VsDevCmd.bat
set trxerConsolePath=D:\OneDrive - Constellation HomeBuilder Systems\Automation\AutomationDemo\bin\Debug\TrxerConsole.exe

call "%vsCmdRunner%"
VSTest.Console.exe "%dllpath%" /TestCaseFilter:"(TestCategory=%testcategory1% | TestCategory=%testcategory2%)" /Logger:"trx;LogFileName=%reportpath%\Test2"

cd "%trxerpath%"
"%trxerConsolePath%" "%reportpath%"\Test2

PAUSE
