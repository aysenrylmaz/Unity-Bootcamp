using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class potionstatues : MonoBehaviour
{
bool inrange;
public Animator anim;
    private void Start()
    {
    anim = GetComponent<Animator>();
    }
    void Update()
    {
if(inrange)
anim.SetBool("inrange",true);
else
anim.SetBool("inrange",false);

if(inrange && Input.GetKeyDown(KeyCode.E)){ 
GameObject.Find("player").GetComponent<potion>().pots=3;

}

}
    

private void OnTriggerEnter2D(Collider2D collision){
if(collision.gameObject.tag=="Player")
inrange=true;}

private void OnTriggerExit2D(Collider2D collision){
if(collision.gameObject.tag=="Player")
inrange=false;}
}
