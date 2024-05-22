using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu : MonoBehaviour{
public GameObject achievements;
public GameObject stats;
public GameObject mainmenu;
public int no=0;
public bool paused=false;
void Update(){
if(Input.GetKeyUp(KeyCode.Escape) && gameObject.GetComponent<stats>().stunned==false){ 
if(paused){
resume();
paused=false; }
else{
pause();
paused=true;}
}

if(paused == true){
if(no<0)
no=2;
switch(no%3){
case 0:
achievements.SetActive(false);
stats.SetActive(false);
mainmenu.SetActive(true);
break;
case 1:
achievements.SetActive(true);
stats.SetActive(false);
mainmenu.SetActive(false);
break;
case 2:
achievements.SetActive(false);
stats.SetActive(true);
mainmenu.SetActive(false);
break;}
}

if(paused==true){
if(Input.GetKeyDown(KeyCode.D))
no++;
if(Input.GetKeyDown(KeyCode.A))
no--;}



}
public void resume(){
paused = false;
achievements.SetActive(false);
stats.SetActive(false);
mainmenu.SetActive(false);
Time.timeScale=1;
}
public void pause(){
paused= true;
Time.timeScale=0;
}


}
