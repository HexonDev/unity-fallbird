using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHandler : MonoBehaviour {

    public GameObject Player;

    private void Start()
    {
        Player = GameObject.Find("Player");
        
        Player.SetActive(false);
    }

    public void ShowPlayer()
    {
        Player.transform.position = new Vector3(0, 2.47f, 0);
        Player.SetActive(true);
    }

    public void HidePlayer()
    {
        Player.SetActive(false);
    }
}
