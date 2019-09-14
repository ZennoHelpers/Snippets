/*
* Исправление некорректного/кривого завершения предложений в текстовом контенте.
*/

// переменная с текстом
string content = project.Variables["content"].Value;

// https://gist.github.com/lord-alfred/7638d75d0cb2e2b05e714e2e90a7d3c7
// без символов: '.<>' (чтобы не сломать html-теги на всякий случай)
string pattern1 = @"\s*[\x21-\x2D\x2F\x3A-\x3B\x3D\x3F-\x40\x5B-\x60\x7B-\x7E]+\s*";

content = Regex.Replace(content, pattern1 + @"\.", @". "); // ' #.' and other
content = Regex.Replace(content, pattern1 + @"$", @". "); // 'blabla #'
content = Regex.Replace(content, @"\s+\.\s*", @". "); // '     . '
content = Regex.Replace(content, @"\s*[,]+\s*\-\s*", @", "); // ' ,,- '
content = Regex.Replace(content, @"\s+[,]{1,}\s*", @", "); // ' , '
content = Regex.Replace(content, @"\s*[\.]{2,}\s*", @"... "); // ' .. ' или '.. '

return content;