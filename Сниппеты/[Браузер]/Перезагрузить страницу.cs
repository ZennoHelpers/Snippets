//мягкая перезагрузка, F5
instance.ActiveTab.MainDocument.EvaluateScript("window.location.reload(false)");

//жесткая перезагрузка, как Ctrl+F5
instance.ActiveTab.MainDocument.EvaluateScript("window.location.reload(true)");
