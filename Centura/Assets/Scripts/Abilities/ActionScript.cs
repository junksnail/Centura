
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class ActionScript : MonoBehaviour
{
    private bool takingAction = false;
    private IEnumerator coroutine;

    [SerializeField] GameObject queueUiObject;

    public List<Abilities> AbilityList = new List<Abilities>();
    public List<Abilities> AbilityQueue = new List<Abilities>();
    public List<Image> IconList = new List<Image>();
    public List<Vector3> AbilityTargets = new List<Vector3>();

    public virtual void QueueAction()
    {
        if (AbilityQueue.Count < 4)
        {
            AbilityQueue.Add(AbilityList[0]);
        }
    }

    public void TakeActionFunction()
    {
        if (!takingAction)
        {
            takingAction = true;

            coroutine = ActionCoroutine();
            StartCoroutine(coroutine);
        }
    }

    IEnumerator ActionCoroutine()
    {
        if (AbilityQueue.Count > 0)
        {
            AbilityQueue[0].AbilityUse(gameObject, AbilityTargets[0]);
            AbilityQueue.RemoveAt(0);
            AbilityTargets.RemoveAt(0);
        }
        yield return new WaitForSeconds(0.4f);
        takingAction = false;
    }

  

    void Update()
    {
        QueueAction();
    }
}
