using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHitBox : MonoBehaviour{
public GameObject player;

public void Start(){
player=GameObject.Find("player");
}
public void OnTriggerEnter2D(Collider2D collision){
if(collision.gameObject.layer==10 && collision.gameObject.GetComponent<stats>().health>0 && collision.gameObject.GetComponent<stats>().damagecooldown<=0){ 
collision.gameObject.GetComponent<stats>().damagecooldown=0.3f;
collision.gameObject.GetComponent<stats>().health-=player.GetComponent<stats>().damage;
player.GetComponent<stats>().hitcounter+=player.GetComponent<stats>().damage;
collision.gameObject.GetComponent<getHit>().gettinghit=true;}}
}