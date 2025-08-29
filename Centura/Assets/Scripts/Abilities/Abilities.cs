using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Abilities", menuName = "Abilities/Create Ability", order = 1)]
public class Abilities : ScriptableObject
{

    public string abilityName;

    public string abilityDescription;

    public Sprite abilityIcon;

    public GameObject userObject;

    public Vector3 targetPosition;

    public virtual void AbilityUse(GameObject abilityUser, Vector3 targetPos)
    {
        userObject = abilityUser;
        UserCheck();
        Debug.Log(abilityName + " cast");
    }

    public void UserCheck()
    {
        if (userObject != null)
        {
        }
    }
}


