using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandler : MonoBehaviour {

    ScoreHandler ScoreManagement;
    MenuHandler MenuManagement;
    RowHandler RowManagement;
    PlayerHandler PlayerManagement;
    CounterHandler CounterManagement;

    private void Start()
    {
        ScoreManagement = GetComponent<ScoreHandler>();
        MenuManagement = GetComponent<MenuHandler>();
        RowManagement = GetComponent<RowHandler>();
        PlayerManagement = GetComponent<PlayerHandler>();
        CounterManagement = GetComponent<CounterHandler>();
    }

    public void StartGame()
    {
        MenuManagement.HideAllMenu();
        RowManagement.SpawnRows();
        PlayerManagement.ShowPlayer();
        CounterManagement.StartCounting();
    }

    public void EndGame()
    {
        RowManagement.DestroyRows();
        ScoreManagement.SaveBestScore();
        ScoreManagement.ResetScore();
        MenuManagement.ShowDeathMenu();
        PlayerManagement.HidePlayer();
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
