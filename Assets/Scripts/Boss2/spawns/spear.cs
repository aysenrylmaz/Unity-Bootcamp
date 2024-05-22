using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spear : MonoBehaviour{
GameObject player;
bool throwed=false;
Collider2D cld;
GameObject boss;
void Start(){
boss=GameObject.Find("boss2");
player=GameObject.Find("player");
Destroy(gameObject,7f);
cld=GetComponent<Collider2D>();
StartCoroutine(throwing());}
void Update(){
if(boss.GetComponent<stats>().health<=0)
Destroy(gameObject);
if(throwed==false)
transform.right = (new Vector2(player.transform.position.x,player.transform.position.y)-new Vector2(gameObject.transform.position.x,gameObject.transform.position.y)).normalized;
}
private void FixedUpdate(){
if(throwed)
transform.Translate(Vector2.right*5*Time.deltaTime);}

private void OnTriggerEnter2D(Collider2D collision){
if(collision.gameObject.name=="player" && collision.gameObject.GetComponent<stats>().damagecooldown<=0 && collision.gameObject.GetComponent<stats>().health>0 && collision.gameObject.GetComponent<stats>().invulnerable==false){
collision.gameObject.GetComponent<stats>().health-=40;
collision.gameObject.GetComponent<stats>().damagecounter+=40;
collision.gameObject.GetComponent<getHit>().gettinghit=true;
Destroy(gameObject);
}
    }

IEnumerator throwing(){
yield return new WaitForSeconds(2);
throwed = true;
cld.enabled=true;}
}
