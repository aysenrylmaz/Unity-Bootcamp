using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerarrows : MonoBehaviour{
public GameObject arrow;
public GameObject bow;
public Queue<GameObject> arrows=new Queue<GameObject>();
public static playerPool instance{get;private set;}

private void Start(){
arrows.Clear();
grow();}

public void grow(){
for(int i=0;i<20;i++){
var additions = Instantiate(arrow);
addtopool(additions);
}
}
public void addtopool(GameObject additions){
additions.SetActive(false);
arrows.Enqueue(additions);}

public void call(Quaternion rotate){
if(arrows.Count == 0){
grow();}
GameObject instance;
do{ 
if(arrows.Count == 0){
grow();
instance = arrows.Dequeue();}
instance = arrows.Dequeue();
}
while(instance == null);

instance.transform.position=bow.transform.position;
instance.transform.rotation=rotate;
instance.gameObject.SetActive(true);
}
}
