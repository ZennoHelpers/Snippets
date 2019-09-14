/*
* Изменение языка рекапчи на английский для всех страниц, которые будут открыты после исполнения этого кода.
*/

// Список языков: https://developers.google.com/recaptcha/docs/language
string lang_regex = @"[a-zA-Z0-9]{2,6}";

instance.ChangeResponse(
    @".*",
    new List<string>
    {
        @"api\.js\?hl=" + lang_regex,
        @"bframe\?hl=" + lang_regex,
        @"&amp;hl=" + lang_regex + @"&amp;",
        @"hl=" + lang_regex
    },
    new List<string>
    {
        "api.js?hl=en",
        "bframe?hl=en",
        "&amp;hl=en&amp;",
        "hl=en"
    },
    true
);