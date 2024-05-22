using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss2Skill2 : MonoBehaviour
{
public Animator anim;
public bool activated=false;
public int target;
public static Vector2 location;
public static Vector2 location0;
public static Vector2 location1;
public static Vector2 location2;
public static Vector2 location3;
public static Vector2 location4;
public static GameObject boss;
void Start(){
anim = GetComponent<Animator>();
boss = gameObject;
location = gameObject.transform.position;
location0 = new Vector2(0,0);
location1 = GameObject.Find("teleport location 1").transform.position;
location2 = GameObject.Find("teleport location 2").transform.position;
location3 = GameObject.Find("teleport location 3").transform.position;
location4 = GameObject.Find("teleport location 4").transform.position;}

void Update(){
while(activated){
target = Random.Range(0,5);
switch(target){
case 0:
if(location!=location0 && activated){ 
StartCoroutine(ar(location0));
activated=false;}
break;
case 1:
if(location!=location1 && activated){ 
StartCoroutine(ar(location1));
activated=false;}
break;
case 2:
if(location!=location2 && activated){ 
StartCoroutine(ar(location2));
activated=false;}
break;
case 3:
if(location!=location3 && activated){ 
StartCoroutine(ar(location3));
activated=false;}
break;
case 4:
if(location!=location4 && activated){ 
StartCoroutine(ar(location4));
activated=false;}
break;
}
}}

public static void teleport(Vector2 loc){
boss.transform.position = loc;
location = boss.transform.position;}

IEnumerator ar(Vector2 x){
anim.SetTrigger("teleport");
yield return new WaitForSeconds(0.67f);
teleport(x);}
}
