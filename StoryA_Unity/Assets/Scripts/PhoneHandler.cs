using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneHandler : MonoBehaviour {

	public GameObject imageClue1;
	public GameObject imageClue2;
	public GameObject imageClue3;
	public GameObject imageClue4;
	public GameObject imageClue5;
	public GameObject imageClue6;
	public GameObject imageClue7;
	public GameObject imageClue8;

	public GameObject CrimeBoardMenu;
	bool CrimeBoardOpen = false;
	
    void Start(){
		CrimeBoardOpen = false;
		CrimeBoardMenu.SetActive(false);
	   
		UpdateCrimeBoard();
    }

	public void UpdateCrimeBoard(){
		if (GameHandler.hasClue1==true){imageClue1.SetActive(true);} else {imageClue1.SetActive(false);}
		if (GameHandler.hasClue2==true){imageClue2.SetActive(true);} else {imageClue2.SetActive(false);}
		if (GameHandler.hasClue3==true){imageClue3.SetActive(true);} else {imageClue3.SetActive(false);}
		if (GameHandler.hasClue4==true){imageClue4.SetActive(true);} else {imageClue4.SetActive(false);}
		if (GameHandler.hasClue5==true){imageClue5.SetActive(true);} else {imageClue5.SetActive(false);}
		if (GameHandler.hasClue6==true){imageClue6.SetActive(true);} else {imageClue6.SetActive(false);}
		if (GameHandler.hasClue7==true){imageClue7.SetActive(true);} else {imageClue7.SetActive(false);}
		if (GameHandler.hasClue8==true){imageClue8.SetActive(true);} else {imageClue8.SetActive(false);} 
	}
	
	public void CrimeBoardMenuToggle(){
		CrimeBoardOpen = !CrimeBoardOpen;
		
		if (CrimeBoardOpen){
			CrimeBoardMenu.SetActive(true);
		} else {CrimeBoardMenu.SetActive(false);}
	}
	
}


//Put into all other scenes:
//1. update clue in GameHandler (change the clue number!): 
//GameHandler.hasClue1 = true;
//2. update clue in PhoneHandler:
//GameObject.FindWithTag("PhoneHandler").GetComponent<PhoneHandler>().UpdateCrimeBoard();


