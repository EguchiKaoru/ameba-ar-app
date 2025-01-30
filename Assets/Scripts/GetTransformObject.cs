using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GetTransformObject
{
    public static Vector3 GetPosition(GameObject obj)
    {
        return obj.transform.position;
    }

    public static Quaternion GetRotation(GameObject obj)
    {
        return obj.transform.rotation;
    }

    public static Vector3 GetScale(GameObject obj)
    {
        return obj.transform.localScale;
    }
}
