using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class throne : MonoBehaviour{
public GameObject player;
public GameObject playerattack;
public GameObject playerbow;
public GameObject loadscreen;
bool inrange=false;
Animator anim;
private void Start(){
anim = GetComponent<Animator>();
player=GameObject.Find("player");
playerbow=GameObject.Find("player bow");
playerattack=GameObject.Find("player attack");}
void Update(){
if(inrange)
anim.SetBool("inrange",true);
else
anim.SetBool("inrange",false);

if(inrange && Input.GetKeyDown(KeyCode.E)){ 
loadscreen.SetActive(true);
Destroy(player);
Destroy(playerattack);
Destroy(playerbow);
SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);}
}
private void OnTriggerEnter2D(Collider2D collision){
if(collision.gameObject==player)
inrange=true;
}
private void OnTriggerExit2D(Collider2D collision){
if(collision.gameObject==player)
inrange=false;
}
}
