using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ExitController : MonoBehaviour
{

    Scene currentScene;
    void Start()
    {
        currentScene = SceneManager.GetActiveScene();
    }

    void OnTriggerEnter2D ()
    {
        Timer.success = true;
        ButtonController.active = true;

    }
    public static void changeScene(string sceneName){
        if(sceneName == "Stage1"){
            if(Timer.success){
                GameManager.stage1 = true;
            }
            UnityEngine.SceneManagement.SceneManager.LoadScene("Stage2");
        }
        else if(sceneName == "Stage2"){
            if(Timer.success){
                GameManager.stage2 = true;
            }
            UnityEngine.SceneManagement.SceneManager.LoadScene("Stage3");
        }           
        else if(sceneName == "Stage3"){
            if(Timer.success){
                GameManager.stage3 = true;
            }
            UnityEngine.SceneManagement.SceneManager.LoadScene("Stage4");
        }
        else if(sceneName == "Stage4"){
            if(Timer.success){
                GameManager.stage4 = true;
            }
            UnityEngine.SceneManagement.SceneManager.LoadScene("Stage5");
        }
        else if(sceneName == "Stage5"){
            if(Timer.success){
                GameManager.stage5 = true;
            }
            UnityEngine.SceneManagement.SceneManager.LoadScene("Stage6");
        }
        else if(sceneName == "Stage6"){
            if(Timer.success){
                GameManager.stage6 = true;
            }    
            UnityEngine.SceneManagement.SceneManager.LoadScene("GameOver");
        }

    }
}
