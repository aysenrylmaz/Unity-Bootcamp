using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerarrowrain : MonoBehaviour{
GameObject player;
Animator anim;
void Start(){
player =  GameObject.Find("player");
anim = GetComponent<Animator>();
}

void Update(){

if(Input.GetKeyDown(KeyCode.Alpha2) && player.GetComponent<stats>().boss1killed && player.GetComponent<stats>().skill3cooldown<=0){
player.GetComponent<stats>().skill3cooldown=15;
player.GetComponent<stats>().attackcooldown=1;
anim.SetTrigger("shoot");
for(int i = 0; i < 10; i++){
player.GetComponent<playerarrows>().call(gameObject.transform.rotation * Quaternion.Euler(0,0,10*i) * Quaternion.Euler(0,0,-45));
}
}
}

}
