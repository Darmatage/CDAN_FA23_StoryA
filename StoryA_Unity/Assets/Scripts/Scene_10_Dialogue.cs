using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene_10_Dialogue : MonoBehaviour {
        public int primeInt = 1;         // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
       //public Text Char3name;
       //public Text Char3speech;
        public GameObject DialogueDisplay;
        public GameObject ArtChar1a;
       //public GameObject ArtChar1b;
       //public GameObject ArtChar2;
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
        if (primeInt == 1)
        {
            // AudioSource.Play();
        }
        //Basic Text
        else if (primeInt == 2)
        {
            ArtChar1a.SetActive(true);
            DialogueDisplay.SetActive(true);
            Char1name.text = "Narrator";
            Char1speech.text = "The alley is dimly lit, filled with trash and back doors.";
            GameHandler.hasClue1 = true;
            GameHandler.hasClue2 = true;
            GameHandler.hasClue3 = true;
            GameHandler.hasClue4 = true;
            GameHandler.hasClue5 = true;
            GameHandler.hasClue6 = true;
            GameHandler.hasClue7 = true;
            GameHandler.hasClue8 = true;
            GameObject.FindWithTag("PhoneHandler").GetComponent<PhoneHandler>().UpdateCrimeBoard();
        }
        else if (primeInt == 3)
        {
            Char1name.text = "Narrator";
            Char1speech.text = "The only thing of note is a large, bright green dumpster filled to the brim.";
        }
        else if (primeInt == 4)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Choice1a.SetActive(true);
            Choice1b.SetActive(true);
            nextButton.SetActive(false);
            allowSpace = false;
        }

        else if (primeInt == 21)
        {
            Char1name.text = "Narrator";
            Char1speech.text = "Well, hopefully no one?s watching while you do this.";
        }
        else if (primeInt == 22)
        {
            Char1name.text = "Narrator";
            Char1speech.text = "Flipping open the lid you?re hit with the stench of week old garbage.";
        }
        else if (primeInt == 23)
        {
            Char1name.text = "Narrator";
            Char1speech.text = "Plugging your nose you begin to rummage through the garbage.";
        }
        else if (primeInt == 24)
        {
            Char1name.text = "Narrator";
            Char1speech.text = "Nothing...";
        }
        else if (primeInt == 25)
        {
            Char1name.text = "Narrator";
            Char1speech.text = "Nothing.......";
        }
        else if (primeInt == 26)
        {
            Char1name.text = "Narrator";
            Char1speech.text = "Not- wait, what?s that red sparkle.";
        }
        else if (primeInt == 27)
        {
            Char1name.text = "Narrator";
            Char1speech.text = "Plunging your hand in you manage to pull out a red high heel.";
        }
        else if (primeInt == 28)
        {
            Char1name.text = "Narrator";
            Char1speech.text = "One of the same pair you bought your sister last christmas.";
        }
        else if (primeInt == 29)
        {
            Char1name.text = "Narrator";
            Char1speech.text = "Surely, your sister was here, but now where could she be?";
        }
        else if (primeInt == 30)
        {
            Char1name.text = "Narrator";
            Char1speech.text = "Then you see it, a small gap behind the dumpster.";
        }
        else if (primeInt == 31)
        {
            Char1name.text = "Narrator";
            Char1speech.text = "Shoving the dumpster aside you find an old abandoned nuclear bunker, that must be where your sister is.";
        }
        else if (primeInt == 41)
        {
            Char1name.text = "Narrator";
            Char1speech.text = "You start looking at the walls of the alleyway";
        }
        else if (primeInt == 42)
        {
            Char1name.text = "Narrator";
            Char1speech.text = "All brick but the doors are off";
        }
        else if (primeInt == 43)
        {
            Char1name.text = "Narrator";
            Char1speech.text = "They all line up in a row except for where the dumpster is";
        }
        else if (primeInt == 44)
        {
            Char1name.text = "Narrator";
            Char1speech.text = "Almost like there's something there?";
        }
        else if (primeInt == 45)
        {
            Char1name.text = "Narrator";
            Char1speech.text = "Pushing aside the dumpster you find it";
        }
        else if (primeInt == 46)
        {
            Char1name.text = "Narrator";
            Char1speech.text = "A door to an underground shelter, long since abandoned";
        }
        else if (primeInt == 47)
        {
            Char1name.text = "";
            Char1speech.text = "";
            allowSpace = false;
            nextButton.SetActive(false);
            NextScene1Button.SetActive(true);
        }
        else if (primeInt == 32)
        {
            Char1name.text = "";
            Char1speech.text = "";
            allowSpace = false;
            nextButton.SetActive(false);
            NextScene1Button.SetActive(true);
        }
        
        //Please do NOT delete this final bracket that ends the Next() function:
    }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and SceneChanges)
        public void Choice1aFunct(){
                Char1name.text = "Narrator";
                Char1speech.text = "Well hopefully no one's watching while you do this.";
                primeInt = 20;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
                Char1name.text = "Narrator";
                Char1speech.text = "You decide you don't want to be dirty today";
               
                primeInt = 40;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange1(){
               SceneManager.LoadScene("Scene_8");
        }
        public void SceneChange2(){
                SceneManager.LoadScene("Scene2b");
        }
}
