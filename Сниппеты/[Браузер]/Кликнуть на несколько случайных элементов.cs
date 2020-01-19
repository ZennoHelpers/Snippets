/*
Иногда после регистрации нужно выбрать N категорий/тем/интересов (элементов) для того, чтоб подписаться на их новости (и дальше не пройти без этого действия).
Данный сниппет позволит выбрать случайные элементы основываясь на xPath-селекторе.
Также в сниппете реализована идея удаления уже прокликанных элементов, чтоб не отключать их выбор (повторный клик). Благодаря этому не нужно заводить "черный список" для проверки факта клика.
*/

Random rnd = new Random();

List<HtmlElement> hec = instance.ActiveTab.FindElementsByXPath("//div[contains(@class, 'pickerList')]/div/div[contains(@class, 'pickerThemes')]").ToList<HtmlElement>();
if (hec.Count == 0) {
	throw new Exception("hec empty");
}

int count = rnd.Next(4, hec.Count); // случайное количество элементов для клика в диапазоне [4, общее_число_элементов_списка]
for (int i = 0; i < count; i++) {
	HtmlElement he = hec[rnd.Next(hec.Count)]; // выбор случайного элемента из списка
	he.Click(); // клик по нему

	hec.Remove(he); // удаление элемента из списка, чтоб предотвратить повторный клик

	new System.Threading.ManualResetEvent(false).WaitOne(1000); // пауза 1 секунда
}