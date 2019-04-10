using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuHandler : MonoBehaviour {

    public GameObject MainMenu;
    public GameObject DeathMenu;
    public GameObject AuthorMenu;
    public GameObject SettingsMenu;

    public void HideAllMenu()
    {
        GameObject Canvas = GameObject.Find("Menus");
        for (int i = 0; i < Canvas.transform.childCount; i++)
        {
            Canvas.transform.GetChild(i).gameObject.SetActive(false);
        }
    }

    public void ShowMainMenu()
    {
        DeathMenu.SetActive(false);
        AuthorMenu.SetActive(false);
        SettingsMenu.SetActive(false);
        MainMenu.SetActive(true);
    }

    public void ShowDeathMenu()
    {
        DeathMenu.SetActive(true);
        AuthorMenu.SetActive(false);
        SettingsMenu.SetActive(false);
        MainMenu.SetActive(false);
    }

    public void ShowAuthorMenu()
    {
        DeathMenu.SetActive(false);
        AuthorMenu.SetActive(true);
        SettingsMenu.SetActive(false);
        MainMenu.SetActive(false);
    }

    public void ShowSettingsMenu()
    {
        DeathMenu.SetActive(false);
        AuthorMenu.SetActive(false);
        SettingsMenu.SetActive(true);
        MainMenu.SetActive(false);
    }
}
