using UnityEngine;

public class Feed : Action
{
    public override void PerformAction()
    {
        base.PerformAction();
        Debug.Log("Feeding frog. XP: " + xpReward);
    }
}