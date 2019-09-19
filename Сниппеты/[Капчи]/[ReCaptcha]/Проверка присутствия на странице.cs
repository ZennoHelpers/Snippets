/*
* Проверка наличия ReCaptcha v2/Invisible/v3 на странице в DOM браузера.
* Предварительно нужно дождаться загрузки всех скриптов на странице (через паузу или другим методом).
* Выходит по красной ветке если рекапча не найдена.
*/

if ((instance.MainTab.DomText.IndexOf("//www.google.com/recaptcha/api2/anchor") > -1) ||
    (instance.MainTab.DomText.IndexOf("recaptcha.anchor.Main.init") > -1))
{
    return "found";
}

throw new Exception("not found");