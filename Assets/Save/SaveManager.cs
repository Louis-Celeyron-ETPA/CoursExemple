using UnityEngine;
using TMPro;

public class SaveManager : MonoBehaviour
{

    public string playerName;
    public int playerScore;
    public TextMeshProUGUI scoreText;


    public void SetName(string name)
    {
        playerName = name;
    }

    public void Save()
    {
        PlayerPrefs.SetString("name", playerName);
        PlayerPrefs.SetInt("score", playerScore);
        PlayerPrefs.Save();
    }

    public void Load()
    {
        playerName = PlayerPrefs.GetString("name", "Joueur");
        playerScore = PlayerPrefs.GetInt("score",0);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerScore++;
        }

        scoreText.text = $"{playerName} Score is {playerScore}";
    }
}
