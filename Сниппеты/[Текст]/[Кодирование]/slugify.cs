// Преобразование строки в slug для использования в URL (путь к странице и тд)
// Например из текста: 'Snippets for ZennoPoster v.7' мы получим: 'snippets-for-zennoposter-v7'
// Реализация подсмотрена в Laravel: https://github.com/laravel/framework/blob/8577aff/src/Illuminate/Support/Str.php#L499-L518

// Переменная, из которой будем генерировать slug
string title = project.Variables["title"].Value;
// разделитель
string separator = "-";

// дальше уже волшебство регулярок
string separator_flip = "_";
if (separator != "-") {
	separator_flip = "-";
}

title = Regex.Replace(title, @"[" + Regex.Escape(separator_flip) + @"]", separator);
title = title.Replace("@", separator + "at" + separator);
title = title.ToLower();
title = Regex.Replace(title, @"[^" + Regex.Escape(separator) + @"\p{L}\p{N}\s]+", "");
title = Regex.Replace(title, @"[" + Regex.Escape(separator) + @"\s]+", separator);
title = title.Trim(new char[]{Convert.ToChar(separator)});

return title;