using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class staminaBar : MonoBehaviour{
public Slider stamina;
void Start(){
stamina=gameObject.GetComponentInChildren<Slider>();
stamina.maxValue=gameObject.GetComponentInParent<stats>().stamina;
}
void Update(){
stamina.value=gameObject.GetComponentInParent<stats>().stamina;        
}
}