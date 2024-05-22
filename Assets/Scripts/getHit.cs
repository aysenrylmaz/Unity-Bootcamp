using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getHit : MonoBehaviour{
public bool gettinghit=false;
public SpriteRenderer rend;
private Color originalcolor;
public bool die=false;
public GameObject deathscreen;
private void Start(){
rend = GetComponent<SpriteRenderer>();
originalcolor = gameObject.GetComponent<SpriteRenderer>().color;}

void Update(){
if(gettinghit==true && gameObject.GetComponent<stats>().health>0){
rend.color = Color.red;
Invoke("back",0.1f);}
else if(gettinghit==true){
if(gameObject.name=="player")
if(die==false){
gameObject.GetComponent<stats>().deathcounter++;
deathCounter.Save();
die=true;
deathscreen.SetActive(true);
gameObject.GetComponent<stats>().stunned = true;
Time.timeScale=0;
}
}

}


void back(){
rend.color = originalcolor;
gettinghit=false;}





}