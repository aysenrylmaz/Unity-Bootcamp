using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerPool : MonoBehaviour{
public GameObject fadingplayer;
public Queue<GameObject> fadingimages=new Queue<GameObject>();
public float imagetimer;
public static playerPool instance{get;private set;}

private void Start(){
fadingimages.Clear();
grow();
}
public void Update(){
if(imagetimer>0)
imagetimer-=Time.deltaTime;
if(gameObject.GetComponent<playerDash>().dashing==true){
if(imagetimer<=0){
call();
imagetimer=0.075f;}
}
}
public void grow(){
for(int i=0;i<20;i++){
var additions = Instantiate(fadingplayer);
addtopool(additions);
}
}
public void addtopool(GameObject additions){
additions.SetActive(false);
fadingimages.Enqueue(additions);
}
public void call(){
if(fadingimages.Count == 0){
grow();}
GameObject instance;
do{ 
if(fadingimages.Count == 0){
grow();
instance = fadingimages.Dequeue();}
instance = fadingimages.Dequeue();
}
while(instance == null);
instance.gameObject.SetActive(true);
}












}