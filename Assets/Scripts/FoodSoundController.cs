using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSoundController : MonoBehaviour
{
     private bool playedOnce = false;
     public AudioClip foodSound;

     void Start ()   
     {
        
         GetComponent<AudioSource> ().playOnAwake = false;
         GetComponent<AudioSource> ().clip = foodSound;
     }        
 
     void OnTriggerEnter2D ()
     {
         if(!playedOnce){
             GetComponent<AudioSource> ().Play();
             this.playedOnce = true;

         }
     }
}
