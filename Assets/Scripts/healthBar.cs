using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class healthBar : MonoBehaviour{
public Slider health;
void Start(){
health=gameObject.GetComponentInChildren<Slider>();
health.maxValue=gameObject.GetComponentInParent<stats>().health;
}
void Update(){
health.value=gameObject.GetComponentInParent<stats>().health;        
}
}
