using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private KeyCode _keyUp;
    [SerializeField] private KeyCode _keyDown;
   
    private Rigidbody2D _rb;
    public float speed;


    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(_keyUp))
        {
            transform.position += transform.up * speed * Time.deltaTime;
        }
        if (Input.GetKey(_keyDown))
        {
            transform.position -= transform.up * speed * Time.deltaTime;
        }
        
    }
}
