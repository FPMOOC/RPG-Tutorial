using UnityEngine;

public abstract class Combatant : MonoBehaviour
{
    [SerializeField] private TurnCycle cycle;

    [SerializeField] protected CombatAction[] actions;

    [SerializeField] private int hp;
    [SerializeField] private int maxHP;

    public bool isActive;

    protected TurnAction turnAction = null;

    private void Start()
    {
        cycle.Combatants.Add(this);
    }

    private void Update()
    {
        if (isActive)
        {
            if (turnAction == null)
            {
                SelectAction();
            }
            else
            {
                cycle.ActionQueue.Enqueue(turnAction);
                isActive = false;
                cycle.RequestNext();
            }
        }
    }

    protected abstract void SelectAction();

    public void Heal(int amount)
    {
        hp += amount;
        if (hp > maxHP) hp = maxHP;
    }

    public void TakeDamage(int damage)
    {
        hp -= damage;
        if (hp <= 0)
        {
            hp = 0;
            Die();
        }
    }

    public void Die()
    {
        cycle.Combatants.Remove(this);
        Destroy(gameObject);
    }
}
