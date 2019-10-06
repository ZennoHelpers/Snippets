string test = project.Variables["json"].Value; //данные в json, например: {"message":8,"contact":1}
project.Json.FromString(test); //Распаршивание данных json в переменные зеннопостера (вкладка json)
return project.Json.message; //Парсим значение конкретной строки
