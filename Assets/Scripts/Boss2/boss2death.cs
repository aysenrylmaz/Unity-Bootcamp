using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class boss2death : MonoBehaviour
{
public GameObject lastwords;
public GameObject throne;
Animator anim;
GameObject player;
GameObject stone;
bool died=false;

private void Start(){
stone=GameObject.Find("Red Soul Stone");
anim = GetComponent<Animator>();
player = GameObject.Find("player");}
void Update(){
if(gameObject.GetComponent<stats>().health<=0 && died==false){
StartCoroutine(boss1kill());
died=true;}

}
IEnumerator boss1kill(){
gameObject.GetComponent<stats>().stunned=true;
player.GetComponent<stats>().invulnerable=true;
player.GetComponent<Animator>().SetBool("boss",true);
player.GetComponent<stats>().stunned=true;
player.GetComponent<playerController>().hareketYonu=new Vector2(0,0);
boss2Sounds.PlaySound("56304__syna-max__monster-death-scream");
anim.SetTrigger("die");
yield return new WaitForSeconds(2.35f);
stone.GetComponent<Image>().color=new Color(255,255,255,255);
player.GetComponent<Animator>().SetBool("boss",false);
player.GetComponent<stats>().invulnerable=false;
player.GetComponent<stats>().stunned=false;
throne.SetActive(true);
lastwords.SetActive(true);
Destroy(gameObject);
}
}
