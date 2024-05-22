using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class cooldownTimer1 : MonoBehaviour{
[SerializeField] private Image imageCoolldown1Image;
[SerializeField] private TMP_Text textCoolldown1;

[SerializeField] private Image imageCoolldown2Image;
[SerializeField] private TMP_Text textCoolldown2;

[SerializeField] private Image imageCoolldown3Image;
[SerializeField] private TMP_Text textCoolldown3;

public GameObject player;

    private void Start()
    {
    player=GameObject.Find("player");


    }



void Update(){
if(player.GetComponent<stats>().skill1cooldown<=0f){
textCoolldown1.text="";
imageCoolldown1Image.fillAmount= 0f;
}
else{
textCoolldown1.text = Mathf.RoundToInt(player.GetComponent<stats>().skill1cooldown).ToString();
imageCoolldown1Image.fillAmount= player.GetComponent<stats>().skill1cooldown/20;
}


if(player.GetComponent<stats>().skill2cooldown<=0f){
textCoolldown2.text="";
imageCoolldown2Image.fillAmount= 0f;
}
else
{
textCoolldown2.text = Mathf.RoundToInt(player.GetComponent<stats>().skill2cooldown).ToString();
imageCoolldown2Image.fillAmount= player.GetComponent<stats>().skill2cooldown/15;
}

if(player.GetComponent<stats>().skill3cooldown<=0f){
textCoolldown3.text="";
imageCoolldown3Image.fillAmount= 0f;
}
else
{
textCoolldown3.text = Mathf.RoundToInt(player.GetComponent<stats>().skill3cooldown).ToString();
imageCoolldown3Image.fillAmount= player.GetComponent<stats>().skill3cooldown/15;
}

}



}