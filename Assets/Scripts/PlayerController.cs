using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour{
    public Rigidbody2D body;
    public AudioClip moveSound;

    float horizontal;
    float vertical;

    public float speed = 2.0f;

    void Start ()
    {
        
    }

    void Update ()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
        AudioSource source = new AudioSource();
        source.clip = moveSound;
        source.Play(); 
    }

    private void FixedUpdate()
    {  
        body.velocity = new Vector2(horizontal * speed, vertical * speed);
    }
}