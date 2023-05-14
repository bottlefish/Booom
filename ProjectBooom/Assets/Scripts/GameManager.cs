using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    public int maxMana;
    public int mana;

    Fighter player => FightingManager.Self.player;

    public void FreshMana() { }

    /// <summary>
    /// 点击开始战斗的事件
    /// </summary>
    public void OnStartFightClicked()
    {
        // 之后要改成携程，每一个动作之间延迟触发
        for (int i = 0; i < FightingManager.Self.ActionNum; i++)
            FightingManager.Self.TriggerAction(i);
    }


    /// <summary>
    /// 将一个新动作加入动作序列
    /// </summary>
    public void DragNewActionToSlot(string actionIDs, int slot)
    {
        Type type = System.Type.GetType(actionIDs);

        if (type == null)
            Debug.LogError("Type not found: " + actionIDs);
        else
        {
            var act = type.GetConstructors()[0].Invoke(null) as ActionBase;
            act.IDs = actionIDs;
            act.fighter = player;
            act.fighter.actionList[slot] = act;
        }
    }

    /// <summary>
    /// 改变序列中已有动作的位置
    /// </summary>
    public void DragActionToSlot(int prevSlot, int afterSlot)
    {
        if (prevSlot == afterSlot) return;

        var tmp = player.actionList[afterSlot];
        player.actionList[afterSlot] = player.actionList[prevSlot];
        player.actionList[prevSlot] = tmp;
    }
}
