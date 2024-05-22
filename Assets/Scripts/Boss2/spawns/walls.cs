using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walls : MonoBehaviour{
void FixedUpdate(){
transform.Translate(Vector3.right*3*Time.deltaTime);}

public void OnTriggerEnter2D(Collider2D collision){
if(collision.gameObject.layer==11 && collision.gameObject.GetComponent<stats>().damagecooldown<=0 && collision.gameObject.GetComponent<stats>().health>0 && collision.gameObject.GetComponent<stats>().invulnerable==false){ 
collision.gameObject.GetComponent<stats>().damagecooldown=0.2f;
collision.gameObject.GetComponent<stats>().health-=50;
collision.gameObject.GetComponent<stats>().damagecounter+=50;
collision.gameObject.GetComponent<getHit>().gettinghit=true;}

if(collision.gameObject.tag=="bosswall")
Destroy(gameObject);

}
}
