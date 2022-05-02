using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    public Button nextButton;
    public static bool active;
    Scene currentScene;
    // Start is called before the first frame update
    void Start()
    {
        currentScene = SceneManager.GetActiveScene();
        active = false;
        this.nextButton = nextButton.GetComponent<Button>();
        this.nextButton.onClick.AddListener(OnButtonClick);
        this.nextButton.interactable = false;
    }

    void Update(){
        if(active){
            this.nextButton.interactable = true;
        }
    }

	void OnButtonClick(){
		ExitController.changeScene(currentScene.name);
	}
}
