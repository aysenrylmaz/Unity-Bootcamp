using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerDash : MonoBehaviour{
public Rigidbody2D bdy;
public bool dashing=false;
void Start(){
bdy=gameObject.GetComponent<Rigidbody2D>();   
}

void Update(){

if(Input.GetKeyDown(KeyCode.Space) && gameObject.GetComponent<stats>().stunned==false && gameObject.GetComponent<stats>().stamina>=50 && gameObject.GetComponent<menu>().paused==false && dashing==false){
gameObject.GetComponent<stats>().canattack=false;
gameObject.GetComponent<stats>().speed*=4;
gameObject.GetComponent<stats>().stamina-=50;
gameObject.GetComponent<stats>().invulnerable=true;
dashing=true;
Invoke("back",0.27f);
}

}
public void back(){
dashing=false;
gameObject.GetComponent<stats>().invulnerable=false;
gameObject.GetComponent<stats>().canattack=true;
gameObject.GetComponent<stats>().speed/=4;}


}
