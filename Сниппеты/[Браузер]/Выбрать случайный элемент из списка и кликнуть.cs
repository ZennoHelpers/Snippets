// при регистрации часто бывают случаи, что нужно кликнуть по случайному элементу (тегу) для выбора цвета/шаблона/категории
// данный сниппет ищет все элементы по заданному XPath и кликает по случайному тегу <li>, содержащему класс 'color' и являющемуся дочерним к тегу <ul> с id 'choose'

Random rnd = new Random();

HtmlElementCollection hec = instance.ActiveTab.FindElementsByXPath("//ul[@id='choose']/li[contains(@class, 'color')]");
if (hec.Count == 0) {
	throw new Exception("hec empty");
}

HtmlElement he = hec.Elements[rnd.Next(hec.Count)];
he.Click();