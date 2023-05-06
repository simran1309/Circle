 
using UnityEngine;

public class ScoreUI : MonoBehaviour
{
    int Score,Diamond;
    public TMPro.TextMeshProUGUI ScoreText;
    public TMPro.TextMeshProUGUI DiamondText;
    public TMPro.TextMeshProUGUI EndScore;
    // Start is called before the first frame update

    public void IncrementScore(int value)
    {
        Score += value;
        UpdateDisplay();
    }
    public void IncrementDiamond(int value)
    {
        Diamond += value;
        UpdateDisplay();
    }
    void UpdateDisplay()
    {
        ScoreText.text = Score.ToString();
        EndScore.text = Score.ToString();
        DiamondText.text = Diamond.ToString();
    }
  
}
