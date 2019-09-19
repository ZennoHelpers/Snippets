// ИЗМЕНЕНИЕ ПЕРВОЙ БУКВЫ ПЕРВОГО СЛОВА НА ЗАГЛАВНУЮ

string inputText = project.Variables["text"].Value;
return inputText.Substring(0, 1).ToUpper() + inputText.Substring(1);