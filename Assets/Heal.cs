using UnityEngine;

[CreateAssetMenu(fileName = "Heal", menuName = "ScriptableObjects/Heal")]
public class Heal : CombatAction
{
    public int BaseHealing;

    public override void Execute(Combatant user, Combatant target)
    {
        target.Heal(BaseHealing);
    }
}