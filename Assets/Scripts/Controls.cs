using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour
{
    public GameManager gm;
    public float veclocity = 1f;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // Get RigidBody component
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0)) // If touch screen/left mouse button gets pressed
        {
            rb.velocity = Vector2.up * veclocity; // Set the velocity upwards, on the Y axis by the amount of velocity given
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gm.GameOver(); // On collision with cactus or floor, call GameOver function
    }
}
