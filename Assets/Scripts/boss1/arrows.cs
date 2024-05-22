using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrows : MonoBehaviour{
public GameObject boss1;

public void OnEnable(){
boss1=GameObject.Find("boss1");
gameObject.transform.position = boss1.transform.position + new Vector3(0f,0.9f,0f);
}
    

void FixedUpdate(){
transform.Translate(Vector3.right*10*Time.deltaTime);     }

public void OnTriggerEnter2D(Collider2D collision){
if(collision.gameObject.tag == "wall")
boss1.GetComponent<enemyPool>().backtopool(gameObject);

if(collision.gameObject.layer==11 && collision.gameObject.GetComponent<stats>().damagecooldown<=0 && collision.gameObject.GetComponent<stats>().health>0 && collision.gameObject.GetComponent<stats>().invulnerable==false){ 
collision.gameObject.GetComponent<stats>().damagecooldown=0.2f;
collision.gameObject.GetComponent<stats>().health-=15;
collision.gameObject.GetComponent<stats>().damagecounter+=15;
collision.gameObject.GetComponent<getHit>().gettinghit=true;}}
}
