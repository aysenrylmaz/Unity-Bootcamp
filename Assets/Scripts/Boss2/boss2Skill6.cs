using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss2Skill6 : MonoBehaviour{
public Animator anim;
public bool activated;
public GameObject player;
public GameObject pentagon;
private void Start(){
anim=GetComponent<Animator>();
player=GameObject.Find("player");
}
private void Update(){
if(activated){
StartCoroutine(penta());
activated=false;
}
}
IEnumerator penta(){
    boss2Sounds.PlaySound("588668__thepig01__you-will-die");
anim.SetTrigger("pentagon");
yield return new WaitForSeconds(1.1f);
Instantiate(pentagon,player.transform.position,transform.rotation);
}
}
