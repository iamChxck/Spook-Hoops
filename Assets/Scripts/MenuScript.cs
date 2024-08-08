using System.Collections.Generic;
using UnityEngine;

public class MenuScript : MonoBehaviour
{
    public List<GameObject> panels = new List<GameObject>();
    public GameObject playerGO, teleportPointsOutsideGO, teleportPointInsideGO,mainMenuGO, stuffOnTheTableGO;
    public Transform gameStartPosition;

    public void StartGame() // Teleport the player to the play area
    {
        playerGO.transform.position = gameStartPosition.position;
        playerGO.transform.rotation = gameStartPosition.rotation;
        stuffOnTheTableGO.SetActive(true);
        teleportPointsOutsideGO.SetActive(false);
        teleportPointInsideGO.SetActive(true);
        mainMenuGO.SetActive(false);
    }

    public void OpenSettings()
    {
        panels[0].SetActive(true);
        panels[3].SetActive(false);
    }

    public void OpenCredits()
    {
        panels[1].SetActive(true);
        panels[3].SetActive(false);
    }

    public void OpenTutorial()
    {
        panels[2].SetActive(true);
        panels[3].SetActive(false);
    }

    public void CloseSettings()
    {
        panels[0].SetActive(false);
        panels[3].SetActive(true);
    }

    public void CloseCredits()
    {
        panels[1].SetActive(false);
        panels[3].SetActive(true);
    }

    public void CloseTutorial()
    {
        panels[2].SetActive(false);
        panels[3].SetActive(true);
    }

    public void CloseGame()
    {
        Application.Quit();
    }
}
