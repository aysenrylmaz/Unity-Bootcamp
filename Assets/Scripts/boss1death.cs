using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class boss1death : MonoBehaviour{
public GameObject portal;
Animator anim;
GameObject player;
bool died=false;
private void Start(){
anim = GetComponent<Animator>();
player = GameObject.Find("player");
}
void Update(){
if(gameObject.GetComponent<stats>().health<=0 && died==false){
StartCoroutine(boss1kill());
died=true;}

}
IEnumerator boss1kill(){
gameObject.GetComponent<stats>().stunned=true;
player.GetComponent<stats>().invulnerable=true;
player.GetComponent<playerController>().hareketYonu=new Vector2(0,0);
boss1Sounds.PlaySound("177429__andromadax24__s-death-slith-08");
anim.SetTrigger("die");
player.GetComponent<Animator>().SetBool("boss",true);
player.GetComponent<stats>().stunned=true;
yield return new WaitForSeconds(2.35f);
player.GetComponent<Animator>().SetBool("boss",false);
player.GetComponent<stats>().invulnerable=false;
player.GetComponent<stats>().stunned=false;
portal.SetActive(true);
Destroy(gameObject);

}}