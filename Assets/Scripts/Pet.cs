using UnityEngine;

public class Pet : Action
{
    public override void PerformAction()
    {
        base.PerformAction();
        Debug.Log("Petting frog. XP: " + xpReward);
    }
}