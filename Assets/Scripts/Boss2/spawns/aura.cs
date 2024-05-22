using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aura : MonoBehaviour{
public bool enemyCollider=false;
public GameObject player;



void OnEnable(){
player=GameObject.Find("player");
}

void Update(){
if(enemyCollider)
player.GetComponent<stats>().health-=Time.deltaTime*10;
player.GetComponent<stats>().damagecounter+=Time.deltaTime*10;
if(player.GetComponent<stats>().health<=0)
player.GetComponent<getHit>().gettinghit=true;
}

private void OnTriggerEnter2D(Collider2D collider){     
if (collider.tag == "Player"){
enemyCollider = true;}}

private void OnTriggerExit2D(Collider2D collider){
if(collider.tag == "Player"){
enemyCollider = false;}}
}
