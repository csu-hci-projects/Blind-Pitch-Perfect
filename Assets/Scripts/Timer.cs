using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float targetTime = 60.0f;
    public Text counterText;
    public static bool success;
    Scene currentScene;
    void Start()
    {
        success = false;
        currentScene = SceneManager.GetActiveScene();
    }

    // Update is called once per frame
    void Update(){
        targetTime -= Time.deltaTime;
        counterText.text = ((int)targetTime).ToString();
        if(success){
            counterText.text = "SUCCESS";
        }
        if (targetTime <= 0.0f)
        {
            timeUp();
        } 
    }
    void timeUp(){
        counterText.text = "FAIL";
        ExitController.changeScene(currentScene.name);

    }
}
