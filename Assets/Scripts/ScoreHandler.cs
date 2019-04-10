using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class ScoreHandler : MonoBehaviour {

    public Text ScoreText;
    public Text BestScoreText;

    int _PlayerScore = 0;
    int _PlayerBestScore = 0;

    private void Update()
    {
        ScoreText.text = "Score:" + _PlayerScore.ToString();
        BestScoreText.text = "Best:" + _PlayerBestScore.ToString();

        // Score, Best score kezelése
        if (_PlayerScore > _PlayerBestScore)
        {
            SetBestScore(_PlayerScore);
        }
    }

    public int PlayerScore
    {
        get
        {
            return this._PlayerScore;
        }
    }

    public int PlayerBestScore
    {
        get
        {
            return this._PlayerBestScore;
        }
    }

    public void SetScore(int value)
    {
        _PlayerScore = value;
    }

    public void GiveScore(int value)
    {
        _PlayerScore += value;
    }

    public void TakeScore(int value)
    {
        _PlayerScore -= value;
    }

    public void ResetScore()
    {
        SetScore(0);
    }
   

    public void SetBestScore(int value)
    {
        _PlayerBestScore = value;
    }

    public void GiveBestScore(int value)
    {
        _PlayerBestScore += value;
    }

    public void TakeBestScore(int value)
    {
        _PlayerScore -= value;
    }

    public void ResetBestScore()
    {
        SetBestScore(0);
    }

    //__________________________________//
    // Best Score elmentése, betöltése

    string SavePath;

    public void SaveBestScore()
    {
        SavePath = Application.persistentDataPath + "/score.txt";
        File.WriteAllText(SavePath, _PlayerBestScore.ToString());
    }
    public void LoadBestScore()
    {
        SavePath = Application.persistentDataPath + "/score.txt";
        var LoadedScore = File.ReadAllText(SavePath);
        SetBestScore(int.Parse(LoadedScore));
    }
}
