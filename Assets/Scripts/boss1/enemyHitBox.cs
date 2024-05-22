using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHitBox : MonoBehaviour
{
public void OnTriggerEnter2D(Collider2D collision){
if(collision.gameObject.tag=="Player" && collision.gameObject.GetComponent<stats>().health>0){ 
collision.gameObject.GetComponent<stats>().health=0;
collision.gameObject.GetComponent<getHit>().gettinghit=true;}}

}