using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FightingManager : Singleton<FightingManager>
{
    Fighter player;
    Fighter enemy;

    public int ActionNum = 8;

    public void StartFight()
    {
        player.InitFighter();
        enemy.InitFighter();
    }

    public void RoundAction()
    {
        for (int i = 0; i < ActionNum; i++)
        {
            var playerAction = player.actionList[i];
            var enemyAction = player.actionList[i];
        }
    }
}
