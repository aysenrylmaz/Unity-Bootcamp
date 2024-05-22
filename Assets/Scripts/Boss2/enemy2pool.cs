using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy2pool : MonoBehaviour
{
public GameObject fireball;
public Queue<GameObject> fireballs =new Queue<GameObject>();


public void Start(){
for(int i = 0; i < 50; i++){
var additions = Instantiate(fireball);
backtopool(additions);}}
private void Update(){
if(fireballs.Count==0){
for(int i = 0; i < 50; i++){
var additions = Instantiate(fireball);
backtopool(additions);}}

    }

    public void call(Quaternion x){
var instance = fireballs.Dequeue();
instance.gameObject.SetActive(true);
instance.gameObject.transform.rotation = x;}

public void backtopool(GameObject fire){
fire.SetActive(false);
fireballs.Enqueue(fire);}


}
