// ДОБАВЛЕНИЕ ВСЕХ ВХОЖДЕНИЙ ИЗ ТЕКСТА В СПИСОК
 
// исходная перемменая в которой будет произведён поиск
string sourceInfo = project.Variables["sourceInfo"].Value;

// регулярное выражение
Regex regexPattern = new Regex(@"[0-9]{3,5}"); 

// результаты сохраняются в список
IZennoList outputList = project.Lists["OutputList"];

// сохранение результата в список
regexPattern.Matches(sourceInfo).Cast<Match>().ToList().ForEach(m=>outputList.Add(m.Value)); 