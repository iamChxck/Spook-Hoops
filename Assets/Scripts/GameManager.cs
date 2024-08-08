using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TMP_Text scoreText, remainingRingsText, levelText, wristMenuLevelText, wristMenuScoreText;
    public GameObject levelTextGO;
    public GameObject[] currentLevelGO;
    public int remainingRings, maxRings, score, level;
    public bool gameStarted;

    private void Start()
    {
        ResetGame();
        UpdateRemainingRings();
        UpdateScore();
    }

    public void StartGame() // Game Start !!
    {
        GameObject[] rings = GameObject.FindGameObjectsWithTag("Ring");

        foreach(GameObject _rings in rings) // Finds the rings that are still in the scene and destroys them
        {
            Destroy(_rings);
        }

        gameStarted = true;
        levelTextGO.SetActive(true);
        switch(level)// Checks which level the game is on and changes the positions of the monolith based on the level
        {
            case 1:
                currentLevelGO[2].SetActive(false);
                currentLevelGO[0].SetActive(true);
                maxRings = 10;
                UpdateLevel();
                break;
            case 2:
                currentLevelGO[0].SetActive(false);
                currentLevelGO[1].SetActive(true);
                maxRings = 5;
                UpdateLevel();
                break;
            case 3:
                currentLevelGO[1].SetActive(false);
                currentLevelGO[2].SetActive(true);
                maxRings = 3;
                UpdateLevel();
                break;
        }
        remainingRings = maxRings;
        UpdateRemainingRings();
        UpdateScore();
    }
    public void ResetGame() // Reset the game
    {
        gameStarted = false;
        level = 1;
        score = 0;
        maxRings = 10;
        remainingRings = 0;
    }

    public void UpdateLevel() // Updates UI level text
    {
        levelText.text = level.ToString();
        wristMenuLevelText.text = level.ToString();
    }

    public void UpdateRemainingRings() // Updates remaining rings text
    {
        remainingRingsText.text = remainingRings.ToString();
    }

    public void UpdateScore() // Updates score text
    {
        scoreText.text = score.ToString();
        wristMenuScoreText.text = score.ToString();
    }

    public void UpdateLeaderboard(string _name) // Updates the online leaderboard
    {
        HighScores.UploadScore(_name, score);
    }
}
