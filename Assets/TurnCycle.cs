using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnAction
{
    public Combatant User;
    public Combatant Target;
    public CombatAction Action;

    public TurnAction(Combatant user, Combatant target, CombatAction action)
    {
        User = user;
        Target = target;
        Action = action;
    }

    public void Play()
    {
        Action.Execute(User, Target);
    }
}

public class TurnCycle : MonoBehaviour
{
    public List<Combatant> Combatants = new List<Combatant>();

    public Queue<TurnAction> ActionQueue = new Queue<TurnAction>();

    int i = -1;

    private void Start()
    {
        RequestNext();
    }

    //private void Update()
    //{
    //    if (ActionQueue.Count == 0)
    //    {
    //        RequestNext();
    //    }
    //}

    public void RequestNext()
    {
        i++;
        if (i > Combatants.Count - 1)
        {
            PlayActions();
            i = -1;
            return;
        }

        Combatants[i].isActive = true;
    }

    public void PlayActions()
    {
        foreach (var action in ActionQueue)
        {
            // check if target is still valid
            Debug.Log($"{action.User.gameObject} used action {action.Action.Name} on {action.Target.gameObject}");
            action.Play();
        }
    }
}
