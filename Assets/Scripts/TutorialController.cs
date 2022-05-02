using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
public class TutorialController : MonoBehaviour
{

    public Text tutorialText;
    public Button nextButton;
    public AudioClip footsteps;
    public AudioClip nearbySound;
    private int tutorialStage = 1;

    // Start is called before the first frame update
    void Start()
    {
        tutorialText.text = "This is the sound of foosteps";
        this.nextButton = nextButton.GetComponent<Button>();
        this.nextButton.onClick.AddListener(OnButtonClick);
    }
	void OnButtonClick(){
        if(tutorialStage == 1){
            tutorialText.text = "This is the sound that you're nearby the exit";
            GetComponent<AudioSource> ().Stop();
            GetComponent<AudioSource> ().clip = nearbySound;
            GetComponent<AudioSource> ().Play();
            tutorialStage++;
        }
        else if(tutorialStage == 2){
            tutorialText.text = "There are 6 stages. You have 1 minute per stage. Press next to start. GOOD LUCK";
            tutorialStage++;
            GetComponent<AudioSource> ().Stop();
        }
        else if(tutorialStage == 3){
            UnityEngine.SceneManagement.SceneManager.LoadScene("Stage1");
        }


	}
}
