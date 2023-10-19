using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene6Dialogue : MonoBehaviour
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
    //public Text Char3name;
    //public Text Char3speech;
    public GameObject DialogueDisplay;
    public GameObject ArtChar1a;
    public GameObject ArtChar2a;
    public GameObject ArtChar3a;
    public GameObject ArtChar4a;
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
    void Start()
    {
        DialogueDisplay.SetActive(false);
        ArtChar1a.SetActive(false);
        ArtBG1.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
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
        //Basic Text
        else if (primeInt == 2)
        {
            ArtChar1a.SetActive(true);
            DialogueDisplay.SetActive(true);
            nextButton.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "NARRATOR";
            Char2speech.text = "In midday the club is abandoned, no one entering or exiting, only a distracted looking bouncer sitting outside the entrance.";
            Char3name.text = "";
            Char3speech.text = "";
            Char4name.text = "";
            Char4speech.text = "";
        }
        else if (primeInt == 3)
        {
            ArtChar1a.SetActive(true);
            DialogueDisplay.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "NARRATOR";
            Char2speech.text = "As you try to enter the bouncer gets up.";
            Char3name.text = "";
            Char3speech.text = "";
            Char4name.text = "";
            Char4speech.text = "";
        }
        else if (primeInt == 4)
        {
            ArtChar1a.SetActive(true);
            ArtChar2a.SetActive(true);
            DialogueDisplay.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "BOUNCER";
            Char3speech.text = "Hey kid, whadda want?";
            Char4name.text = "";
            Char4speech.text = "";
        }
        else if (primeInt == 5)
        {
            ArtChar1a.SetActive(true);
            DialogueDisplay.SetActive(true);
            Char1name.text = "YOU";
            Char1speech.text = "I need to get in here.";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
            Char4name.text = "";
            Char4speech.text = "";
        }
        else if (primeInt == 6)
        {
            ArtChar1a.SetActive(true);
            DialogueDisplay.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "BOUNCER";
            Char3speech.text = "It's off limits now, come back at nine, and pray you're on the guest list. HaHa";
            Char4name.text = "";
            Char4speech.text = "";
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
            // Turn off "Next" button, turn on "Choice" buttons
            nextButton.SetActive(false);
            allowSpace = false;
            Choice1a.SetActive(true); // function Choice1aFunct()
            NextScene1Button.SetActive(true);
        }
        // after choice 1a
        else if (primeInt == 8)
        {
            //gameHandler.AddPlayerStat(1);
            NextScene1Button.SetActive(false);
            nextButton.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "NARRATOR";
            Char2speech.text = "You take out your wallet and pull out a twenty dollar bill.";
            Char3name.text = "";
            Char3speech.text = "";
            Char4name.text = "";
            Char4speech.text = "";
        }
        else if (primeInt == 9)
        {
            //gameHandler.AddPlayerStat(1);
            NextScene1Button.SetActive(false);
            nextButton.SetActive(true);
            Char1name.text = "YOU";
            Char1speech.text = "Are you sure I have to come back?";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
            Char4name.text = "";
            Char4speech.text = "";
        }
        else if (primeInt == 10)
        {
            //gameHandler.AddPlayerStat(1);
            NextScene1Button.SetActive(false);
            nextButton.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "NARRATOR";
            Char2speech.text = "The bouncer pockets the bill and steps aside.";
            Char3name.text = "";
            Char3speech.text = "";
            Char4name.text = "";
            Char4speech.text = "";
        }
        else if (primeInt == 11)
        {
            //gameHandler.AddPlayerStat(1);
            NextScene1Button.SetActive(false);
            nextButton.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "BOUNCER";
            Char3speech.text = "Alright, Alright, just don't cause any trouble";
            Char4name.text = "";
            Char4speech.text = "";
        }
        else if (primeInt == 12)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
            Char4name.text = "";
            Char4speech.text = "";
            // Turn off "Next" button, turn on "Choice" buttons
            ArtChar3a.SetActive(false);
            nextButton.SetActive(false);
            allowSpace = false;
            Choice1b.SetActive(true); // function Choice1aFunct()
            NextScene1Button.SetActive(false);
        }
        // after choice 1b
        else if (primeInt == 13)
        {
            //gameHandler.AddPlayerStat(1);
            ArtChar4a.SetActive(true);
            NextScene1Button.SetActive(false);
            nextButton.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "NARRATOR";
            Char2speech.text = "Walking through the club it’s odd, clubs are not to be fully lit, the tacky furniture is too obvious.";
            Char4name.text = "";
            Char4speech.text = "";
        }
        else if (primeInt == 14)
        {
            //gameHandler.AddPlayerStat(1);
            NextScene1Button.SetActive(false);
            nextButton.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "NARRATOR";
            Char2speech.text = "In the middle of your thought you're stopped by a man in a suit.";
            Char4name.text = "";
            Char4speech.text = "";
        }
        else if (primeInt == 15)
        {
            //gameHandler.AddPlayerStat(1);
            ArtChar4a.SetActive(true);
            NextScene1Button.SetActive(false);
            nextButton.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char4name.text = "MANAGER";
            Char4speech.text = "How the hell did you get in here?";
        }
        else if (primeInt == 16)
        {
            //gameHandler.AddPlayerStat(1);
            NextScene1Button.SetActive(false);
            nextButton.SetActive(true);
            Char1name.text = "YOU";
            Char1speech.text = "Bouncer let me in.";
            Char2name.text = "";
            Char2speech.text = "";
            Char4name.text = "";
            Char4speech.text = "";
        }
        else if (primeInt == 17)
        {
            //gameHandler.AddPlayerStat(1);
            NextScene1Button.SetActive(false);
            nextButton.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char4name.text = "MANAGER";
            Char4speech.text = "That Knucklehead, I outta fire him. What do you want?";
        }
        else if (primeInt == 18)
        {
            //gameHandler.AddPlayerStat(1);
            NextScene1Button.SetActive(false);
            nextButton.SetActive(true);
            Char1name.text = "YOU";
            Char1speech.text = "My sister was kidnapped. she was last seen here";
            Char2name.text = "";
            Char2speech.text = "";
            Char4name.text = "";
            Char4speech.text = "";
        }
        else if (primeInt == 19)
        {
            //gameHandler.AddPlayerStat(1);
            NextScene1Button.SetActive(false);
            nextButton.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char4name.text = "MANAGER";
            Char4speech.text = "So, she was probably picked up off the stret going home.";
        }
        else if (primeInt == 20)
        {
            //gameHandler.AddPlayerStat(1);
            NextScene1Button.SetActive(false);
            nextButton.SetActive(true);
            Char1name.text = "YOU";
            Char1speech.text = "Her home's a block from here.";
            Char2name.text = "";
            Char2speech.text = "";
            Char4name.text = "";
            Char4speech.text = "";
        }
        else if (primeInt == 21)
        {
            //gameHandler.AddPlayerStat(1);
            NextScene1Button.SetActive(false);
            nextButton.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char4name.text = "MANAGER";
            Char4speech.text = "Well, whatever, there's only one way in and out of here.";
        }
        else if (primeInt == 22)
        {
            //gameHandler.AddPlayerStat(1);
            NextScene1Button.SetActive(false);
            nextButton.SetActive(true);
            Char1name.text = "YOU";
            Char1speech.text = "Really?";
            Char2name.text = "";
            Char2speech.text = "";
            Char4name.text = "";
            Char4speech.text = "";
        }
        else if (primeInt == 23)
        {
            //gameHandler.AddPlayerStat(1);
            NextScene1Button.SetActive(false);
            nextButton.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char4name.text = "MANAGER";
            Char4speech.text = "Well...Except for the back entrance, but only the janitors use that.";
        }
        else if (primeInt == 24)
        {
            //gameHandler.AddPlayerStat(1);
            NextScene1Button.SetActive(false);
            nextButton.SetActive(true);
            Char1name.text = "YOU";
            Char1speech.text = "Where does that lead?";
            Char2name.text = "";
            Char2speech.text = "";
            Char4name.text = "";
            Char4speech.text = "";
        }
        else if (primeInt == 25)
        {
            //gameHandler.AddPlayerStat(1);
            NextScene1Button.SetActive(false);
            nextButton.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char4name.text = "MANAGER";
            Char4speech.text = "To the alley behind the club, look I can show you...";
        }
        else if (primeInt == 26)
        {
            //gameHandler.AddPlayerStat(1);
            NextScene1Button.SetActive(false);
            nextButton.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "NARRATOR";
            Char2speech.text = "The Manager brings you out the back entrance into the alleyway.";
            Char4name.text = "";
            Char4speech.text = "";
        }
        else if (primeInt == 27)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
            // Turn off "Next" button, turn on "Choice" buttons
            nextButton.SetActive(false);
            allowSpace = false;
            Choice1a.SetActive(false); // function Choice1aFunct()
            NextScene1Button.SetActive(true);
        }
        //Please do NOT delete this final bracket that ends the Next() function:
    }

    // FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and SceneChanges)
    public void Choice1aFunct()
    {
        Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "NARRATOR";
        Char2speech.text = "You take out your wallet and pull out a twenty dollar bill.";
        Char3name.text = "";
        Char3speech.text = "";
        primeInt = 8;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }
    public void Choice1bFunct()
    {
        Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "NARRATOR";
        Char2speech.text = "Walking through the club it’s odd, clubs are not to be fully lit, the tacky furniture is too obvious.";
        Char3name.text = "";
        Char3speech.text = "";
        primeInt = 13;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        nextButton.SetActive(true);
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
