// СРАВНЕНИЕ ДАТ

// дата в формате: 12.10.19 19:30:40
DateTime dateStart = DateTime.Parse(project.Variables["dateStart"].Value);

// дата в формате: 15.10.19 19:30:40
DateTime dateEnd = DateTime.Parse(project.Variables["dateEnd"].Value);
 
if(dateStart < dateEnd)
{
	//выход по зелёной
	return "true";
}
else
{
	// выдаём исключение - выполнение по красной
	throw new Exception("false");
}