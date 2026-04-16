using UnityEngine;

public class Play : Action
{
    public override void PerformAction()
    {
        base.PerformAction();
        Debug.Log("Playing with frog. XP: " + xpReward);
    }
}