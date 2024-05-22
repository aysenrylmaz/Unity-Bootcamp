using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerBow : MonoBehaviour{
[SerializeField] private GameObject _arrowPref;
[SerializeField] private float _speed;
private Vector2 _direction;
private Vector2 _mousePos;
private Vector2 _bowPos;
public GameObject player;
public GameObject stone;
public GameObject skill; 
Animator anim;

private void Start(){
DontDestroyOnLoad(gameObject);
anim = GetComponent<Animator>();
}
void Update(){
if(player.GetComponent<stats>().boss1killed){
skill.SetActive(true);
stone.SetActive(true);
_mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
_bowPos = transform.position;
_direction = _mousePos - _bowPos;
transform.right = _direction;

if(Input.GetMouseButtonDown(1) && Time.timeScale==1 && player.GetComponent<stats>().attackcooldown<=0 && player.GetComponent<stats>().stunned==false && player.GetComponent<stats>().canattack){
anim.SetTrigger("shoot");
player.GetComponent<playerarrows>().call(gameObject.transform.rotation);
player.GetComponent<stats>().attackcooldown=1;}

gameObject.transform.position=player.transform.position+new Vector3(0f,0.6f,0f);
}
}


}
