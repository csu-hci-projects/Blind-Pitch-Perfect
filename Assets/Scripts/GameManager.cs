//some code pulled from https://learn.unity.com/tutorial/2d-roguelike-setup-and-assets?uv=5.x&projectId=5c514a00edbc2a0020694718#

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager instance = null;
    public BoardManager boardScript;
    public static bool stage1 = false;
    public static bool stage2 = false;
    public static bool stage3 = false;
    public static bool stage4 = false;
    public static bool stage5 = false;
    public static bool stage6 = false;

    void Awake(){
        if (instance == null){
            instance = this;
        }
        else if (instance != this){
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
       boardScript = GetComponent<BoardManager>();
        InitGame();
    }

    void InitGame()
    {
      boardScript.SetupScene();
    }
}
