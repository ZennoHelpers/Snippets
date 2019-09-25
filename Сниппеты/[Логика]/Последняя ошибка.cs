LastError lastError = project.GetLastError();

string projectName = lastError.ProjectName;
string actionGroupId = lastError.ActionGroupId;
string actionId = lastError.ActionId;
string actionComment = lastError.ActionComment;
Exception e = lastError.Exception;

project.SendErrorToLog("Проект: " + projectName + "\r\n" +
                       "id группы экшенов: " + actionGroupId + "\r\n" +
                       "id экшена: " + actionId + "\r\n" +
                       "Комментарий экшена: " + actionComment + "\r\n" +
                       "Текст ошибки: " + e.Message + "\r\n" + e.StackTrace);