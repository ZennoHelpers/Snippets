lock(CommonCode.SyncObject)
{
    HashSet<string> hs = new HashSet<string>(project.Lists["buildID"]);
    project.Lists["buildID"].Clear();
    project.Lists["buildID"].AddRange(hs);
}