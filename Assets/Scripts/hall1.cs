using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class hall1 : MonoBehaviour{
public GameObject player;
public GameObject dialogback;
public GameObject tutorialback;
public TMP_Text dialog;
public TMP_Text tutorial;
string[] dialogtext={"The Demon Master: I can feel his power even from here","Dark Warrior: Yes, him! \n But first we must take down his queen. The keeper!","be careful,many people\nfell here because of greed","The Demon Master: Do you think I'm one of those fools\nwho underestimates a demon. Dont worry\nI know what I'm doing","Dark Warrior: Just be careful even she\nis powerful enough to destroy an army in seconds",""};
string[] tutorialtext={"You can use W,A,S,D to walk and Space to dash","You can click the Left Mouse Button to unleash Dark Warrior's Demon Slash! \nAnd hold it to charge an even stronger one","Be careful though if you get damaged\nduring charging you will get interrupted","You can use your potion by pressing Q","You can use statues to save your game\nand refresh your potions","You can press 1 to use your skill, powering up your Demon Slash","You can press ESC to open menu and use A and D\nto move towards menues to see options, achievements or your in game stats."};
void Start(){
player=GameObject.Find("player");
if(player.GetComponent<stats>().dialogcounter==0){ 
GameObject.Find("player").GetComponent<stats>().stunned=true;
Time.timeScale=0;
dialogback.SetActive(true);
dialog.text=dialogtext[player.GetComponent<stats>().dialogcounter];}
}

void Update(){
if(Input.GetKeyDown(KeyCode.Mouse0) && player.GetComponent<stats>().dialogcounter<=5){ 
player.GetComponent<stats>().dialogcounter++;
dialog.text=dialogtext[player.GetComponent<stats>().dialogcounter];}

if(player.GetComponent<stats>().dialogcounter==5){ 
dialogback.SetActive(false);
tutorialback.SetActive(true);}
if(Input.GetKeyDown(KeyCode.Mouse0) && player.GetComponent<stats>().dialogcounter<13 && player.GetComponent<stats>().dialogcounter>=5){
player.GetComponent<stats>().dialogcounter++;
tutorial.text=tutorialtext[player.GetComponent<stats>().dialogcounter-6];}
if(player.GetComponent<stats>().dialogcounter==13){
Time.timeScale=1;
tutorialback.SetActive(false);
dialogback.SetActive(false);
GameObject.Find("player").GetComponent<stats>().stunned=false;
player.GetComponent<stats>().dialogcounter++;
}
}

}
