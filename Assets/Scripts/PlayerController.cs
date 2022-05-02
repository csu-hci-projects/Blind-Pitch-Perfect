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

 
    }

    private void FixedUpdate()
    {  
        //body.AddForce(new Vector2(horizontal * speed, vertical * speed));

        
        body.velocity = new Vector2(horizontal * speed, vertical * speed);
        if(body.velocity != Vector2.zero){
            GetComponent<AudioSource> ().playOnAwake = false;
            GetComponent<AudioSource> ().clip = moveSound;
            if(!GetComponent<AudioSource> ().isPlaying){
                GetComponent<AudioSource> ().Play();
            }
            
        }
    }
}