using UnityEngine;

[CreateAssetMenu(fileName = "Attack", menuName = "ScriptableObjects/Attack")]
public class Attack : CombatAction
{
    public int BaseDamage;

    public override void Execute(Combatant user, Combatant target)
    {
        target.TakeDamage(BaseDamage);
    }
}
