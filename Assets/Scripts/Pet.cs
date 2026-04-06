using UnityEngine;

public class Pet : MonoBehaviour
{
    protected int xpReward = 5;

    public virtual void PerformAction()
    {
        Debug.Log("Interacting with pet. XP: " + xpReward);
        BondManager.Instance.AddXP(xpReward);
    }
}
