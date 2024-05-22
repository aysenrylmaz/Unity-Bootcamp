using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerupskill : MonoBehaviour{
Animator anim;
GameObject player;
void Start(){
anim = GetComponent<Animator>();
player = GameObject.Find("player");
}

void Update(){
if(Input.GetKeyDown(KeyCode.Alpha1) && player.GetComponent<stats>().skill1cooldown<=0 && Time.timeScale==1){
StartCoroutine(powerup());
}
    }
IEnumerator powerup(){
anim.SetBool("active",true);
player.GetComponent<stats>().damage +=5;
player.GetComponent<stats>().skill1cooldown=20;
yield return new WaitForSeconds(10);
anim.SetBool("active",false);
player.GetComponent<stats>().damage -=5;

}
}
