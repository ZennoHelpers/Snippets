//Получение FileVer данных постера в котором запущен (можен не совпадать с данными в заголовке для бета-версий)
return new Version(System.Windows.Forms.Application.ProductVersion).ToString();