/*
* Отключает Content Security Policy и исправляет ошибку: "CSharp OwnCode Script Error: Error: call to eval() blocked by CSP".
* Данный код запускать перед вызовом действия, приводящего к такой ошибке.
*/

instance.SetBrowserPreference("security.csp.enable", false);