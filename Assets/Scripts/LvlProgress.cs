using UnityEngine;
using UnityEngine.UI;

public class LvlProgress : MonoBehaviour
{

    [Header("UI references :")]
    [SerializeField] private Image uiFillImage;
    [SerializeField] private Text uiStartText;
    [SerializeField] private Text uiEndText;

    [Header("Player & Endline references :")]
    public float lvl;

    public float minLvl;

    public int curLvl = 1;

    [SerializeField] AudioSource musicLvlUp;

    public void Start()
    {
        minLvl = 0;
        lvl = 10;
        uiFillImage.fillAmount = 0;
    }

    public void SetLevelTexts(int level)
    {
        uiStartText.text = level.ToString();
        uiEndText.text = (level + 1).ToString();
    }

    public void UpdateProgressFill(int value)
    {
        minLvl += value;
        float plus = (minLvl / lvl);
        uiFillImage.fillAmount = plus;

        if (minLvl >= lvl)
        {
            musicLvlUp.Play();
            lvl = lvl + (lvl / 2);
            curLvl++;
            SetLevelTexts(curLvl);
            minLvl = 0;
            uiFillImage.fillAmount = 0;
        }
    }
}