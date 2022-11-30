using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public GameObject gameOver;
    public GameObject balloon;
    public GameObject score;

    private void Start()
    {
        Time.timeScale = 1f; // Set the rate in which time passed to be normal. 0 = frozen, 1 = normal
    }

    public void GameOver() // Game over function
    {
        GameObject[] cacti = GameObject.FindGameObjectsWithTag("Cactus"); // Find all cactus and destroy
        foreach(GameObject cac in cacti) // foreach cactus in "cacti" array
        {
            Destroy(cac); // Destroy cactus given from foreach loop
        }

        Destroy(balloon); // "Pop" balloon
        gameOver.SetActive(true); // Activate the game over screen
        score.SetActive(false); // de-activate the score card
        Time.timeScale = 0f; // Freeze the game
    }

    public void Restart() => SceneManager.LoadScene(1); // Reload the entire scene from the start on button press
}
