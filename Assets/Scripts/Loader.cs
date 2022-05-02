using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loader : MonoBehaviour
{

    public GameObject gameManager;
    void Awake(){
        // Debug.Log("i have awoken");
        // if (GameManager.instance == null){
           // Debug.Log("Awake");
            Instantiate(gameManager);
    //    }
    }

}
