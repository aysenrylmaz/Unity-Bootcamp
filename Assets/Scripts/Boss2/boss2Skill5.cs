using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss2Skill5 : MonoBehaviour{
Animator anim;
public GameObject spear;
public bool activated;
    private void Start()
    {
    anim=GetComponent<Animator>();
    }
void Update(){
if(activated==true){
anim.SetTrigger("spear");
for(int i=0;i<3;i++){ 
Vector3 randomposition = new Vector3(Random.Range(-6f,+5f),Random.Range(-4f,+2.8f),0f);
Instantiate(spear,randomposition,Quaternion.identity);}
activated = false;}   

}

}
