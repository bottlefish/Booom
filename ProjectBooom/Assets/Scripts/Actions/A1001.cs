using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A1001 : ActionBase
{
    // 热度+3

    public override void Effect()
    {
        fighter.value += 3;
    }
}
