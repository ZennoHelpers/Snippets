// Создание объектов синхронизации в глобальной переменной для изменения списков,
// таблиц, других глобальных переменных и т.д. в разных шаблонах 

// неймспейс и имя новой переменой для синхронизации
string namespaceName = "test_namespace";
string globVarName = "my_sync_object";

// Выполняется в начале проекта
lock (project.GlobalVariables)
{
	// проверка на существование глобальной переменной
	try {
		// попытка получения объекта (переход на catch при неудаче)
		var syncobj = project.GlobalVariables[namespaceName, globVarName];
		return syncobj.ToString(); // возврат его значения (отобразится в логе PM, если возможно)
	} catch (KeyNotFoundException ex) {
		// создание объекта синхронизации и его установка, объект может быть любым: числом, строкой и т.д.
		object syncobj = new Object();
		project.GlobalVariables.SetVariable(namespaceName, globVarName, syncobj);
	}
}

// syncObject создаётся в требуемых сниппетах
var syncObject = project.GlobalVariables["test_namespace","my_sync_object"].Value;
