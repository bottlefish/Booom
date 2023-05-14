using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FightingManager : Singleton<FightingManager>
{
    public Fighter player;
    public Fighter enemy;

    public int ActionNum = 8;

    public void Init()
    {
        player.InitFighter();
        enemy.InitFighter();
    }

    public void TriggerAction(int idx)
    {
        var playerAction = player.actionList[idx];
        var enemyAction = player.actionList[idx];

        playerAction?.Effect();
        enemyAction?.Effect();
    }
}
