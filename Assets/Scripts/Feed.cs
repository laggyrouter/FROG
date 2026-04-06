using UnityEngine;

public class Feed : MonoBehaviour
{
  protected int xpReward = 5;
    public virtual void PerformAction()
    {
        Debug.Log("Feeding frog. XP: " + xpReward);
        BondManager.Instance.AddXP(xpReward);
    }
}
