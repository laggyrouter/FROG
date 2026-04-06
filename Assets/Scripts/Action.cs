using UnityEngine;

public class Action : MonoBehaviour
{
    public int xpReward = 5;

    public virtual void PerformAction()
    {
        BondManager.Instance.AddXP(xpReward);
    }
}
