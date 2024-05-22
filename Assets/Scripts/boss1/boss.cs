using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class boss : MonoBehaviour{
[SerializeField]
float cooldown;
int skillno;
int lastskill;
void Update(){

if(cooldown >= 0)
cooldown-=Time.deltaTime;

if(cooldown<=0 && gameObject.GetComponent<stats>().stunned==false){
skillno=Random.Range(1,7);
switch(skillno){
case 1:
if(lastskill!=1){ 
gameObject.GetComponent<bossSkill1>().activated=true;
cooldown=5;
lastskill=1;}
break;
case 2:
if(lastskill!=2){
gameObject.GetComponent<bossSkill2>().activated=true;
cooldown=5;
lastskill=2;}
break;
case 3:
if(lastskill!=3){
gameObject.GetComponent<bossSkill3>().activated=true;
cooldown=3;
lastskill=3;}
break;
case 4:
if(lastskill!=4){
gameObject.GetComponent<bossSkill4>().activated=true;
cooldown=3;
lastskill=4;}
break;
case 5:
if(lastskill!=5 && lastskill!=2){ 
gameObject.GetComponent<bossSkill5>().activated=true;
cooldown=3;
lastskill=5;}
break;

case 6:
if(lastskill!=1){ 
gameObject.GetComponent<bossSkill1>().activated=true;
cooldown=5;
lastskill=1;}
break;

}}    
    }}
