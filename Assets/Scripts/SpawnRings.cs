using UnityEngine;

public class SpawnRings : MonoBehaviour
{
    public GameObject ringToSpawn;
    public Transform spawnPosition;
    public GameManager gameManager;
    public GameObject GameOverGO, bastaYungNasaTableGO;

    public bool ringAvailable = false;
    public bool canSpawnAgain = false;

    public void SpawnTheRings() // Spawns the rings
    {
        // Checks if there is still remaining rings, if the spawned ring was picked up, and if the game level is not more than 3
        if (gameManager.level <= 3 && !(gameManager.remainingRings <= 0) && !CheckRingAvailable())
        {
            // If there is still remaining rings, the spawned ring was picked up and the game is not more than 3 then another ring will spawn
            Instantiate(ringToSpawn, spawnPosition.position, Quaternion.identity);
            ringAvailable = true;
            canSpawnAgain = false;
            gameManager.remainingRings -= 1;
            gameManager.UpdateRemainingRings();
        }
        else if (gameManager.remainingRings <= 0 && gameManager.level <= 3)
        {
            // If there are no more remaining rings and the game level is still not more than 3 then set the gamestarted state to false
            // and increase the level by 1
            gameManager.gameStarted = false;
            gameManager.level += 1;
        }
        else if (gameManager.level > 3 && !(gameManager.remainingRings <= 0) && !CheckRingAvailable())
        {
            // If the game level is more than 3, there are no more remaining rings, and if the spawned ring was already picked up
            // then spawn the GameOver screen
            GameOverGO.SetActive(true);
            bastaYungNasaTableGO.SetActive(false);
        }
    }

    public void InteractWithButton()
    {
        // Check if game has started
        if (!gameManager.gameStarted)
        {
            // If it hasn't started, then it starts the game and spawn a ring
            gameManager.StartGame();
            SpawnTheRings();
        }
        else
            // else just spawn a ring
            SpawnTheRings();

    }

    public bool CheckRingAvailable() // Check if the ring spawned is still untouched
    {
        return ringAvailable;
    }
}