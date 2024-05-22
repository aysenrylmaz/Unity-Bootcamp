using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossSkill2 : MonoBehaviour{
public Animator anim;
public bool activated=false;
public GameObject followingarrow;
void Start(){
anim=gameObject.GetComponent<Animator>();}

void Update(){
if (activated==true){
StartCoroutine(ar());
activated=false;}
    

IEnumerator ar(){
anim.SetTrigger("followingarrow");
yield return new WaitForSeconds(0.8f);
Instantiate(followingarrow,gameObject.transform.position + new Vector3(0f,0.9f,0f),gameObject.transform.rotation);}

}
}
