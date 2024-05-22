using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class statMenu : MonoBehaviour{
public TMP_Text timeplayed;
public TMP_Text timesdead;
public TMP_Text damagedealt;
public TMP_Text damagetaken;
public TMP_Text potused;




void Update(){
timeplayed.text=gameObject.GetComponent<stats>().minuteplayed.ToString()+" : "+((int)gameObject.GetComponent<stats>().timeplayed-60*gameObject.GetComponent<stats>().minuteplayed).ToString();
potused.text=gameObject.GetComponent<potion>().potcounter.ToString();
timesdead.text=gameObject.GetComponent<stats>().deathcounter.ToString();
damagedealt.text=gameObject.GetComponent<stats>().hitcounter.ToString();
damagetaken.text=gameObject.GetComponent<stats>().damagecounter.ToString();

}
}
