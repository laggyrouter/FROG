using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class BondManager : MonoBehaviour
{
    public static BondManager Instance;

    public int bondXP = 0;
    public int bondLevel = 1;
    public int xpToNextLevel = 20;

    public Slider bondSlider;
    public TextMeshProUGUI bondText;

    void Awake()
    {
        Instance = this;
    }

    public void AddXP(int amount)
    {
        bondXP += amount;

        if (bondXP >= xpToNextLevel)
        {
            LevelUp();
        }

        UpdateUI();
    }

    void LevelUp()
    {
        bondXP = 0;
        bondLevel++;
        xpToNextLevel += 5; // Increase XP requirement for next level
    }

    void UpdateUI()
    {
        bondSlider.maxValue = xpToNextLevel;
        bondSlider.value = bondXP;

        bondText.text = "Bond Lv. " + bondLevel;
    }
}
