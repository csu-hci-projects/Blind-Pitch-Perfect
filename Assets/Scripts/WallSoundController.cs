using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class WallSoundController : MonoBehaviour
{
     private bool playedOnce = false;
     public AudioClip wallHit;
    Scene currentScene;
     void Start ()   
     {
         currentScene = SceneManager.GetActiveScene();
         GetComponent<AudioSource> ().playOnAwake = false;
         GetComponent<AudioSource> ().clip = wallHit;
     }        
 
     void OnCollisionEnter2D ()
     {
        
        if(!playedOnce && ((currentScene.name == "Stage1") || (currentScene.name == "Stage6"))){
            this.playedOnce = true;
            GetComponent<AudioSource> ().Play();
        }
        else if(!playedOnce && ((currentScene.name == "Stage2") || (currentScene.name == "Stage4"))){
            this.playedOnce = true;
            GetComponent<AudioSource>().pitch = 2.0f;
            GetComponent<AudioSource> ().Play();
        }
        else if(!playedOnce && ((currentScene.name == "Stage3") || (currentScene.name == "Stage5"))){
            this.playedOnce = true;
            GetComponent<AudioSource>().pitch = 0.3f;
            GetComponent<AudioSource> ().Play();
        }
     }
}
