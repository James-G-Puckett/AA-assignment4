using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataDisplay : MonoBehaviour
{
    public Text RoundsPlayed;
    public Text HighScore;
    public Text ScoreText;
    // Start is called before the first frame update

    private void Awake()
    {
        RoundsPlayed.text = Data.TimesAbducted.ToString();
        HighScore.text = Data.BestScore.ToString();
        ScoreText.text = Score.PinCount.ToString();
    }
    void Start()
    {
        RoundsPlayed.text = Data.TimesAbducted.ToString();
        HighScore.text = Data.BestScore.ToString();
        ScoreText.text = Score.PinCount.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = Score.PinCount.ToString();
    }
}
