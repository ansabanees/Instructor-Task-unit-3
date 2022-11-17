using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public bool gameOver;

    public float floatForce;
    private float gravityModifier = 1.5f;
    private Rigidbody playerRb;
    private float upperBound = 13.0f;


    // Start is called before the first frame update
    void Start()
    {
        Physics.gravity *= gravityModifier;
        

        // Apply a small upward force at the start of the game

        {
            playerRb = GetComponent<Rigidbody>();
            playerRb.AddForce(Vector3.up * 5, ForceMode.Impulse);
        }
    }

    // Update is called once per frame
    void Update()
    {
        // While space is pressed and player is low enough, float up
        if (Input.GetKey(KeyCode.Space) && !gameOver && transform.position.y < upperBound)
        {
            playerRb.AddForce(Vector3.up * floatForce);
        }
    }

   
      
    
}
