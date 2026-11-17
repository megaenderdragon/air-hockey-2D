using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public enum Score
    {
        AiScore, PlayerScore
    }

    public TMP_Text AiScoreText, PlayerScoreText;
    private int aiScore, playerScore = 0;

    public void Increment(Score whichScore)
    {
        if (whichScore == Score.AiScore)
        {
            aiScore++;
            AiScoreText.text = (aiScore).ToString();
        }
        else
        {
            playerScore++;
            PlayerScoreText.text = (playerScore).ToString();
        }
    }
}
