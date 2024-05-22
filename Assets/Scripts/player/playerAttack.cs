using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class playerAttack : MonoBehaviour{
public GameObject player;
public Vector3 pos;
public float attackdirection;
public Animator anim;
public bool isactive=false;
public float timer=0;
public bool interrupted=false;
public Slider charge;
public Image fill;
public void Awake(){
DontDestroyOnLoad(this);}
void Start(){
anim = GetComponent<Animator>();
player=GameObject.Find("player");}

void Update(){
if(Input.GetKey(KeyCode.Mouse0) && player.GetComponent<stats>().stunned==false && player.GetComponent<stats>().skill2cooldown<=0){
if(timer<=3)
timer+=Time.deltaTime;






if(timer>=0.3f){
fill.color=new Color(0.7098039f,0.3176471f,0.6117647f,155);
charge.SetValueWithoutNotify(timer);
player.GetComponent<Animator>().SetBool("charging",true);
player.GetComponent<stats>().canmove=false;
player.GetComponent<Animator>().SetInteger("direction",0);
player.GetComponent<Animator>().SetBool("moving",false);
player.GetComponent<playerController>().hareketYonu=new Vector2(0,0);}

if(player.GetComponent<getHit>().gettinghit==true && timer>=0.3f){
timer=0;
player.GetComponent<stats>().canmove=true;
player.GetComponent<Animator>().SetBool("charging",false);
player.GetComponent<stats>().skill2cooldown=15;
}

}
gameObject.transform.position=player.transform.position+new Vector3(0f,0.1f,0f);



if(Input.GetKeyUp(KeyCode.Mouse0)){ 
fill.color=new Color(0.7098039f,0.3176471f,0.6117647f,0);
charge.SetValueWithoutNotify(0);
player.GetComponent<Animator>().SetBool("charging",false);
if(timer<=0.3f && player.GetComponent<stats>().stunned==false && player.GetComponent<stats>().attackcooldown<=0 && player.GetComponent<stats>().canattack==true && player.GetComponent<menu>().paused==false){
player.GetComponent<stats>().attackcooldown =0.6f;
timer=0;
player.GetComponent<stats>().canmove=true;
pos = Camera.main.WorldToScreenPoint(player.transform.position);
pos = Input.mousePosition - pos;
attackdirection=Mathf.Atan2(pos.x, pos.y)*Mathf.Rad2Deg+270;
if(attackdirection>360)
attackdirection-=360;
if((attackdirection >= 0 && attackdirection <= 22.5f) || (attackdirection >= 337.5f && attackdirection <= 365))
{ 
    SoundManagerCS.PlaySound("merrick079-sword-sound-2");
    anim.SetTrigger("right");
}
else if ((attackdirection >= 22.5f && attackdirection <= 67.5f))
{
    SoundManagerCS.PlaySound("merrick079-sword-sound-1");
    anim.SetTrigger("bottomright");
}
else if ((attackdirection >= 67.5f && attackdirection <= 112.5f))
{
    SoundManagerCS.PlaySound("neospica-knife-slice");
    anim.SetTrigger("bottom");
}
else if ((attackdirection >= 112.5f && attackdirection <= 157.5f))
{
    SoundManagerCS.PlaySound("merrick079-sword-sound-1");
    anim.SetTrigger("bottomleft");
}
else if ((attackdirection >= 157.5f && attackdirection <= 202.5f))
{
    SoundManagerCS.PlaySound("merrick079-sword-sound-2");
    anim.SetTrigger("left");
}
else if ((attackdirection >= 202.5 && attackdirection <= 247.5f))
{
    SoundManagerCS.PlaySound("merrick079-sword-sound-1");
    anim.SetTrigger("topleft");
}
else if ((attackdirection >= 247.5 && attackdirection <= 292.5f))
{
    SoundManagerCS.PlaySound("neospica-knife-slice");
    anim.SetTrigger("top");
}

else if ((attackdirection >= 292.5 && attackdirection <= 337.5f))
{
    SoundManagerCS.PlaySound("merrick079-sword-sound-1");
    anim.SetTrigger("topright");
}
}
else if(timer>=3 && player.GetComponent<stats>().stunned==false && player.GetComponent<stats>().attackcooldown<=0 && player.GetComponent<menu>().paused==false && player.GetComponent<stats>().canattack==true && Time.timeScale==1 && player.GetComponent<stats>().skill2cooldown<=0){
StartCoroutine(judgement());
}
else{
timer=0;
player.GetComponent<stats>().canmove=true;}

}}


IEnumerator judgement (){
player.GetComponent<Animator>().SetTrigger("judgement");
timer=0;
player.GetComponent<stats>().skill2cooldown=15;
player.GetComponent<stats>().judgementcounter++;
yield return new WaitForSeconds(0.6f);
player.GetComponent<stats>().canmove=true;
if(GameObject.Find("boss1")){ 
GameObject.Find("boss1").GetComponent<stats>().health-=120;
player.GetComponent<stats>().hitcounter+=120;
GameObject.Find("slash").GetComponent<Animator>().SetTrigger("slash");}

if(GameObject.Find("boss2")){ 
GameObject.Find("boss2").GetComponent<stats>().health-=120;
player.GetComponent<stats>().hitcounter+=120;
GameObject.Find("slash").GetComponent<Animator>().SetTrigger("slash");}
    }
}

