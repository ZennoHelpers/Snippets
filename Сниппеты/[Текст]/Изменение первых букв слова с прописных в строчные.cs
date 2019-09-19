// ИЗМЕНЕНИЕ ПЕРВЫХ БУКВ СЛОВА С ПРОПИСНЫХ В СТРОЧНЫЕ

string inputText = project.Variables["text"].Value;
return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(inputText);