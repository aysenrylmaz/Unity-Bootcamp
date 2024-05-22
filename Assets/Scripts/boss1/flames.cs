using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flames : MonoBehaviour{
public static Animator anim;
public static Collider2D cld;
public float health;
public float damage;
public GameObject player;
bool playerCollider = false;
public bool notstarted=true;
private void Start(){
anim = gameObject.GetComponent<Animator>();
cld = gameObject.GetComponent<Collider2D>();
player=GameObject.Find("player");
if(notstarted){
StartCoroutine(ar());
notstarted=false;}}

void Update(){
if(playerCollider){ 
player.GetComponent<stats>().health-=Time.deltaTime*5;
player.GetComponent<stats>().damagecounter+=Time.deltaTime*5;
if(player.GetComponent<stats>().health<=0)
player.GetComponent<getHit>().gettinghit=true;}



if(player.GetComponent<stats>().boss1killed==true)
Destroy(gameObject,1);}

private void OnTriggerEnter2D(Collider2D other){
if (other.tag == "Player"){
playerCollider = true;}}
private void OnTriggerExit2D(Collider2D collision){
if(collision.tag == "Player"){
playerCollider = false;}}


IEnumerator ar(){
yield return new WaitForSeconds(0.5f);
cld.enabled=true;}
}