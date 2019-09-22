// СРАВНЕНИЕ ДАТ

DateTime dateStart = DateTime.Parse(project.Variables["dateStart"].Value);
DateTime dateEnd = DateTime.Parse(project.Variables["dateEnd"].Value);
 
if(dateStart < dateEnd)
{
	//выход по зелЄной
	return "true";
}
else
{
	// выдаЄм исключение - выполнение по красной
	throw new Exception("false");
}