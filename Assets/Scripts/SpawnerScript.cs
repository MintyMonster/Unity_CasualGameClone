using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{

    public float max = 3f; // Maximum time between cacti
    private float timer = 0; // Timer variable
    public GameObject cactus; // The cactus prefab
    public float height = 2.2f; // The range in which the cactus can spawn

    // Start is called before the first frame update
    void Start()
    {
        GameObject newCactus = Instantiate(cactus); // Instantiate a new cactus on level start
        newCactus.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0); // Adjust the height randomly so that the gaps are put at different levels
    }

    // Update is called once per frame
    void Update()
    {
        if(timer > max) // if the timer is bigger than the maximum time between cacti
        {
            GameObject newCactus = Instantiate(cactus); // Instantiate a new cactus every time the IF conditions are met
            newCactus.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0); // Set the height placement of the cactus randomly so the gaps are at different levels
            Destroy(newCactus, 15); // Destroy the newly instantiated cactus after 15 seconds
            timer = 0; // Reset the timer to 0
        }

        timer += Time.deltaTime; // Slowly increase the timer based on time passed
    }
}
