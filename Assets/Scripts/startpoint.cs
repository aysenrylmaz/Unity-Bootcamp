using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startpoint : MonoBehaviour{
GameObject player;
void Start(){
player = GameObject.Find("player");
if(Data.loaded==false)
player.transform.position = gameObject.transform.position;}
}
