/*
* Выбирает случайный элемент в теге select (например, для рандомного заполнения даты рождения).
*/

Random rnd = new Random();

// находим select по id
HtmlElement he = instance.ActiveTab.FindElementById("select_id");
// исключаем пустые дочерние option (обычно первый элемент с пустыи value или -1, см. как будет у тебя)
HtmlElementCollection all_elements = he.FindChildrenByXPath(".//option[@value!='']");

if (all_elements.Count > 0) {
    // убираем выделение на выбранном по дефолту элементе
    foreach (HtmlElement he_opt in all_elements) {
        if (he_opt.OuterHtml.IndexOf("selected") != -1) {
            he_opt.RemoveAttribute("selected");
            break;
        }
    }

    int he_rnd = rnd.Next(all_elements.Count);
    HtmlElement he_option = all_elements.Elements[he_rnd];

    // иногда работает только через selecteditems
    //he.SetAttribute("selecteditems", he_option.InnerHtml);
    he_option.SetAttribute("selected", "selected");
    he_option.RiseEvent("onchange", instance.EmulationLevel);
} else {
    throw new Exception("Не нашли вложенные option в select");
}