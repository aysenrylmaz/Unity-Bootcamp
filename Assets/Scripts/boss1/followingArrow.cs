using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followingArrow: MonoBehaviour{
public Vector2 direction;
public Transform firepoint;
public LineRenderer linerenderer;
public GameObject player;
public Rigidbody2D rb;
public Vector2 movement;
GameObject boss;
void Start(){
boss=GameObject.Find("boss1");
player=GameObject.Find("player");
rb = GetComponent<Rigidbody2D>();
Destroy(gameObject,7f);}


void Update(){
if(boss.GetComponent<stats>().health<=0)
Destroy(gameObject);
Vector2 shipspos = player.transform.position;
Vector2 transformpos = transform.position;
direction = shipspos - transformpos;
direction.Normalize();
transform.right = direction;}

void FixedUpdate(){
transform.Translate(Vector3.right*1.6f*Time.deltaTime);}

private void OnTriggerEnter2D(Collider2D collision){
if(collision.gameObject.tag =="Player" && collision.gameObject.GetComponent<stats>().invulnerable==false){
collision.gameObject.GetComponent<stats>().health-=50;
collision.gameObject.GetComponent<stats>().damagecounter+=50;
collision.gameObject.GetComponent<getHit>().gettinghit=true;
Destroy(gameObject);
}
}
    

}

