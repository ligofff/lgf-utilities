using UnityEngine;

public static class HierarchyPath
{
    public static string GetHierarchyPath(Transform o)
    {
        var path = "";
        while (o != null)
        {
            path = o.name + "/" + path;
            o = o.parent;
        }

        return path;
    }
        
    public static string GetHierarchyPath(GameObject o)
    {
        return GetHierarchyPath(o.transform);
    }
}