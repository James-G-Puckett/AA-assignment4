using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Data : MonoBehaviour
{
    public static string PlayerName = "Abductee";
    public static int score = 0;
    public static int BestScore = 0;
    public static int TimesAbducted = 0;
    public InputField PlayerNameInput;
    public Text showPlayerName;
    public Text showMyScore;

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        showPlayerName.text = PlayerName;
    }

    public void UpdateName()
    {
        PlayerName = PlayerNameInput.text;
        
        showPlayerName.text = PlayerName;
    }
    public void ShowName()
    {
        showPlayerName.text = PlayerName;
        
    }

    public void ShowScore()
    {
        showMyScore.text = score.ToString();
    }
}