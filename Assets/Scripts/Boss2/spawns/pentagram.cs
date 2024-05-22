using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pentagram : MonoBehaviour{
bool collide=false;
bool active=false;
public GameObject player;
public GameObject boss;
private void Start(){
boss=GameObject.Find("boss2");
StartCoroutine(activate());
player=GameObject.Find("player");
}
private void Update(){
if(boss.GetComponent<stats>().health<=0)
Destroy(gameObject);
if(collide && active){ 
player.GetComponent<stats>().health=0;
player.GetComponent<getHit>().gettinghit=true;}
}

private void OnTriggerEnter2D(Collider2D collision){
if(collision.gameObject==player)
collide=true;
}
private void OnTriggerExit2D(Collider2D collision){
if(collision.gameObject==player)
collide = false;
}
    IEnumerator activate(){
yield return new WaitForSeconds(1);
active=true;
yield return new WaitForSeconds(0.1f);
Destroy(gameObject);
}
}
