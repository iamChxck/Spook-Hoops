using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ring : MonoBehaviour
{
    GameManager gameManager;
    SpawnRings spawnRings;
    bool canScore = true;

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        spawnRings = FindObjectOfType<SpawnRings>();
    }
    private void OnTriggerEnter(Collider other)
    {
        //Checks if the ring has collided with the monoliths
        if(other.CompareTag("Monolith") && canScore)
        {
            gameManager.score += 1;
            gameManager.UpdateScore();
            canScore = false;
        }
        if (other.CompareTag("Monolith2") && canScore)
        {
            gameManager.score += 5;
            gameManager.UpdateScore();
            canScore = false;
        }
        if (other.CompareTag("Monolith3") && canScore)
        {
            gameManager.score += 10;
            gameManager.UpdateScore();
            canScore = false;
        }
    }

    public void GrabRing()
    {
        // Tells the game if it can spawn another rings or not
        spawnRings.ringAvailable = false;
    }
}
