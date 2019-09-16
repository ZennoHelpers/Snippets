string url = he.GetAttribute("src");
instance.LoadPictures = true;
he.SetAttribute("src", url);
System.Threading.Thread.Sleep(2000);
instance.LoadPictures = false;