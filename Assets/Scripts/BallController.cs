using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Random = UnityEngine.Random;
using Vector2 = UnityEngine.Vector2;

public class BallController : MonoBehaviour
{
    public Rigidbody2D rb;
    public Vector2[] startDirection;
    public float speed;
    public AudioSource ballSound;

    private int selectedDirection;
    // Start is called before the first frame update
    void Start()
    {
        selectedDirection = Random.Range(0, 3);
        rb.velocity = startDirection[selectedDirection] * speed;
        
    }
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (!other.gameObject.CompareTag("RightBorder") && !other.gameObject.CompareTag("LeftBorder") )
        {
            ballSound.Play();
        }
        
        if (other.gameObject.CompareTag("LeftBorder"))
        {
            GameObject.FindObjectOfType<GameController>().UpdateP2Score();
        }
        if (other.gameObject.CompareTag("RightBorder"))
        {
            GameObject.FindObjectOfType<GameController>().UpdateP1Score();
        }
        
    }

}
