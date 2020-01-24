// Копирует полностью содержимое Таблицы 1 в Таблицу 2
var table1 = project.Tables["Таблица 1"];
var table2 = project.Tables["Таблица 2"];
for(int i=0; i<table1.RowCount; i++) {
    table2.AddRow(table1.GetRow(i).ToArray());
}
