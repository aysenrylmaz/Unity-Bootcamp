using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss2Skill4 : MonoBehaviour{
Animator anim;
public GameObject aura;
public bool activated;

    private void Start()
    {
    anim = GetComponent<Animator>();
    }
    private void Update(){
if(activated){
StartCoroutine(activate());
activated=false;}
}



public IEnumerator activate(){
anim.SetTrigger("aura");
aura.SetActive(true);
yield return new WaitForSeconds(8);
aura.SetActive(false);}
}
