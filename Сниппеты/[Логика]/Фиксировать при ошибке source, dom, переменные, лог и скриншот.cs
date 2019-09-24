//фиксируем ошибку в подкаталоге с уникальным именем
//сохраняем скриншот, дом, сурс страницы и переменные с их значениями

string dt_tm = "Error_"+DateTime.Now.ToString("yyyy_MM_dd__HH_mm_ss__")+Environment.TickCount.ToString();

//Директория ошибок и создание если отсутствует
string errorpath = Path.Combine(project.Directory,"Errors");
if (!Directory.Exists(errorpath)){
	Directory.CreateDirectory(errorpath);
}

//директория конкретной ошибки и создание если отсутствует
string cur_errorpath = Path.Combine(errorpath,dt_tm);
if (!Directory.Exists(cur_errorpath)){
	Directory.CreateDirectory(cur_errorpath);
}

string path_screenshot = Path.Combine(cur_errorpath,"ScreenShot.jpeg");
string path_dom = Path.Combine(cur_errorpath,"dom.txt");
string path_source = Path.Combine(cur_errorpath,"source.txt");
string path_vars = Path.Combine(cur_errorpath,"vars.txt");
string path_log = Path.Combine(cur_errorpath,"log.txt");

//скриншот
ZennoPoster.ImageProcessingUntreatedFromScreenshot(instance.Port, path_screenshot);
//DOM
File.WriteAllText(path_dom,instance.ActiveTab.DomText,Encoding.UTF8);
//Source
File.WriteAllText(path_source,instance.ActiveTab.GetSourceText("UTF8"),Encoding.UTF8);

//vars
var sb = new StringBuilder();
foreach(var variable in project.Variables.Keys){    
	sb.AppendFormat("Name: {0} Value: {1}\r\n", variable, project.Variables[variable].Value);
}

File.WriteAllText(path_vars,sb.ToString(),Encoding.UTF8);

//данные об ошибке
var sbl = new StringBuilder();
LastError le = project.GetLastError();
if (le!=null)
{
  	sbl.AppendLine("Error ID: "+le.ActionId);
  	sbl.AppendLine("Error comment: "+le.ActionComment);
  	sbl.AppendLine("Error Message: "+le.Exception.Message);
	sbl.AppendLine("Error Source: "+le.Exception.Source);
}

File.WriteAllText(path_log,sbl.ToString(),Encoding.UTF8);

project.SendWarningToLog("Данные по ошибке сохранены в каталоге "+cur_errorpath,true);
 