using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CombatAction : ScriptableObject
{
    public string Name;

    public abstract void Execute(Combatant user, Combatant target);
}
