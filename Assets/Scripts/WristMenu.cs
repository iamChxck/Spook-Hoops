using UnityEngine;
using UnityEngine.InputSystem;

public class WristMenu : MonoBehaviour
{
    public GameObject wristMenuGO, wristSettingsGO, playerGO;
    public GameManager gameManager;
    public Transform spawnPointOutside;

    public GameObject WristUI;

    public bool activeWristUI = true;

    private void Start()
    {
        DisplayWristUI();
    }

    public void MenuPressed(InputAction.CallbackContext context) // Checks if the menu button was pressed
    {
        if (context.performed)
            DisplayWristUI();
    }

    public void DisplayWristUI() // Opens or closes the wrist UI
    {
        if(activeWristUI)
        {
            WristUI.SetActive(false);
            activeWristUI = false;
        }
        else if(!activeWristUI)
        {
            WristUI.SetActive(true);
            activeWristUI = true;
        }
    }

    public void GoBack() // Teleports the player back to the "lobby"
    {
        playerGO.transform.position = spawnPointOutside.position;
    }

    public void Restart() // Resets the game state
    {
        gameManager.ResetGame();
    }

    public void Settings() // Opens the settings
    {
        wristMenuGO.SetActive(false);
        wristSettingsGO.SetActive(true);
    }

    public void Quit() // Close the game
    {
        Application.Quit();
    }


}
