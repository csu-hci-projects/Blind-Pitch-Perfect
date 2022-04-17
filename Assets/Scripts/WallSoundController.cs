using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSoundController : MonoBehaviour
{
     public AudioClip wallHit;

     void Start ()   
     {
        
         GetComponent<AudioSource> ().playOnAwake = false;
         GetComponent<AudioSource> ().clip = wallHit;
     }        
 
     void OnCollisionEnter2D ()
     {
         GetComponent<AudioSource> ().Play();
     }
}
