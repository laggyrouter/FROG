using UnityEngine;

public class Play : MonoBehaviour
{
    protected int xpReward = 5;
    public virtual void PerformAction()
    {
        Debug.Log("Playing with frog. XP: " + xpReward);
        BondManager.Instance.AddXP(xpReward);
    }

}

