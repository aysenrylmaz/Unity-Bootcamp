using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow_Controller : MonoBehaviour{
GameObject player;

private void Start(){
player=GameObject.Find("player");
player.GetComponent<stats>().arrowcounter++;
StartCoroutine(backpool());
}


private void FixedUpdate(){
transform.Translate(Vector3.right*10*Time.deltaTime);
}


private void OnTriggerEnter2D(Collider2D other){
if(other.gameObject.tag == "Enemy") {
other.gameObject.GetComponent<stats>().health-=7;
player.GetComponent<stats>().hitcounter+=7;
other.gameObject.GetComponent<getHit>().gettinghit=true;
Destroy(gameObject);


}

    }
IEnumerator backpool(){
yield return new WaitForSeconds(5);
player.GetComponent<playerarrows>().addtopool(gameObject);

    }
}