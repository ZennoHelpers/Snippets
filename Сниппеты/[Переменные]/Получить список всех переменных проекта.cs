// ПОЛУЧИТЬ СПИСОК ВСЕХ ПЕРЕМЕННЫХ ПРОЕКТА В ФОРМАТЕ "Name=Value"

return string.Join("\r\n", project.Variables.Select(v=>v.Key+"="+v.Value.Value));