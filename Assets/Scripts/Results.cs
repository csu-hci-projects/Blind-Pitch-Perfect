using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Results : MonoBehaviour
{
    string resultsText;
    public Text result;
    // Start is called before the first frame update
    void Start()
    {
        resultsText += "Game Over\n";
        if(GameManager.stage1){
            resultsText += "Stage 1: Success \n";
        }
        else if(!GameManager.stage1){
            resultsText += "Stage 1: Fail \n";
        }
        if(GameManager.stage2){
            resultsText += "Stage 2: Success \n";
        }
        else if(!GameManager.stage2){
            resultsText += "Stage 2: Fail \n";
        }
        if(GameManager.stage3){
            resultsText += "Stage 3: Success \n";
        }
        else if(!GameManager.stage3){
            resultsText += "Stage 3: Fail \n";
        }
        if(GameManager.stage4){
            resultsText += "Stage 4: Success \n";
        }
        else if(!GameManager.stage4){
            resultsText += "Stage 4: Fail \n";
        }
        if(GameManager.stage5){
            resultsText += "Stage 5: Success \n";
        }
        else if(!GameManager.stage5){
            resultsText += "Stage 5: Fail \n";
        }
        if(GameManager.stage6){
            resultsText += "Stage 6: Success \n";
        }
        else if(!GameManager.stage6){
            resultsText += "Stage 6: Fail \n";
        }
        result.text = resultsText.ToString();
    }
}
