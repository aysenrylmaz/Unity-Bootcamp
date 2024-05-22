using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class newGame : MonoBehaviour{
public GameObject loadscreen;

public void gamestart(){
loadscreen.SetActive(true);
SceneManager.LoadScene(7);
Data.newgameopened = true;}

}


