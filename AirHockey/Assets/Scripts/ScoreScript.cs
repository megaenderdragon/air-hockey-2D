using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public enum Score
    {
        AiScore, PlayerScore
    }

    public CanvasRenderer AiScoreCanvas, PlayerScoreCanvas;
    private TextMeshPro AiScoreText, PlayerScoreText;
    private int aiScore, playerScore;

    private void Start()
    {
        AiScoreText = AiScoreCanvas.GetComponent<TextMeshPro>();
        PlayerScoreText = PlayerScoreCanvas.GetComponent<TextMeshPro>();
    }

    public void Increment(Score whichScore)
    {
        if (whichScore == Score.AiScore)
        {
            AiScoreText.text = (++aiScore).ToString();
        }
        else
        {
            PlayerScoreText.text = (++playerScore).ToString();
        }
    }
}
