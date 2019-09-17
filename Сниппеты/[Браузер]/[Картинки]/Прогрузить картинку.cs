HtmlElement he = instance.ActiveTab.FindElementById("img");
string url = he.GetAttribute("src");
instance.LoadPictures = true;
he.SetAttribute("src", url);
Thread.Sleep(2000);
instance.LoadPictures = false;