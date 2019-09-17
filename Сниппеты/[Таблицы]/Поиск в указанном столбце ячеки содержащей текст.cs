IZennoTable table = project.Tables["base"];
int colNum = 0; //порядковый номер колонки

for (int i = 0; i < table.RowCount; i++)
{
	string cell = table.GetCell(colNum, i); // получает текст ячейки
	if (cell.Contains(project.Variables["part"].Value)) // поиск части текста из переменной ZP: part
	{
		return "true";
	}
}

return "false";