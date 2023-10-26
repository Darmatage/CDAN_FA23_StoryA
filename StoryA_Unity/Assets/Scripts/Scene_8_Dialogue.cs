using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene_8_Dialogue : MonoBehaviour {
        public int primeInt = 1;         // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
        public Text Char3name;
        public Text Char3speech;
       //public Text Char3name;
       //public Text Char3speech;
        public GameObject DialogueDisplay;
        public GameObject ArtChar1a;
       //public GameObject ArtChar1b;
        public GameObject ArtChar2;
    public GameObject ArtChar3;
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
        ArtChar2.SetActive(false);
ArtChar3.SetActive(false);
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
        //Basic Text
        else if (primeInt == 2){
                ArtChar1a.SetActive(true);
                DialogueDisplay.SetActive(true);
                Char1name.text = "Narrator";
                Char1speech.text = "The inside of the fallout shelter is dark and is barely lit by your flashlight";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
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
      //Choice
       else if (primeInt == 3){
                Char1name.text = "Narrator";
                Char1speech.text = "You won't be able to search this alone, who should you call:";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                // Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct()
                Choice1b.SetActive(true); // function Choice1bFunct()
        }
        else if (primeInt == 19)//Pi start
        {
            ArtChar1a.SetActive(true);
            ArtChar2.SetActive(true);
            DialogueDisplay.SetActive(true);
            Char1name.text = "Private Investigator";
            Char1speech.text = "What's Up?";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 20)//Pi start
        {
            Char1name.text = "You";
            Char1speech.text = "I found her";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 21)//Pi start
        {
            Char1name.text = "Private Investigator";
            Char1speech.text = "You found her, where?";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 22)//Pi start
        {
            Char1name.text = "You";
            Char1speech.text = "She's somewhere in this fallout shelter, it's right next to club DREAM, in the alleyway";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 23)//Pi start
        {
            Char1name.text = "You";
            Char1speech.text = "I need your help searching this place though it's big, and dark";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 24)//Pi start
        {
            Char1name.text = "Private Investigator";
            Char1speech.text = "Sure thing I'll be right over";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 25)//Pi start
        {
            ArtChar2.SetActive(false);
            Char1name.text = "Narrator";
            Char1speech.text = "Ten minutes pass before he arrives";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 26)//Pi start
        {
              ArtChar2.SetActive(true);
            Char1name.text = "Private Investigator";
            Char1speech.text = "Alright I'm here, let's go in";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 27)//Pi start
        {
            SceneManager.LoadScene("End_Lose3");
        }

        else if (primeInt == 30)//Cop Start
        {
            ArtChar1a.SetActive(true);
            DialogueDisplay.SetActive(true);
            ArtChar3.SetActive(true);
            Char1name.text = "Detective";
            Char1speech.text = "Hello?";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 31)//Pi start
        {
            Char1name.text = "You";
            Char1speech.text = "I think I found my sister";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 32)//Pi start
        {
            Char1name.text = "Detective";
            Char1speech.text = "You think you did, what did you find?";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 33)//Pi start
        {
            Char1name.text = "You";
            Char1speech.text = "I found her shoe in a dumpster out side the club she was";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 34)//Pi start
        {
            Char1name.text = "You";
            Char1speech.text = "And it was right in front of this abandoned fallout shelter";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 35)//Pi start
        {
            Char1name.text = "Detective";
            Char1speech.text = "Alright, sit tight";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 36)//Pi start
        {
            Char1name.text = "Narrator";
            ArtChar3.SetActive(false);
            Char1speech.text = "In five minutes police cars roll up, some cops start cordoning off the area";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 37)//Pi start
        {
            ArtChar3.SetActive(true);
            Char1name.text = "Detective";
            Char1speech.text = "Ok, we'll send some guys in to check you stay here with me";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 38)//Pi start
        {
            Char1name.text = "Narrator";
            Char1speech.text = "A few minutes of silence, then you hear some muffled shouting, before a gunshot echoes through the bunker";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 39)//Pi start
        {
            Char1name.text = "Narrator";
            Char1speech.text = "The police walk out of the bunker with a figure shivering in their arms";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 40)//Pi start
        {
            SceneManager.LoadScene("End_Win");
        }

        //Please do NOT delete this final bracket that ends the Next() function:
    }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and SceneChanges)
        public void Choice1aFunct(){
                Char1name.text = "Narrator";
                Char1speech.text = "You decide to call the private investigator";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                primeInt = 18;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
                Char1name.text = "Narrator";
                Char1speech.text = "You decide to call the police detective";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                primeInt = 29;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange1(){
               SceneManager.LoadScene("End_Lose3");
        }
        public void SceneChange2(){
                SceneManager.LoadScene("End_Win");
        }
}
