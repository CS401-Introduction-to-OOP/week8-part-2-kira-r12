using System.Collections.Generic;
public class ResourceManager<T> where T : Resource
{
private readonly List<T> _resources = new();
public void Add(T resource)
    {
        resource.Add(resource);
    }
public void OpenAll()
    {
        foreach (var resource in resources)
        {
            resource.Open();
        }
    }
public void CloseAll()
{
     foreach (var resource in resources)
        {
            resource.Close();
        }
}
}