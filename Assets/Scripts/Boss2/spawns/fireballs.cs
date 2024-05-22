using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireballs : MonoBehaviour
{
 public GameObject boss2;

public void OnEnable(){
boss2=GameObject.Find("boss2");
gameObject.transform.position = boss2.transform.position + new Vector3(0f,0.9f,0f);
}
    

void FixedUpdate(){
transform.Translate(Vector3.right*10*Time.deltaTime);     }

public void OnTriggerEnter2D(Collider2D collision){
if(collision.gameObject.tag == "wall")
boss2.GetComponent<enemy2pool>().backtopool(gameObject);

if(collision.gameObject.layer==11 && collision.gameObject.GetComponent<stats>().damagecooldown<=0 && collision.gameObject.GetComponent<stats>().health>0 && collision.gameObject.GetComponent<stats>().invulnerable==false){ 
collision.gameObject.GetComponent<stats>().damagecooldown=0.2f;
collision.gameObject.GetComponent<stats>().health-=20;
collision.gameObject.GetComponent<stats>().damagecounter+=20;
collision.gameObject.GetComponent<getHit>().gettinghit=true;}}
}
