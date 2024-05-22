using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bossportal : MonoBehaviour
{
public Animator anim;
bool inrange;
public GameObject loadscreen;
GameObject player;
private void Start(){
anim = GetComponent<Animator>();
player=GameObject.Find("player");
}
void Update(){
if(inrange)
anim.SetBool("inrange",true);
else
anim.SetBool("inrange",false);

if(inrange && Input.GetKeyDown(KeyCode.E)){ 
loadscreen.SetActive(true);
player.transform.position=new Vector2(0,-7.5f);
SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
}
}
private void OnTriggerEnter2D(Collider2D collision){
if(collision.gameObject.tag=="Player")
inrange=true;
}
private void OnTriggerExit2D(Collider2D collision){
inrange=false;
}
}
