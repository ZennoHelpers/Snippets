//Если нужна долгая пауза с возможностью прервать её через Стоп в PM или "Прервать" в ZP
int wait_sec = 5;
int wait_ms = wait_sec * 1000;

while (wait_ms>500)
{
  if(((ZennoLab.InterfacesLibrary.ProjectModel.Collections.IContextExt)project.Context).IsInterrupted) throw new Exception("Прерывание в ZP");
  if(Global.Variables.IsProjectMaker && !Global.Variables.IsDebugMode) throw new Exception("Прерывание в PM");
  Thread.Sleep(500);	
  wait_ms = wait_ms - 500;
}