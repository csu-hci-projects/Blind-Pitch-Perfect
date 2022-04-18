//some code pulled from https://learn.unity.com/tutorial/2d-roguelike-setup-and-assets?uv=5.x&projectId=5c514a00edbc2a0020694718#

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loader : MonoBehaviour
{

    public GameObject gameManager;
    void Awake(){
        if (GameManager.instance == null){
            Instantiate(gameManager);
        }
    }

}
