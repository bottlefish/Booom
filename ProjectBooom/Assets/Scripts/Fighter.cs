using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fighter
{
    public List<ActionBase> actionList;

    public void InitFighter()
    {
        actionList = new List<ActionBase>();
        for (int i = 0; i < FightingManager.self.ActionNum; i++)
            actionList.Add(null);
    }
}
