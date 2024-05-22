using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossSkill1 : MonoBehaviour{
public Animator anim;
public bool activated = false;
public GameObject player;
public Quaternion x;
void Start(){
player=GameObject.Find("player");
anim=gameObject.GetComponent<Animator>();}

void Update(){
if(activated==true && gameObject.GetComponent<stats>().stunned==false && gameObject.GetComponent<stats>().health>0){
StartCoroutine(ar());
activated=false;}




}
public void arrows1(){
if(gameObject.GetComponent<stats>().health>0)
for(int j=0;j<=9;j++){
gameObject.GetComponent<enemyPool>().call(Quaternion.Euler(0,0,10*j));
}
}
public void arrows2(){
if(gameObject.GetComponent<stats>().health>0)
for(int j=0;j<=9;j++){
gameObject.GetComponent<enemyPool>().call(Quaternion.Euler(0,0,90+10*j));

}}
public void arrows3(){
if(gameObject.GetComponent<stats>().health>0)
for(int j=0;j<=9;j++){
gameObject.GetComponent<enemyPool>().call(Quaternion.Euler(0,0,180+10*j));
}}
public void arrows4(){ 
if(gameObject.GetComponent<stats>().health>0)
for(int j=0;j<=9;j++){
gameObject.GetComponent<enemyPool>().call(Quaternion.Euler(0,0,270+10*j));
}}



IEnumerator ar(){
if(gameObject.transform.position!=new Vector3(0,0)){
anim.SetTrigger("teleport");
yield return new WaitForSeconds(0.75f);
bossSkill4.teleport(new Vector2(0,0));
anim.SetTrigger("teleport2");
yield return new WaitForSeconds(0.75f);}
anim.SetTrigger("arrowrain");
yield return new WaitForSeconds(1);
if(player.transform.position.x>=gameObject.GetComponent<stats>().location.x){
if(player.transform.position.y>=gameObject.GetComponent<stats>().location.y){
for(int i=0;i<4;i++)
Invoke("arrows1",1f+i*0.3f);
}
else{
for(int i=0;i<4;i++)
Invoke("arrows4",1f+i*0.3f);}
}
else{
if(player.transform.position.y>=gameObject.GetComponent<stats>().location.y){
for(int i=0;i<4;i++)
Invoke("arrows2",1f+i*0.3f);
}else{
for(int i=0;i<4;i++)
Invoke("arrows3",1f+i*0.3f);}
}
}









}