using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene_5_Dialogue : MonoBehaviour {
        public int primeInt = 1;         // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;	   
        public GameObject DialogueDisplay;
        public GameObject ArtChar1a;
        public GameObject ArtChar1b;
	    public GameObject ArtChar1c;
        public GameObject ArtBG1;
        public GameObject Choice1a;
        public GameObject Choice1b;
        public GameObject NextScene1Button;
        public GameObject NextScene2Button;
        public GameObject nextButton;
       //public AudioSource audioSource;
        private bool allowSpace = true;

// initial visibility settings. Any new images or buttons need to also be SetActive(false);
void Start(){  
        DialogueDisplay.SetActive(false);
        ArtChar1a.SetActive(false);
		ArtChar1b.SetActive(false);
		ArtChar1c.SetActive(false);
        ArtBG1.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        NextScene1Button.SetActive(false);
        NextScene2Button.SetActive(false);
        nextButton.SetActive(true);
   }

void Update(){         // use spacebar as Next button
        if (allowSpace == true){
                if (Input.GetKeyDown("space")){
                       Next();
                }
        }
   }

//Story Units! The main story function. Players hit [NEXT] to progress to the next primeInt:
public void Next(){
        primeInt = primeInt + 1;
        if (primeInt == 1){
                // AudioSource.Play();
        }
        else if (primeInt == 2){
                ArtChar1a.SetActive(true);
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "NARRATOR";
                Char2speech.text = "You arrive at the park.";
				
        }
       else if (primeInt ==3){
				Char1name.text = "YOU";
                Char1speech.text = "She always loved the park, it reminded her of the woods she liked to wander back home.";
                Char2name.text = "";
                Char2speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
                Char1name.text = "YOU";
                Char1speech.text = "Her dorm is right next door so she used to come here all the time.";
                Char2name.text = "";
                Char2speech.text = "";

       }
       else if (primeInt == 5){
                Char1name.text = "YOU";
                Char1speech.text = "This park isn't very big, but maybe there is something useful here.";
                Char2name.text = "";
                Char2speech.text = "";

        }
       
       else if (primeInt == 6){
                Char1name.text = "YOU";
                Char1speech.text = "I wonder what I should do next?";
                Char2name.text = "";
                Char2speech.text = "";
                // Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct()
                Choice1b.SetActive(true); // function Choice1bFunct()
        }

       // after choice 1a
       else if (primeInt == 20){
                Char1name.text = "";
                Char1speech.text = "";
				Char2name.text = "NARRATOR";
                Char2speech.text = "You decide to look in her dorm.";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);

        }

       // after choice 1b
       else if (primeInt == 30){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "NARRATOR";
                Char2speech.text = "You think over what you know…";
        }
		
		else if (primeInt == 31){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "NARRATOR";
                Char2speech.text = "You know your sister’s dorm is right next to the park.";
        }
		
		else if (primeInt == 32){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "NARRATOR";
                Char2speech.text = "You also know she liked to go to a lot of different local businesses around the area.";
        }
		
		else if (primeInt == 33){
                Char1name.text = "YOU";
                Char1speech.text = "I can't seem to find any clues in the park. Maybe she went to someplace near the park?";
                Char2name.text = "";
                Char2speech.text = "";
        }		
		
		else if (primeInt == 34){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "NARRATOR";
                Char2speech.text = "You begin to walk the periphery of the park, looking for any place you think your sister would go.";
		}
		
		else if (primeInt == 35){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "NARRATOR";
                Char2speech.text = "Finally a neon sign catches your eye, reading: CLUB DREAM";
            GameHandler.hasClue1 = true;
            GameHandler.hasClue2 = true;
            GameHandler.hasClue4 = true;
            GameObject.FindWithTag("PhoneHandler").GetComponent<PhoneHandler>().UpdateCrimeBoard();
        }		
		
       else if (primeInt == 36){
                Char1name.text = "YOU";
                Char1speech.text = "I know she used to go clubbing all the time. It won't hurt to check quick.";
				Char2name.text = "";
                Char2speech.text = "";	
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene2Button.SetActive(true);
        }

      //Please do NOT delete this final bracket that ends the Next() function:
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and SceneChanges)
        public void Choice1aFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "Maybe i'll check out her dorm room since its right here.";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 19;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "NARRATOR";
                Char2speech.text = "You decide to try and retrace your sister’s steps.";
                primeInt = 29;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange1(){
               SceneManager.LoadScene("Scene_4");
        }
		public void SceneChange2(){
               SceneManager.LoadScene("Scene_6");
        }

}