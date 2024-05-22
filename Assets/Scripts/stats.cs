using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class stats : MonoBehaviour{
public bool boss1killed=false;
public bool boss2killed=false;
public Vector2 location;
public bool canmove=true;
public bool canattack=true;
public bool candash=true;
public bool stunned=false;
public bool invulnerable=false;
public int speed;
public int maxhealth;
public float health;
public float stamina;
public int damage;
public float damagecooldown;
public float attackcooldown;
public float skill1cooldown;
public float skill2cooldown;
public float skill3cooldown;
public float skill4cooldown;
public float timeplayed = 0;
public int deathcounter = 0;
public float damagecounter=0;
public float hitcounter=0;
public int minuteplayed = 0;
public int dialogcounter=0;
public int arrowcounter=0;
public int judgementcounter=0;

public void Update(){
if(GameObject.Find("boss1"))
if( GameObject.Find("boss1").GetComponent<stats>().health<=0 && boss1killed==false){
boss1killed=true;}
if(GameObject.Find("boss2"))
if(GameObject.Find("boss2").GetComponent<stats>().health<=0 && boss2killed==false){
boss2killed=true;}
timeplayed+=Time.deltaTime;
minuteplayed=(int)timeplayed/60;
location = gameObject.transform.position;
if(stamina<100)
stamina+=Time.deltaTime*20;
if(damagecooldown > 0)
damagecooldown-=Time.deltaTime;
if(health>maxhealth){
health = maxhealth;}
if(attackcooldown > 0)
attackcooldown-=Time.deltaTime;
if(skill1cooldown > 0)
skill1cooldown-=Time.deltaTime;
if(skill2cooldown > 0)
skill2cooldown-=Time.deltaTime;
if(skill3cooldown > 0)
skill3cooldown-=Time.deltaTime;
if(skill4cooldown > 0)
skill4cooldown-=Time.deltaTime;}}
