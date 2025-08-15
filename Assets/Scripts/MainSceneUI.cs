using UnityEngine;
using UnityEngine.UI;

public class MainSceneUI : MonoBehaviour
{
    public Text playerNameText;
    public Text bestScoreText;

    void Start()
    {
        playerNameText.text = $"Player: {DataManager.Instance.playerName}";
        bestScoreText.text = $"Best Score: {DataManager.Instance.bestPlayer} - {DataManager.Instance.bestScore}";
    }

    public void UpdateScore(int score)
    {
        if (score > DataManager.Instance.bestScore)
        {
            DataManager.Instance.bestScore = score;
            DataManager.Instance.bestPlayer = DataManager.Instance.playerName;
            DataManager.Instance.SaveBestScore();
            bestScoreText.text = $"Best Score: {DataManager.Instance.bestPlayer} - {DataManager.Instance.bestScore}";
        }
    }
}

