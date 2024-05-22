using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss2 : MonoBehaviour
{
[SerializeField]
float cooldown;
int skillno;
int lastskill;
void Update(){

if(cooldown >= 0)
cooldown-=Time.deltaTime;

if(cooldown<=0 && gameObject.GetComponent<stats>().stunned==false){
skillno=Random.Range(1,8);
switch(skillno){
case 1:
if(lastskill!=1){ 
gameObject.GetComponent<boss2Skill1>().activated=true;
cooldown=6;
lastskill=1;}
break;
case 2:
if(lastskill!=2){
gameObject.GetComponent<boss2Skill2>().activated=true;
cooldown=3;
lastskill=2;}
break;
case 3:
if(lastskill!=3){
gameObject.GetComponent<boss2Skill3>().activated=true;
cooldown=3;
lastskill=3;}
break;
case 4:
if(lastskill!=4 && gameObject.GetComponent<boss2Skill4>().aura.active==false){
gameObject.GetComponent<boss2Skill4>().activated=true;
cooldown=3;
lastskill=4;}
break;
case 5:
if(lastskill!=5){ 
gameObject.GetComponent<boss2Skill5>().activated=true;
cooldown=3;
lastskill=5;}
break;
case 6:
if(lastskill!=6){ 
gameObject.GetComponent<boss2Skill6>().activated=true;
cooldown=3;
lastskill=6;}
break;
case 7:
if(lastskill!=7){ 
gameObject.GetComponent<boss2Skill7>().activated=true;
cooldown=5;
lastskill=7;}
break;
}}    
    }
}
