using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCombatant : Combatant
{
    protected override void SelectAction()
    {
        turnAction = new TurnAction(this, this, actions[Random.Range(0, actions.Length - 1)]);
    }
}