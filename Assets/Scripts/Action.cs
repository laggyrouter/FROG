using UnityEngine;

public class Action : MonoBehaviour
{
    public int xpReward = 5;

    public Sprite actionSprite;
    public AudioClip actionSound;
    public Sprite idleSprite;

    private SpriteRenderer frogRenderer;
    private AudioSource frogAudioSource;

    private void Start()
    {
        frogRenderer = GameObject.Find("FrogSprite").GetComponent<SpriteRenderer>();
        frogAudioSource = GameObject.Find("FrogSprite").GetComponent<AudioSource>();
    }

    public virtual void PerformAction()
    {
        BondManager.Instance.AddXP(xpReward);

        if (actionSprite != null)
            frogRenderer.sprite = actionSprite;

        if (actionSound != null)
            frogAudioSource.PlayOneShot(actionSound);

        Invoke(nameof(ReturnToIdle), 0.35f);
    }

    private void ReturnToIdle()
    {
        if (idleSprite != null)
            frogRenderer.sprite = idleSprite;
    }
}