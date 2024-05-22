using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossSkill3: MonoBehaviour{
public GameObject fire;
public bool activated=false;
public Animator anim;

void Start(){
anim = GetComponent<Animator>();}
void Update(){
if(activated==true){
StartCoroutine(ar());
activated = false;
}}
IEnumerator ar(){
    boss1Sounds.PlaySound("219782__madamvicious__feel-the-fury-of-the-cosmos-mortal");
anim.SetTrigger("flames");
yield return new WaitForSeconds(0.8f);
Vector3 randomposition = new Vector3(Random.Range(-6f,+5f),Random.Range(-4f,+2.8f),0f);
Instantiate(fire,randomposition,Quaternion.identity);}
}






