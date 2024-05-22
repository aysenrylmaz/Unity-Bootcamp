using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class hall2 : MonoBehaviour{
public GameObject playerprefab;
public GameObject player;
public GameObject dialogback;
public GameObject tutorialback;
public TMP_Text dialog;
public TMP_Text tutorial;
string[] dialogtext={"Dark Warrior: We did it!","Demon Master: I did it. And already told you to not compare me with others."," Dark Warrior: Don't get so cocky this is where your journey really begins","The Satan Awaits"};
string[] tutorialtext={"Now you have the Keeper's Soul. New Power: Shoot Arrows with RMB!","And press 2 to use your new skill!","Also don't forget to save game and refresh your potions from the statues."};
void Start(){
if(GameObject.Find("player")){ 
player=GameObject.Find("player");
if(player.GetComponent<stats>().dialogcounter==14){ 
player.GetComponent<stats>().stunned=true;
Time.timeScale=0;
dialogback.SetActive(true);
dialog.text=dialogtext[player.GetComponent<stats>().dialogcounter-14];}}
else{
Instantiate(playerprefab);
    }
}
void Update(){
if(Input.GetKeyDown(KeyCode.Mouse0) && player.GetComponent<stats>().dialogcounter<18){ 
player.GetComponent<stats>().dialogcounter++;
dialog.text=dialogtext[player.GetComponent<stats>().dialogcounter-14];}

if(player.GetComponent<stats>().dialogcounter==18){ 
dialogback.SetActive(false);
tutorialback.SetActive(true);
tutorial.text=tutorialtext[player.GetComponent<stats>().dialogcounter-18];}
if(Input.GetKeyDown(KeyCode.Mouse0) && player.GetComponent<stats>().dialogcounter<21 && player.GetComponent<stats>().dialogcounter>=18){
player.GetComponent<stats>().dialogcounter++;
tutorial.text=tutorialtext[player.GetComponent<stats>().dialogcounter-18];}
if(player.GetComponent<stats>().dialogcounter==21){
Time.timeScale=1;
tutorialback.SetActive(false);
dialogback.SetActive(false);
GameObject.Find("player").GetComponent<stats>().stunned=false;
player.GetComponent<stats>().dialogcounter++;
}
}
}
