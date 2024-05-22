using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyPool : MonoBehaviour{
public GameObject arrow;
public Queue<GameObject> arrows =new Queue<GameObject>();




public void Start(){
for(int i = 0; i < 30; i++){
var additions = Instantiate(arrow);
backtopool(additions);}}

public void call(Quaternion x){
var instance = arrows.Dequeue();
instance.gameObject.SetActive(true);
instance.gameObject.transform.rotation = x;}

public void backtopool(GameObject arrow){
arrow.SetActive(false);
arrows.Enqueue(arrow);}












}