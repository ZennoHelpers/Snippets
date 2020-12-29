// Создание объектов синхронизации в глобальной переменной для изменения списков,
// таблиц, других глобальных переменных и т.д. в разных шаблонах 


// Выполняется в начале проекта
lock (project.GlobalVariables)
{
	// check if exists
	try {
		var syncobj = project.GlobalVariables["test_namespace","my_sync_object"];
		return syncobj.ToString();
	} catch (KeyNotFoundException ex) {
		// create sync object
		object syncobj = new Object();
		project.GlobalVariables.SetVariable("test_namespace","my_sync_object", syncobj);
	}
}

// syncObject создаётся в требуемых сниппетах
var syncObject = project.GlobalVariables["test_namespace","my_sync_object"].Value;
