using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitikController : MonoBehaviour
{
    private Rigidbody2D rigidBody2D;

    public float xInitialForce;
    public float yInitialForce;


    //Mereset posisi dari objek titik
    private void ResetTitik()
    {
        transform.position = Vector2.zero;

        rigidBody2D.velocity = Vector2.zero;
    }


    //Menggerakan bola
    void PushTitik()
    {
        float InitialForce = Random.Range(-yInitialForce, yInitialForce);

        float randomDirection = Random.Range(0, 2);
        if(randomDirection < 0.1f)
        {
            // Gunakan gaya untuk menggerakkan bola ini.
            rigidBody2D.AddForce(new Vector2(-xInitialForce, -yInitialForce));
        }
        else
        {
            rigidBody2D.AddForce(new Vector2(xInitialForce, yInitialForce));
        }
    }


    void Restart()
    {
        ResetTitik();

        Invoke("PushTitik", 2);
    }

    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();

        Restart();
    }

    
    void Update()
    {
        
    }
}
