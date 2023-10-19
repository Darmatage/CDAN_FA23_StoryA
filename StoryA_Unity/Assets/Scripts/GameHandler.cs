using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

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

	//pause menu variables
        public static bool GameisPaused = false;
        public GameObject pauseMenuUI;
        public AudioMixer mixer;
        public static float volumeLevel = 1.0f;
        private Slider sliderVolumeCtrl;	
	
	
	// public GameObject textGameObject;

        void Awake(){
                SetLevel (volumeLevel);
                GameObject sliderTemp = GameObject.FindWithTag("PauseMenuSlider");
                if (sliderTemp != null){
                        sliderVolumeCtrl = sliderTemp.GetComponent<Slider>();
                        sliderVolumeCtrl.value = volumeLevel;
                }
        }

        void Start(){
                pauseMenuUI.SetActive(false);
                GameisPaused = false;
        }

        void Update(){
                if (Input.GetKeyDown(KeyCode.Escape)){
                        if (GameisPaused){ Resume(); }
                        else{ Pause(); }
                }
                // Stat tester:
                //if (Input.GetKey("p")){
                //       Debug.Log("Player Stat = " + playerStat1);
                //}
        }

        void Pause(){
                pauseMenuUI.SetActive(true);
                Time.timeScale = 0f;
                GameisPaused = true;
        }

        public void Resume(){
                pauseMenuUI.SetActive(false);
                Time.timeScale = 1f;
                GameisPaused = false;
        }

        public void SetLevel (float sliderValue){
                mixer.SetFloat("MusicVolume", Mathf.Log10 (sliderValue) * 20);
                volumeLevel = sliderValue;
        } 


        public void StartGame(){
			Time.timeScale = 1f;
            SceneManager.LoadScene("Scene_1");
        }

        public void OpenCredits(){
			Time.timeScale = 1f;
            SceneManager.LoadScene("Credits");
        }

        public void RestartGame(){
			Time.timeScale = 1f;
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
