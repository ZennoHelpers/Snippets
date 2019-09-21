lock(CommonCode.SyncObject)
{
	for (int i=0; i < project.Lists["buildID"].Count; i++)
	{
		for (int j=i+1; j < project.Lists["buildID"].Count; j++)
		{
			if (project.Lists["buildID"][i] == project.Lists["buildID"][j])
			{
				project.Lists["buildID"].RemoveAt(j);
			}
		}
	}
}