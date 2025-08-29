using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerActions : ActionScript
{
    Vector3 targetPosition;

    public override void QueueAction()
    {
        return;
    }

    void OnAbility1()
    {
        Debug.Log("Ability1");
        if (AbilityQueue.Count < 3)
        {
            if (AbilityList[0] != null)
            {
                
                AbilityQueue.Add(AbilityList[0]);
                AbilityTargets.Add(targetPosition);
            }
        }
    }

    void OnAbility2()
    {
        Debug.Log("Ability2");
        if (AbilityQueue.Count < 3)
        {
            if (AbilityList[1] != null)
            {
                AbilityQueue.Add(AbilityList[1]);
                AbilityTargets.Add(targetPosition);
            }
        }
    }

    void OnAbility3()
    {
        Debug.Log("Ability3");
        if (AbilityQueue.Count < 3)
        {
            if (AbilityList[2] != null)
            {
                AbilityQueue.Add(AbilityList[2]);
                AbilityTargets.Add(targetPosition);
            }
        }
    }

    void OnAbility4()
    {
        Debug.Log("Ability4");
        if (AbilityQueue.Count < 3)
        {
            if (AbilityList[3] != null)
            {
                AbilityQueue.Add(AbilityList[3]);
                AbilityTargets.Add(targetPosition);
            }
        }
    }
}


