using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss2Skill3 : MonoBehaviour
{
public bool activated;
public GameObject wall;
public Animator anim;

    private void Start()
    {
    anim=GetComponent<Animator>();
    }





private void Update(){
if(activated){ 
    boss2Sounds.PlaySound("267399__viznoman__welcome-to-hell-demon-voice");
anim.SetTrigger("wall");
Instantiate(wall,new Vector3(-9,0,0),Quaternion.Euler(0,0,0));
Instantiate(wall,new Vector3(9,0,0),Quaternion.Euler(0,180,0));
activated=false;
}
}
}
