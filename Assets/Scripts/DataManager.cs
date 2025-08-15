using UnityEngine;

public class DataManager : MonoBehaviour
{
    public static DataManager Instance;

    public string playerName;
    public string bestPlayer;
    public int bestScore;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
        LoadBestScore();
    }

    public void SaveBestScore()
    {
        PlayerPrefs.SetInt("BestScore", bestScore);
        PlayerPrefs.SetString("BestPlayer", bestPlayer);
        PlayerPrefs.Save();
    }

    public void LoadBestScore()
    {
        bestScore = PlayerPrefs.GetInt("BestScore", 0);
        bestPlayer = PlayerPrefs.GetString("BestPlayer", "None");
    }
}

