using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene_1_Dialogue : MonoBehaviour {
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
        public GameObject ArtChar2; //detective
        public GameObject ArtChar3; //PI
        public GameObject ArtBG1;
        public GameObject Choice1a;
        public GameObject Choice1b;
        public GameObject Choice1c;
        public GameObject Choice1d;
        public GameObject Choice1e;
        public GameObject NextScene1Button; // police station
        public GameObject NextScene2Button; // Cafe
        public GameObject NextScene3Button; // Dorm
        public GameObject NextScene4Button; // Park
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
        Choice1c.SetActive(false);
        Choice1d.SetActive(false);
        Choice1e.SetActive(false);
        NextScene1Button.SetActive(false);
        NextScene2Button.SetActive(false);
        NextScene3Button.SetActive(false);
        NextScene4Button.SetActive(false);
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
                Char2name.text = "Narrator";
                Char2speech.text = "It's been a week since anybody last saw your sister";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt ==3){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Narrator";
                Char2speech.text = "Last you heard she was seen out with some friends and never got back home.";
                Char3name.text = "";
                Char3speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Narrator";
                Char2speech.text = "You've been taking some time off of classes just to cope, but with every passing day you feel like she's getting further and further away from being found.";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 5){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Narrator";
                Char2speech.text = "You’ve decided to take this into your own hands and have been slowly organizing whatever clues you can find into a crime board on your phone.";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 6){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Narrator";
                Char2speech.text = " Looking down at your phone you notice you have two missed calls.";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt ==7){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Narrator";
                Char2speech.text = "The first is from a police detective, the one assigned to your sister’s case.";
                Char3name.text = "";
                Char3speech.text = "";
        }
        else if (primeInt ==8){
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "Narrator";
                 Char2speech.text = "He’s been nice but he hasn’t made much of any progress.";
        }
        else if (primeInt ==9){
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "Narrator";
                 Char2speech.text = "The second is from a Private Investigator.";
                 Char3name.text = "";
                 Char3speech.text = "";
        }
        else if (primeInt ==10){
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "Narrator";
                 Char2speech.text = "A childhood friend of yours, he said he’d take up the case “Pro Bono.";
                 Char3name.text = "";
                 Char3speech.text = "";
        }
       else if (primeInt == 11){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Narrator";
                Char2speech.text = "Now you have to decide who you're going to call back first.";
                Char3name.text = "";
                Char3speech.text = "";
                // Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct()
                Choice1b.SetActive(true); // function Choice1bFunct()
        }

       // Call the Police Detective Back First
       else if (primeInt == 20){
                //gameHandler.AddPlayerStat(1);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Narrator";
                Char2speech.text = "The phone rings for a few seconds before it connects";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 21){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Detective";
                Char2speech.text = "Hello?";
                Char3name.text = "";
                Char3speech.text = "";
                ArtChar2.SetActive(true);
        }
        else if (primeInt == 22){
                 Char1name.text = "You";
                 Char1speech.text = "Is this Detective Ralph? This is Blaire's sister, I'm sorry I missed your call.";
                 Char2name.text = "";
                 Char2speech.text = "";
                 Char3name.text = "";
                 Char3speech.text = "";
         }
         else if (primeInt == 23){
                  Char1name.text = "Detective";
                  Char1speech.text = "Oh yes, I was just calling to see if you could come down to the station sometime to see if you could answer some questions.";
                  Char2name.text = "";
                  Char2speech.text = "";
                  Char3name.text = "";
                  Char3speech.text = "";
          }
          else if (primeInt == 24){
                   Char1name.text = "You";
                   Char1speech.text = "You don’t think I’m a suspect do you?";
                   Char2name.text = "";
                   Char2speech.text = "";
                   Char3name.text = "";
                   Char3speech.text = "";
           }
           else if (primeInt == 25){
                    Char1name.text = "Detective";
                    Char1speech.text = "No, No, we just thought you might have some insight into your sister’s habits, movements, where she might have gone.";
                    Char2name.text = "";
                    Char2speech.text = "";
                    Char3name.text = "";
                    Char3speech.text = "";
            }
            else if (primeInt == 26){
                     Char1name.text = "You";
                     Char1speech.text = "Oh, ok.";
                     Char2name.text = "";
                     Char2speech.text = "";
                     Char3name.text = "";
                     Char3speech.text = "";
             }
             else if (primeInt == 27){
                      Char1name.text = "Detective";
                      Char1speech.text = "So whenever you get a chance just come down to the station and we can hopefully get closer to finding your sister.";
                      Char2name.text = "";
                      Char2speech.text = "";
                      Char3name.text = "";
                      Char3speech.text = "";
              }
              else if (primeInt == 28){
                       Char1name.text = "You";
                       Char1speech.text = "Ok, thank you.";
                       Char2name.text = "";
                       Char2speech.text = "";
                       Char3name.text = "";
                       Char3speech.text = "";
               }
               else if (primeInt == 29){
                        Char1name.text = "Detective";
                        Char1speech.text = "No problem, have a great day.";
                        Char2name.text = "";
                        Char2speech.text = "";
                        Char3name.text = "";
                        Char3speech.text = "";
                }
         else if (primeInt == 30){
                  Char1name.text = "Narrator";
                  Char1speech.text = "The detective hangs up, you could go down to the station like he asked, or you could try and find your sister on your own.";
                  Char2name.text = "";
                  Char2speech.text = "";
                  Char3name.text = "";
                  Char3speech.text = "";
                  nextButton.SetActive(false);
                    ArtChar2.SetActive(false);
                  allowSpace = false;
                  Choice1d.SetActive(true); // function Choice1aFunct()
                  Choice1e.SetActive(true); // function Choice1bFunct()
          }

       // Call the private investigator First
       else if (primeInt == 41){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Narrator";
                Char2speech.text = "The Phone barely rings for a second before he picks up";
                Char3name.text = "";
                Char3speech.text = "";
        }
        else if (primeInt == 42){
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "Deacon";
                 Char2speech.text = "Oh hey, thanks for calling back. I had a few things I wanted to talk to you about.";
                 Char3name.text = "";
                 Char3speech.text = "";
                 ArtChar3.SetActive(true);
         }
         else if (primeInt == 43){
                  Char1name.text = "";
                  Char1speech.text = "";
                  Char2name.text = "You";
                  Char2speech.text = "Oh yeah, like what?";
                  Char3name.text = "";
                  Char3speech.text = "";
          }
          else if (primeInt == 44){
                   Char1name.text = "";
                   Char1speech.text = "";
                   Char2name.text = "Deacon";
                   Char2speech.text = "Just some basic info, like what your sister liked to do, who she hung out with, anything to help me get into this case.";
                   Char3name.text = "";
                   Char3speech.text = "";
           }
       else if (primeInt == 45){
                Char1name.text = "YOU";
                Char1speech.text = "If you’re free this morning we could meet at a cafe nearby, great place, really good scones.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1c.SetActive(true); // function Choice1aFunct()
                Choice1e.SetActive(true);
        }
        else if (primeInt == 51){
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "Narrator";
                 Char2speech.text = "You know your sister liked to spend time in the park, so you could see if there’s any info you could find there.";
                 Char3name.text = "";
                 Char3speech.text = "";
         }
         else if (primeInt == 52){
                  Char1name.text = "";
                  Char1speech.text = "";
                  Char2name.text = "Narrator";
                  Char2speech.text = "Otherwise you could go stop by her dorm.";
                  Char3name.text = "";
                  Char3speech.text = "";
          }
          else if (primeInt == 53){
                   Char1name.text = "";
                   Char1speech.text = "";
                   Char2name.text = "Narrator";
                   Char2speech.text = "Maybe talk to her roommates or even her boyfriend she’s been with for the past three months.";
                   Char3name.text = "";
                   Char3speech.text = "";
           }
           else if (primeInt == 54){
                    Char1name.text = "";
                    Char1speech.text = "";
                    Char2name.text = "Narrator";
                    Char2speech.text = "Where to look?";
                    Char3name.text = "";
                    Char3speech.text = "";
                    nextButton.SetActive(false);
                    allowSpace = false;
                    NextScene3Button.SetActive(true);
                    NextScene4Button.SetActive(true);
            }

      //Please do NOT delete this final bracket that ends the Next() function:
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and SceneChanges)
        public void Choice1aFunct(){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Narrator";
                Char2speech.text = "You decide to call the police detective back first.";
                Char3name.text = "";
                Char3speech.text = "";
                primeInt = 19;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Narrator";
                Char2speech.text = "You deicde to call the private investigator back.";
                Char3name.text = "";
                Char3speech.text = "";
                primeInt = 40;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1cFunct(){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "You";
                Char2speech.text = "Uhhh yeah, I'm free, where's this cafe?";
                Char3name.text = "";
                Char3speech.text = "";
                primeInt = 46;
                Choice1c.SetActive(false);
                Choice1e.SetActive(false);
                NextScene2Button.SetActive(true);
        }
        public void Choice1dFunct(){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Narrator";
                Char2speech.text = "You decide to give the police station a visit.";
                Char3name.text = "";
                Char3speech.text = "";
                primeInt = 35;
                Choice1d.SetActive(false);
                Choice1e.SetActive(false);
                NextScene1Button.SetActive(true);
        }
        public void Choice1eFunct(){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Narrator";
                Char2speech.text = "There's not many places where you could look";
                Char3name.text = "";
                Char3speech.text = "";
                primeInt = 50;
                Choice1d.SetActive(false);
                Choice1c.SetActive(false);
                Choice1e.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange1(){
               SceneManager.LoadScene("Scene_3");
        }
        public void SceneChange2(){
                SceneManager.LoadScene("Scene_2");
        }
        public void SceneChange3(){
               SceneManager.LoadScene("Scene_4");
        }
        public void SceneChange4(){
                SceneManager.LoadScene("Scene_5");
        }
}
