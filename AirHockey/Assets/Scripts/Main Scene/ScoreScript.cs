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

    public UiManager uiManager;

    public int MaxScore;

    #region scores
    private int aiScore, playerScore;

    private int AiScore
    {
        get { return aiScore; }
        set {  
            aiScore = value;
            if (value == MaxScore) uiManager.ShowRestartCanvas(true);
        }
    }

    private int PlayerScore
    {
        get { return playerScore; }
        set
        {
            playerScore = value;
            if (value == MaxScore) uiManager.ShowRestartCanvas(false);
        }
    }
    #endregion

    public void Increment(Score whichScore)
    {
        if (whichScore == Score.AiScore)
        {
            AiScoreText.text = (++AiScore).ToString();
        }
        else
        {
            playerScore++;
            PlayerScoreText.text = (++PlayerScore).ToString();
        }
    }

    public void ResetScores()
    {
        AiScore = PlayerScore = 0;
        PlayerScoreText.text = AiScoreText.text = "0";
    }
}
