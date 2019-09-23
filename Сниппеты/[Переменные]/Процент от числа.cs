// ПРОЦЕНТ ОТ ЧИСЛА

//num - это ваша переменная
double number = double.Parse(project.Variables["number"].Value);

//percent - это ваш процент
double percent = double.Parse(project.Variables["percent"].Value);

//вычисление процента
double result = number / 100 * percent;

// округление
return System.Math.Round(result,0);