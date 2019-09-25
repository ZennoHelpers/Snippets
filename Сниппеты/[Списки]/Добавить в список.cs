lock(CommonCode.SyncObject)
{
    project.Lists["Список"].Add(project.Variables["data"].Value);
}