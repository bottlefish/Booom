using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionBase
{
    public Fighter fighter;
    public int manaCost = 1;
    public string IDs = "";

    virtual public void Effect() { }
}
