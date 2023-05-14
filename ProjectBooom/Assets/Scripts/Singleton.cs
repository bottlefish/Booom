using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : Component
{
    public static T Self;
    private void Awake()
    {
        if (Self == null)
            Self = this as T;
    }
}
