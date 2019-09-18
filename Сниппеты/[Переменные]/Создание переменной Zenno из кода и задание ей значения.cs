string vParamName = "NewVar";
string vParamValue = "VarData";
//проверяем существование переменной, если нет то создаем новую
if (project.Variables.Keys.Contains(vParamName)){
	project.SendInfoToLog("Переменная "+vParamName+" уже существует - присваиваем ей значение");					
	project.Variables[vParamName].Value = vParamValue;
} else {
	project.SendInfoToLog("Создаем переменную "+vParamName+" и присваиваем ей значение");
	object obj = project.Variables;
	obj.GetType().GetMethod("QuickCreateVariable").Invoke(obj,new Object[]{vParamName});
	project.Variables[vParamName].Value = vParamValue;
}