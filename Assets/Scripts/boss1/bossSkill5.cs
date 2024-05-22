using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossSkill5 : MonoBehaviour{
private Rigidbody2D rb;
public bool activated;
public float timer;
public GameObject player;
public Animator anim;    


public float screamForce= 1f;

void Start(){ 
anim=gameObject.GetComponent<Animator>();
player=GameObject.Find("player");
rb=player.GetComponent<Rigidbody2D>();

}
void Update(){


if (activated){
StartCoroutine(x());
activated=false;

}



}
public void back(){
    }

public IEnumerator x(){ boss1Sounds.PlaySound("333832__nick121087__demonic-woman-scream");
anim.SetTrigger("scream");
yield return new WaitForSeconds(0.4f);
player.GetComponent<Animator>().SetBool("deaf",true);
player.GetComponent<stats>().stunned=true;
Vector2 dir = (player.transform.position - gameObject.transform.position).normalized;
for(int i=0;i<150;i++){
player.GetComponent<Rigidbody2D>().AddForce(dir*screamForce);
yield return new WaitForSeconds(0.01f);}
player.GetComponent<getHit>().gettinghit=true;
player.GetComponent<Animator>().SetBool("deaf",false);
player.GetComponent<stats>().stunned=false;
player.GetComponent<Rigidbody2D>().velocity=new Vector2(0,0);
    }
    }


