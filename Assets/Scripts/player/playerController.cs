using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using Vector2 = UnityEngine.Vector2;
using Vector3 = System.Numerics.Vector3;


public class playerController : MonoBehaviour{
Rigidbody2D rb;
public Vector2 hareketYonu;
private Animator anim;
public bool sagaDonuk = true;
public bool moving;
void Start(){
rb = GetComponent<Rigidbody2D>();
anim = GetComponent<Animator>();}

void Update(){
if(gameObject.GetComponent<stats>().stunned==false && gameObject.GetComponent<stats>().canmove==true && gameObject.GetComponent<playerDash>().dashing==false)
GirdileriIsle();




if(rb.velocity.x==0 && rb.velocity.y==0 && moving==true){ 
anim.SetBool("moving",false);
moving=false;}
if((rb.velocity.x!=0 || rb.velocity.y!=0) && moving==false){
anim.SetBool("moving",true);
moving=true;}
}

private void FixedUpdate(){
if(gameObject.GetComponent<stats>().stunned==false && gameObject.GetComponent<stats>().canmove==true)
HaraketEt();}

void GirdileriIsle(){
float moveX = Input.GetAxisRaw("Horizontal");
float moveY = Input.GetAxisRaw("Vertical");
hareketYonu = new Vector2(moveX, moveY).normalized;

if(hareketYonu.x>0){ 
anim.SetInteger("direction",1);}
else if(hareketYonu.x<0){ 
anim.SetInteger("direction",1);}
else if(hareketYonu.y>0){ 
anim.SetInteger("direction",2);}
else if(hareketYonu.y<0){ 
anim.SetInteger("direction",3);}
}

void HaraketEt(){
rb.velocity = new Vector2(hareketYonu.x * gameObject.GetComponent<stats>().speed, hareketYonu.y * gameObject.GetComponent<stats>().speed);
if (hareketYonu.x<0 && sagaDonuk && gameObject.GetComponent<stats>().stunned==false){
YuzuCevir();}
else if (hareketYonu.x>0 && !sagaDonuk && gameObject.GetComponent<stats>().stunned==false){
YuzuCevir();}}
    
void YuzuCevir(){
sagaDonuk = !sagaDonuk;
UnityEngine.Vector3 geciciBoyutlan = transform.localScale;
geciciBoyutlan.x *= -1;
transform.localScale =  geciciBoyutlan;}


}
