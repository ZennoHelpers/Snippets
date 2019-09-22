//возврат почты юзера (типа a67a43cf-2613-4dbf-8b22-6daa064786a4@zenno.club) из реестра
return Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\ZennoLab").GetValue("login");