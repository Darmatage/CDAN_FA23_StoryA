using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene_3_Dialogue : MonoBehaviour {
        public int primeInt = 1;         // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
        public Text Char3name;
        public Text Char3speech;
        public Text Char4name;
        public Text Char4speech;	   
        public GameObject DialogueDisplay;
        public GameObject ArtChar1a;
        public GameObject ArtChar1b;
	    public GameObject ArtChar1c;
        public GameObject ArtChar2a;
	    public GameObject ArtChar2b;
	    public GameObject ArtChar2c;
	    public GameObject ArtChar3a;
	    public GameObject ArtChar3b;
	    public GameObject ArtChar3c;
        public GameObject ArtBG1;
        public GameObject Choice1a;
        public GameObject Choice1b;
        public GameObject NextScene1Button;
        public GameObject NextScene2Button;
		public GameObject NextScene3Button;
        public GameObject nextButton;
       //public AudioSource audioSource;
        private bool allowSpace = true;

// initial visibility settings. Any new images or buttons need to also be SetActive(false);
void Start(){  
        DialogueDisplay.SetActive(false);
        ArtChar1a.SetActive(false);
		ArtChar1b.SetActive(false);
		ArtChar1c.SetActive(false);
		ArtChar2a.SetActive(false);
		ArtChar2b.SetActive(false);
		ArtChar2c.SetActive(false);
		ArtChar3a.SetActive(false);
		ArtChar3b.SetActive(false);
		ArtChar3c.SetActive(false);
        ArtBG1.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        NextScene1Button.SetActive(false);
        NextScene2Button.SetActive(false);
		NextScene3Button.SetActive(false);
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
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
				Char4name.text = "NARRATOR";
				Char4speech.text = "You arrive at the police station, the lobby is currently empty except for a bored looking receptionist behind the front desk";
        }
       else if (primeInt ==3){
                ArtChar3a.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "RECEPTIONIST";
				Char3speech.text = "Hello, what can I help you with?";
				Char4name.text = "";
				Char4speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
                Char1name.text = "YOU";
                Char1speech.text = "I’m here to meet with the detective";
                Char2name.text = "";
                Char2speech.text = "";
 				Char3name.text = "";
				Char3speech.text = "";
				Char4name.text = "";
				Char4speech.text = "";
       }
       else if (primeInt == 5){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "RECEPTIONIST";
				Char3speech.text = "Oh yes, just wait one moment and I’ll call him right out";
				Char4name.text = "";
				Char4speech.text = "";
        }
       else if (primeInt == 6){
                ArtChar3a.SetActive(false);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
				Char4name.text = "NARRATOR";
				Char4speech.text = "After a few minutes of waiting for the detective he comes out and heads right over for you";
        }
       else if (primeInt ==7){
                ArtChar2a.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "DETECTIVE";
                Char2speech.text = "Hello PLAYER NAME, thanks for coming by, I just need to ask you a few questions in my office";
				Char3name.text = "";
				Char3speech.text = "";
				Char4name.text = "";
				Char4speech.text = "";
                GameHandler.hasClue2 = true;
                GameObject.FindWithTag("PhoneHandler").GetComponent<PhoneHandler>().UpdateCrimeBoard();
        }
        else if (primeInt == 8){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
				Char4name.text = "NARRATOR";
				Char4speech.text = "Over the course of an hour the detective picks your brain for anything you know about your sister that could possibly help the investigation, likes, dislikes, habits, etc, etc. Afterwards he leads you back into the lobby";
        }
       else if (primeInt == 9){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "DETECTIVE";
				Char3speech.text = "Thank you, this’ll be a real help for the investigation, hopefully we’ll find her soon.";
				Char4name.text = "";
				Char4speech.text = "";
        }
       else if (primeInt == 10){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "DETECTIVE";
				Char3speech.text = "Oh and one more thing.";
				Char4name.text = "";
				Char4speech.text = "";
        }
       else if (primeInt ==11){
                Char1name.text = "YOU";
                Char1speech.text = "?";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
				Char4name.text = "";
				Char4speech.text = "";
        }
       else if (primeInt == 12){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "DETECTIVE";
				Char3speech.text = "I know some folks like to get it in their heads that the cops are clueless and try and solve these kinds of things themselves, but more often than not that leads to another missing persons case on my desk, so just, have some faith ok?";
				Char4name.text = "";
				Char4speech.text = "";
        }
       else if (primeInt == 13){
                Char1name.text = "YOU";
                Char1speech.text = "Sure.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
				Char4name.text = "";
				Char4speech.text = "";
        }
		
       else if (primeInt == 14){
				ArtChar2a.SetActive(false);
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
                //gameHandler.AddPlayerStat(1);
                Char1name.text = "YOU";
                Char1speech.text = "If the cops really were that competent, they would have found her by now.";
				Char4name.text = "";
                Char4speech.text = "";
        }
       else if (primeInt == 21){
                Char1name.text = "YOU";
                Char1speech.text = "The question is now, where to look?";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
				NextScene2Button.SetActive(true);

        }

       // after choice 1b
       else if (primeInt == 30){
                Char1name.text = "YOU";
                Char1speech.text = " It’s honestly better to let the cops handle this, I have classes to focus on anyways, and all this stress isn’t helping me.";
                Char4name.text = "";
                Char4speech.text = "";
        }
		
       else if (primeInt == 31){
                Char1name.text = "YOU";
                Char1speech.text = "I'll head back home for now and collect my thoughts.";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene3Button.SetActive(true);
        }

      //Please do NOT delete this final bracket that ends the Next() function:
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and SceneChanges)
        public void Choice1aFunct(){
                Char1name.text = "";
                Char1speech.text = "";
                Char4name.text = "NARRATOR";
                Char4speech.text = "You decide to look for her yourself.";
                primeInt = 19;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
                Char1name.text = "";
                Char1speech.text = "";
                Char4name.text = "NARRATOR";
                Char4speech.text = "You decide to let the police handle everything.";
                primeInt = 29;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange1(){
               SceneManager.LoadScene("Scene_5");
        }
		public void SceneChange2(){
               SceneManager.LoadScene("Scene_4");
        }
        public void SceneChange3(){
                SceneManager.LoadScene("End_Lose2");
        }
}