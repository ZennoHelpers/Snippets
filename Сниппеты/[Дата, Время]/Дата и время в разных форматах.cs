// ДАТА И ВРЕМЯ В ОПРЕДЕЛЁННОМ ФОРМАТЕ

return DateTime.Now.ToString("MM-dd-yyyy_hh-mm-ss");

/*

ПОДСКАЗКА ПО ФОРМАТАМ:
DateTime.Now.ToString("MM/dd/yyyy") - 05/29/2015
DateTime.Now.ToString("dddd, dd MMMM yyyy") - Friday, 29 May 2015
DateTime.Now.ToString("dddd, dd MMMM yyyy") - Friday, 29 May 2015 05:50
DateTime.Now.ToString("dddd, dd MMMM yyyy") - Friday, 29 May 2015 05:50 AM
DateTime.Now.ToString("dddd, dd MMMM yyyy") - Friday, 29 May 2015 5:50
DateTime.Now.ToString("dddd, dd MMMM yyyy") - Friday, 29 May 2015 5:50 AM
DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss") - Friday, 29 May 2015 05:50:06
DateTime.Now.ToString("MM/dd/yyyy HH:mm") - 05/29/2015 05:50
DateTime.Now.ToString("MM/dd/yyyy hh:mm tt") - 05/29/2015 05:50 AM
DateTime.Now.ToString("MM/dd/yyyy H:mm") - 05/29/2015 5:50
DateTime.Now.ToString("MM/dd/yyyy h:mm tt") - 05/29/2015 5:50 AM
DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss") - 05/29/2015 05:50:06
DateTime.Now.ToString("MMMM dd") - May 29
DateTime.Now.ToString("yyyy’-‘MM’-‘dd’T’HH’:’mm’:’ss.fffffffK") - 2015-05-16T05:50:06.7199222-04:00
DateTime.Now.ToString("ddd, dd MMM yyy HH’:’mm’:’ss ‘GMT’") - Fri, 16 May 2015 05:50:06 GMT
DateTime.Now.ToString("yyyy’-‘MM’-‘dd’T’HH’:’mm’:’ss") - 2015-05-16T05:50:06
DateTime.Now.ToString("HH:mm") - 05:50
DateTime.Now.ToString("hh:mm tt") - 05:50 AM
DateTime.Now.ToString("H:mm") - 5:50
DateTime.Now.ToString("h:mm tt") - 5:50 AM
DateTime.Now.ToString("HH:mm:ss") - 05:50:06
DateTime.Now.ToString("yyyy MMMM") - 2015 May

Другие форматы смотрите здесь: https://docs.microsoft.com/en-us/dotnet/standard/base-types/custom-date-and-time-format-strings

*/