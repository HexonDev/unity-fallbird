using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHandler : MonoBehaviour {

    ScoreHandler ScoreManagement;
    GameHandler GameManagement;

    private void Start()
    {
        ScoreManagement = GameObject.Find("Manager").GetComponent<ScoreHandler>();
        GameManagement = GameObject.Find("Manager").GetComponent<GameHandler>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Death")
        {
            GameManagement.EndGame();
        }else if(collision.tag == "Score")
        {
            ScoreManagement.GiveScore(1);
        }
    }
}
