using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{

    public static int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        score = 0; // Reset the score to 0
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<UnityEngine.UI.Text>().text = score.ToString(); // Get the Text componenet from the UI, set the content of the text component to the score.
    }
}
