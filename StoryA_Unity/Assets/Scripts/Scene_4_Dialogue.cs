using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene_4_Dialogue : MonoBehaviour
{
    public int primeInt = 1;         // This integer drives game progress!
    public Text Char1name;
    public Text Char1speech;
    public Text Char2name;
    public Text Char2speech;
    public Text Char3name;
    public Text Char3speech;
    public Text Char4name;
    public Text Char4speech;
    public Text Char5name;
    public Text Char5speech;
    public GameObject DialogueDisplay;
    public GameObject ArtChar1a;
    //public GameObject ArtChar1b;
    public GameObject ArtChar2a; //ROOMMATE
    public GameObject ArtChar4a; //BOYFRIEND
    public GameObject ArtChar5a; //RA
    public GameObject ArtBG1;
    public GameObject Choice1a;
    public GameObject Choice1b;
    public GameObject Choice1c;
    public GameObject NextScene1Button;
    public GameObject NextScene2Button;
    public GameObject nextButton;
    //public AudioSource audioSource;
    private bool allowSpace = true;
    private bool Sister_Location = false;

    // initial visibility settings. Any new images or buttons need to also be SetActive(false);
    void Start()
    {
        DialogueDisplay.SetActive(false);
        ArtChar1a.SetActive(false);
        ArtChar2a.SetActive(false);
        ArtChar4a.SetActive(false);
        ArtChar5a.SetActive(false);
        ArtBG1.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        Choice1c.SetActive(false);
        NextScene1Button.SetActive(false);
        NextScene2Button.SetActive(false);
        nextButton.SetActive(true);
    }

    void Update()
    {         // use spacebar as Next button
        if (allowSpace == true)
        {
            if (Input.GetKeyDown("space"))
            {
                Next();
            }
        }
    }

    //Story Units! The main story function. Players hit [NEXT] to progress to the next primeInt:
    public void Next()
    {
        primeInt = primeInt + 1;
        if (primeInt == 1)
        {
            // AudioSource.Play();
        }
        else if (primeInt == 2)
        {
            ArtChar1a.SetActive(true);
            DialogueDisplay.SetActive(true);
            nextButton.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "NARRATOR";
            Char3speech.text = "You arrive at your sisters dorm.";
            Char4name.text = "";
            Char4speech.text = "";
            Char5name.text = "";
            Char5speech.text = "";
        }
        else if (primeInt == 3)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "NARRATOR";
            Char3speech.text = "She’s been going to college for two years now, you’re the only family close to where she lives. You have a few options for who to talk to.";
            Char4name.text = "";
            Char4speech.text = "";
            Char5name.text = "";
            Char5speech.text = "";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 4)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "NARRATOR";
            Char3speech.text = "Firstly her roommate, they were randomly assigned so they’re not that close, but perhaps they’ll have some insight to your sister’s coming and goings";
            Char4name.text = "";
            Char4speech.text = "";
            Char5name.text = "";
            Char5speech.text = "";
        }
        else if (primeInt == 5)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "NARRATOR";
            Char3speech.text = "Secondly her boyfriend, they’ve been together since the start of college, though you’ve only met him once or twice, the experience left a bad taste in your mouth, but he was probably with her when she disappeared.";
            Char4name.text = "";
            Char4speech.text = "";
            Char5name.text = "";
            Char5speech.text = "";
        }
        else if (primeInt == 6)
        {
            ArtChar1a.SetActive(true);
            DialogueDisplay.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "NARRATOR";
            Char3speech.text = "Finally her RA, it’s their job to know about the residents they’re assigned to so maybe they’ll know something";
            Char4name.text = "";
            Char4speech.text = "";
            Char5name.text = "";
            Char5speech.text = "";
        }
        else if (primeInt == 7)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
            Char4name.text = "";
            Char4speech.text = "";
            Char5name.text = "";
            Char5speech.text = "";
            // Turn off "Next" button, turn on "Choice" buttons
            nextButton.SetActive(false);
            allowSpace = false;
            Choice1a.SetActive(true); // function Choice1aFunct()
            Choice1b.SetActive(true); // function Choice1bFunct()
            Choice1c.SetActive(true); // function Choice1cFunct()
            nextButton.SetActive(false);
        }

        // after choice 1a

        else if (primeInt == 21)
        {
            //gameHandler.AddPlayerStat(1);
            Char1name.text = "YOU";
            Char1speech.text = "I’m SISTER’S NAME’s sister";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 22)
        {
            //gameHandler.AddPlayerStat(1);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "ROOMMATE";
            Char2speech.text = "Oh my gosh! I’m so sorry that this has happened to you, you must be going through a lot.";
        }
        else if (primeInt == 23)
        {
            //gameHandler.AddPlayerStat(1);
            Char1name.text = "YOU";
            Char1speech.text = "Thanks, do you know where she was the night before?";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 24)
        {
            //gameHandler.AddPlayerStat(1);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "ROOMMATE";
            Char2speech.text = "Well she was out with her boyfriend I know that, we’re not really close";
        }
        else if (primeInt == 25)
        {
            Char1name.text = "YOU";
            Char1speech.text = "So you don't know where she could be?";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 26)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "ROOMMATE";
            Char2speech.text = "She likes to go clubbing a lot, but she goes to so many different ones I just cant remember. Sorry.";
        }
        else if (primeInt == 27)
        {
            Char1name.text = "YOU";
            Char1speech.text = "Okay, thanks for the help.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 28)
        {
            ArtChar2a.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char3name.text = "NARRATOR";
            Char3speech.text = "Now what to do.";
        }
        else if (primeInt == 29)
        {
            ArtChar2a.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
            nextButton.SetActive(false);
            allowSpace = false;
            Choice1b.SetActive(true); // function Choice1bFunct()
            Choice1c.SetActive(true); // function Choice1cFunct()
            if (Sister_Location == true) {
              NextScene1Button.SetActive(true);
            }
        }
        // after choice 1b

        else if (primeInt == 31)
        {
            Char1name.text = "YOU";
            Char1speech.text = "Im SISTER'S NAME's sister ";
            Char3name.text = "";
            Char3speech.text = "";
            Char5name.text = "";
            Char5speech.text = "";
        }
        else if (primeInt == 32)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
            Char5name.text = "BOYFRIEND";
            Char5speech.text = "Look, I don't know anything ok, I didn't do it.";
        }
        else if (primeInt == 33)
        {
            Char1name.text = "YOU";
            Char1speech.text = "When did you last see her?";
            Char3name.text = "";
            Char3speech.text = "";
            Char5name.text = "";
            Char5speech.text = "";
        }
        else if (primeInt == 34)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
            Char5name.text = "BOYFRIEND";
            Char5speech.text = "A week ago of course, we were out, I got fucked up, lost sight of her, that’s that.";
        }
        else if (primeInt == 35)
        {
            Char1name.text = "YOU";
            Char1speech.text = "You were with her? Where were you?";
            Char3name.text = "";
            Char3speech.text = "";
            Char5name.text = "";
            Char5speech.text = "";
        }
        else if (primeInt == 36)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
            Char5name.text = "BOYFRIEND";
            Char5speech.text = "A place called Dream, we go there every once in a while";
            Sister_Location = true;
        }
        else if (primeInt == 37)
        {
            Char1name.text = "YOU";
            Char1speech.text = "And you never went back to try and find her?";
            Char3name.text = "";
            Char3speech.text = "";
            Char5name.text = "";
            Char5speech.text = "";
        }
        else if (primeInt == 38)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
            Char5name.text = "BOYFRIEND";
            Char5speech.text = "Look, I'm busy ok, why don't you shove off let the cops handle this.";
        }
        else if (primeInt == 39)
        {
            ArtChar5a.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char3name.text = "NARRATOR";
            Char3speech.text = "He storms off. Now what to do?";
            Char5name.text = "";
            Char5speech.text = "";
        }
        else if (primeInt == 40)
        {
            ArtChar5a.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
            Char5name.text = "";
            Char5speech.text = "";

            Choice1a.SetActive(true); // function Choice1bFunct()
            Choice1c.SetActive(true); // function Choice1cFunct()
            if (Sister_Location == true) {
              NextScene1Button.SetActive(true);
            }
            nextButton.SetActive(false);
        }
        // after choice 1c
        else if (primeInt == 42)
        {
            Char1name.text = "YOU";
            Char1speech.text = "Yeah, do you know where she was when she disappeared?";
            Char3name.text = "";
            Char3speech.text = "";
            Char4name.text = "";
            Char4speech.text = "";
        }
        else if (primeInt == 43)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
            Char4name.text = "RA";
            Char4speech.text = "No, I just know she was out with friends and then never came back, I submitted the missing persons to the police when her roommate said she never showed up again";
        }
        else if (primeInt == 45)
        {
            Char1name.text = "YOU";
            Char1speech.text = "Do you know anything else?";
            Char3name.text = "";
            Char3speech.text = "";
            Char4name.text = "";
            Char4speech.text = "";
        }
        else if (primeInt == 46)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
            Char4name.text = "RA";
            Char4speech.text = "No that's all I know, I wish I could do more to help you.";
        }
        else if (primeInt == 47)
        {
            ArtChar4a.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char3name.text = "NARRATOR";
            Char3speech.text = "Now what to do?";
            Char4name.text = "";
            Char4speech.text = "";
        }
        else if (primeInt == 48)
        {
            ArtChar4a.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
            Char4name.text = "";
            Char4speech.text = "";
            nextButton.SetActive(false);
            Choice1a.SetActive(true); // function Choice1bFunct()
            Choice1b.SetActive(true); // function Choice1cFunct()
            if (Sister_Location == true) {
              NextScene1Button.SetActive(true);
            }
        }
    }

    private void Choice1aFunct()
    {
        Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "ROOMMATE";
        Char2speech.text = "Oh hey, who are you?";
        primeInt = 20;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        Choice1c.SetActive(false);
        nextButton.SetActive(true);
        ArtChar2a.SetActive(true);
        NextScene1Button.SetActive(false);
        allowSpace = true;
    }
    public void Choice1bFunct()
    {
            Char1name.text = "";
            Char1speech.text = "";
            Char5name.text = "BOYFRIEND";
            Char5speech.text = "What do you want?";
            primeInt = 30;
            Choice1a.SetActive(false);
            Choice1b.SetActive(false);
            Choice1c.SetActive(false);
            nextButton.SetActive(true);
            ArtChar5a.SetActive(true);
            NextScene1Button.SetActive(false);
            allowSpace = true;
    }
    public void Choice1cFunct()
    {
        Char1name.text = "";
        Char1speech.text = "";
        Char4name.text = "RA";
        Char4speech.text = "You must be SISTER’S NAME’s sibling, you must really be going through a lot.";
        primeInt = 41;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        Choice1c.SetActive(false);
        ArtChar4a.SetActive(true);
        nextButton.SetActive(true);
        NextScene1Button.SetActive(false);
        allowSpace = true;
    }

    public void SceneChange1()
    {
        SceneManager.LoadScene("Scene2a");
    }
    public void SceneChange2()
    {
        SceneManager.LoadScene("Scene2b");
    }
}
