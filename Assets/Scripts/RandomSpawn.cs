using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour{
public GameObject yıldırım;
public bool activated=false;

void Update()
{
if(activated==true){
Vector3 randomposition = new Vector3(Random.Range(-6f,+5f),Random.Range(-4f,+2.8f),0f);
Instantiate(yıldırım,randomposition,Quaternion.identity);
activated = false;
}   

}

}






