// получает все ссылки со страницы с определенным доменом
// полезно для написания бота "бродилки", чтоб он не уходил с текущего сайта


// домен из Zenno-переменной (например: yandex.ru - в нижнем регистре, без http(s) и www)
string domain = project.Variables["domain"].Value;

// разделитель списка ссылок, который будет использован для объединения результата
string separator = "<!>";

// результат (без дубликатов!)
HashSet<string> result = new HashSet<string>();

// поиск всех тегов <a>
HtmlElementCollection hec = instance.ActiveTab.FindElementsByTags("a");
foreach(HtmlElement he in hec) {
	string href = he.GetAttribute("href");

	string href_host = String.Empty;
	try {
		Uri href_uri = new Uri(href);
		href_host = href_uri.Host;
	} catch {}
	
	// если хост пустой (ошибка парсинга ссылки) или не тот, что нужен - пропускаем текущую ссылку
	if (String.IsNullOrEmpty(href_host) || (href_host != domain)) {
		continue;
	}
	
	result.Add(href);
}

return String.Join(separator, result);