using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fading : MonoBehaviour{
public float timer=0.35f;
public SpriteRenderer rend;
public GameObject player;
public float x;

public void OnEnable(){
timer=0.35f;
x=0.85f;
player=GameObject.Find("player");
transform.position = player.transform.position;
transform.rotation = player.transform.rotation;
rend= GetComponent<SpriteRenderer>();
rend.sprite=player.GetComponent<SpriteRenderer>().sprite;
rend.color=new Color(85,24,28);
if(player.GetComponent<playerController>().sagaDonuk==false)
rend.flipX=true;
else
rend.flipX=false;
}

public void Update(){
if(timer>=0)
timer-=Time.deltaTime;
rend.color = new Color(1f,1f,1f,x);
x*=0.91f;
if(timer<=0){
x=0.85f;
player.GetComponent<playerPool>().addtopool(gameObject);
}
}
}
