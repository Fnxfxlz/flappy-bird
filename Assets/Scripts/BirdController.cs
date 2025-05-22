using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 

public class BirdController : MonoBehaviour
{
    Rigidbody2D bird;  
    int score = 0;
    public Text scoreUI;
    public bool isAlive;
    public float flyForce;
    // Start is called before the first frame update
    void Start()
    {
        bird = GetComponent<Rigidbody2D>();

        isAlive = true;

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isAlive == true)
        {
            
            bird.AddForce(Vector2.up * flyForce, ForceMode2D.Impulse);
        }
    }
    
    void  OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Points"))
        {
            score = score + 1;

            scoreUI.text = score.ToString();
        }

    }
    void OnCollisionEnter2D(Collision2D collison)
    {
        isAlive = false;
    }
    
}


