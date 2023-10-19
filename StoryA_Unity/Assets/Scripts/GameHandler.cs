using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameHandler : MonoBehaviour{

//clue variables
	public static bool hasClue1 = false; //met PI, scene 2
	public static bool hasClue2 = false; //met detective, scene 3
	public static bool hasClue3 = false; 
	public static bool hasClue4 = false; 
	public static bool hasClue5 = false; 
	public static bool hasClue6 = false; 
	public static bool hasClue7 = false; 
	public static bool hasClue8 = false;

	
	// public GameObject textGameObject;

	void Start () { 
	   //UpdateScore (); 

	}

        void Update(){         //delete this quit functionality when a Pause Menu is added!
                if (Input.GetKey("escape")){
                        Application.Quit();
                }

                // Stat tester:
                //if (Input.GetKey("p")){
                //       Debug.Log("Player Stat = " + playerStat1);
                //}
        }

        // void UpdateScore () {
        //        Text scoreTemp = textGameObject.GetComponent<Text>();
        //        scoreTemp.text = "Score: " + score; }

        public void StartGame(){
                SceneManager.LoadScene("Scene_1");
        }

        public void OpenCredits(){
                SceneManager.LoadScene("Credits");
        }

        public void RestartGame(){
                SceneManager.LoadScene("MainMenu");
        }

        public void QuitGame(){
                #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
                #else
                Application.Quit();
                #endif
        }
			
}
