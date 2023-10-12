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
        public GameObject nextButton;
       //public AudioSource audioSource;
        private bool allowSpace = true;

// initial visibility settings. Any new images or buttons need to also be SetActive(false);
void Start(){  
        DialogueDisplay.SetActive(false);
        ArtChar1a.SetActive(false);
		ArtChar2a.SetActive(false);
		ArtChar3a.SetActive(false);
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
                Char2name.text = "Jeda";
                Char2speech.text = "Wakey wakey, human1.";
				Char3name.text = "";
				Char3speech.text = "";
				Char4name.text = "";
				Char4speech.text = "";
        }
       else if (primeInt ==3){
                Char1name.text = "YOU";
                Char1speech.text = "Wuh..? What happened?2";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
				Char4name.text = "";
				Char4speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Jeda";
                Char2speech.text = "I know I did not hit you that hard.3";
 				Char3name.text = "";
				Char3speech.text = "";
				Char4name.text = "";
				Char4speech.text = "";
       }
       else if (primeInt == 5){
                Char1name.text = "YOU";
                Char1speech.text = "Hit me? Why?4";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
				Char4name.text = "";
				Char4speech.text = "";
        }
       else if (primeInt == 6){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Jeda";
                Char2speech.text = "I am searching for a fugitive. Ragu Fahn.5";
				Char3name.text = "";
				Char3speech.text = "";
				Char4name.text = "";
				Char4speech.text = "";
        }
       else if (primeInt ==7){
                Char1name.text = "YOU";
                Char1speech.text = "Why do you think I know anything?6";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
				Char4name.text = "";
				Char4speech.text = "";
        }
       else if (primeInt == 8){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Jeda";
                Char2speech.text = "I know I did not hit you that hard.7";
				Char3name.text = "";
				Char3speech.text = "";
				Char4name.text = "";
				Char4speech.text = "";
        }
       else if (primeInt == 9){
                Char1name.text = "YOU";
                Char1speech.text = "Hit me? Why?8";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
				Char4name.text = "";
				Char4speech.text = "";
        }
       else if (primeInt == 10){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Jeda";
                Char2speech.text = "I am searching for a fugitive. Ragu Fahn.9";
				Char3name.text = "";
				Char3speech.text = "";
				Char4name.text = "";
				Char4speech.text = "";
        }
       else if (primeInt ==11){
                Char1name.text = "YOU";
                Char1speech.text = "Why do you think I know anything?10";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
				Char4name.text = "";
				Char4speech.text = "";
        }
       else if (primeInt == 12){
                Char1name.text = "YOU";
                Char1speech.text = "Hit me? Why?11";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
				Char4name.text = "";
				Char4speech.text = "";
        }
       else if (primeInt == 13){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Jeda";
                Char2speech.text = "I am searching for a fugitive. Ragu Fahn.12";
				Char3name.text = "";
				Char3speech.text = "";
				Char4name.text = "";
				Char4speech.text = "";
        }
		
       else if (primeInt == 14){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Jeda";
                Char2speech.text = "Do not play the stupid. You will take me to him.13";
                // Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct()
                Choice1b.SetActive(true); // function Choice1bFunct()
        }

       // after choice 1a
       else if (primeInt == 20){
                //gameHandler.AddPlayerStat(1);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Jeda";
                Char2speech.text = "Then you are no use to me, and must be silenced.";
        }
       else if (primeInt == 21){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Jeda";
                Char2speech.text = "Come back here! Do not think you can hide from me!";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
        }

       // after choice 1b
       else if (primeInt == 30){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Jeda";
                Char2speech.text = "Do not think you can fool me, human. Where will we find him?";
        }
       else if (primeInt == 31){
                Char1name.text = "YOU";
                Char1speech.text = "Ragu hangs out in a rough part of town. I'll take you now.";
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
                Char1speech.text = "I don't know what you're talking about!";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 19;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "Sure, anything you want... just lay off the club.";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 29;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange1(){
               SceneManager.LoadScene("Scene2a");
        }
        public void SceneChange2(){
                SceneManager.LoadScene("Scene2b");
        }
}