using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : Component
{
    public static T self;
    private void Awake()
    {
        if (self == null)
            self = this as T;
    }
}
