using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class potion : MonoBehaviour{
public int pots=3;
public int potcounter=0;
public TMP_Text potions;

void Update(){
potions.text=pots.ToString();
if(Input.GetKeyDown(KeyCode.Q) && gameObject.GetComponent<stats>().stunned==false && pots>0 && gameObject.GetComponent<menu>().paused==false){
gameObject.GetComponent<stats>().health+=50;
pots--;
potcounter++;}
}
}
