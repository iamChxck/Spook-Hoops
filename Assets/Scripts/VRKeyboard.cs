using TMPro;
using UnityEngine;

public class VRKeyboard : MonoBehaviour
{
    public TMP_InputField leaderboardNameInput;
    public GameManager gameManager;
    public GameObject stuffOnTheTableGO, keyboardCanvasGO;
    public string keyPressed;

    public void ClickKey(string _clickedKey)
    {
        keyPressed = _clickedKey;
        switch (keyPressed) // Checks what key was pressed and adds it to the input field as long as it's not over the character limit
        {
            case "Delete":
                leaderboardNameInput.text = "";
                break;
            case "Submit":
                gameManager.UpdateLeaderboard(leaderboardNameInput.text);
                gameManager.ResetGame();
                keyboardCanvasGO.SetActive(false);
                stuffOnTheTableGO.SetActive(true);
                break;
            case "A":
                if (leaderboardNameInput.text.Length < leaderboardNameInput.characterLimit)
                    leaderboardNameInput.text += "A";
                break;
            case "B":
                if (leaderboardNameInput.text.Length < leaderboardNameInput.characterLimit)
                    leaderboardNameInput.text += "B";
                break;
            case "C":
                if (leaderboardNameInput.text.Length < leaderboardNameInput.characterLimit)
                    leaderboardNameInput.text += "C";
                break;
            case "D":
                if (leaderboardNameInput.text.Length < leaderboardNameInput.characterLimit)
                    leaderboardNameInput.text += "D";
                break;
            case "E":
                if (leaderboardNameInput.text.Length < leaderboardNameInput.characterLimit)
                    leaderboardNameInput.text += "E";
                break;
            case "F":
                if (leaderboardNameInput.text.Length < leaderboardNameInput.characterLimit)
                    leaderboardNameInput.text += "F";
                break;
            case "G":
                if (leaderboardNameInput.text.Length < leaderboardNameInput.characterLimit)
                    leaderboardNameInput.text += "G";
                break;
            case "H":
                if (leaderboardNameInput.text.Length < leaderboardNameInput.characterLimit)
                    leaderboardNameInput.text += "H";
                break;
            case "I":
                if (leaderboardNameInput.text.Length < leaderboardNameInput.characterLimit)
                    leaderboardNameInput.text += "I";
                break;
            case "J":
                if (leaderboardNameInput.text.Length < leaderboardNameInput.characterLimit)
                    leaderboardNameInput.text += "J";
                break;
            case "K":
                if (leaderboardNameInput.text.Length < leaderboardNameInput.characterLimit)
                    leaderboardNameInput.text += "K";
                break;
            case "L":
                if (leaderboardNameInput.text.Length < leaderboardNameInput.characterLimit)
                    leaderboardNameInput.text += "L";
                break;
            case "M":
                if (leaderboardNameInput.text.Length < leaderboardNameInput.characterLimit)
                    leaderboardNameInput.text += "M";
                break;
            case "N":
                if (leaderboardNameInput.text.Length < leaderboardNameInput.characterLimit)
                    leaderboardNameInput.text += "N";
                break;
            case "O":
                if (leaderboardNameInput.text.Length < leaderboardNameInput.characterLimit)
                    leaderboardNameInput.text += "O";
                break;
            case "P":
                if (leaderboardNameInput.text.Length < leaderboardNameInput.characterLimit)
                    leaderboardNameInput.text += "P";
                break;
            case "Q":
                if (leaderboardNameInput.text.Length < leaderboardNameInput.characterLimit)
                    leaderboardNameInput.text += "Q";
                break;
            case "R":
                if (leaderboardNameInput.text.Length < leaderboardNameInput.characterLimit)
                    leaderboardNameInput.text += "R";
                break;
            case "S":
                if (leaderboardNameInput.text.Length < leaderboardNameInput.characterLimit)
                    leaderboardNameInput.text += "S";
                break;
            case "T":
                if (leaderboardNameInput.text.Length < leaderboardNameInput.characterLimit)
                    leaderboardNameInput.text += "T";
                break;
            case "U":
                if (leaderboardNameInput.text.Length < leaderboardNameInput.characterLimit)
                    leaderboardNameInput.text += "U";
                break;
            case "V":
                if (leaderboardNameInput.text.Length < leaderboardNameInput.characterLimit)
                    leaderboardNameInput.text += "V";
                break;
            case "W":
                if (leaderboardNameInput.text.Length < leaderboardNameInput.characterLimit)
                    leaderboardNameInput.text += "W";
                break;
            case "X":
                if (leaderboardNameInput.text.Length < leaderboardNameInput.characterLimit)
                    leaderboardNameInput.text += "X";
                break;
            case "Y":
                if (leaderboardNameInput.text.Length < leaderboardNameInput.characterLimit)
                    leaderboardNameInput.text += "Y";
                break;
            case "Z":
                if (leaderboardNameInput.text.Length < leaderboardNameInput.characterLimit)
                    leaderboardNameInput.text += "Z";
                break;
        }
    }
}
