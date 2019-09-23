/*
* Осуществляет вычитание одной даты из другой и предоставляет результат в виде количества дней.
*/

// Первая дата, например: 18.09.2019
DateTime date1 = DateTime.Parse(project.Variables["date1"].Value);

// Вторая дата, например: 14.09.2019
DateTime date2 = DateTime.Parse(project.Variables["date2"].Value);

// Вычитаем из первой даты вторую
TimeSpan delta = date1 - date2;

// В результате вернет: 4
return Convert.ToString(delta.Days); // можно также возвращать разницу в часах, минутах и тд