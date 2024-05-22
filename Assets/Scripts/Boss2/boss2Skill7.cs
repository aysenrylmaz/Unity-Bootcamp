using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss2Skill7 : MonoBehaviour{
public bool activated;
Animator anim;

    private void Start()
    {
    anim = GetComponent<Animator>();

    }
    void Update(){
if(activated){
StartCoroutine(swords());
activated=false;}

    }

IEnumerator swords(){
anim.SetBool("sword",true);
yield return new WaitForSeconds(0.6f);
boss2Sounds.PlaySound("563332__badoink__magic-blade");
yield return new WaitForSeconds(0.2f);
anim.SetBool("sword",false);
}
}
