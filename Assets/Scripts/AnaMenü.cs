using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnaMenü : MonoBehaviour{
public GameObject player;
public GameObject loadscreen;
public GameObject playerattack;
public GameObject playerbow;
public GameObject controls;
public GameObject info;
public GameObject options;
public GameObject credits;
private void OnEnable(){
player=GameObject.Find("player");
playerattack=GameObject.Find("player attack");
playerbow=GameObject.Find("player bow");}


public void back(){
Destroy(player);
Destroy(playerattack);
Destroy(playerbow);
SceneManager.LoadScene(0);}

public void cikis(){
Application.Quit();
}

public void control(){
controls.SetActive(true);}

public void x1(){
controls.SetActive(false);}

public void option(){
options.SetActive(true);}

public void x2(){
options.SetActive(false);}

public void credit(){
credits.SetActive(true);}

public void x3(){
credits.SetActive(false);}

}