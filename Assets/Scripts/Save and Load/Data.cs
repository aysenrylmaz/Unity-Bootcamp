
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

[System.Serializable]
public class Data{
private bool boss1killed=false;
private bool boss2killed=false;
private float hitcounter;
private float damagecounter;
private float timeplayed=0;
private int potcounter=0;
private float health=0;
private float stamina=0;
private float attackcooldown = 0;
private float skill1cooldown = 0;
private float skill2cooldown = 0;
private float skill3cooldown = 0;
private float skill4cooldown = 0;
private float axisx = 0;
private float axisy = 0;
private int savecounter=0;
private int arrowcounter=0;
private int judgementcounter;
public int scene=0;
public static bool loaded=false;
public static bool newgameopened=false;
private int dialogcounter;

    
public static void Save(){ 
GameObject player=GameObject.Find("player");
BinaryFormatter format=new BinaryFormatter();
string path=Application.persistentDataPath + "/save.sav";
Data data=new Data();
data.arrowcounter=player.GetComponent<stats>().arrowcounter;
data.judgementcounter=player.GetComponent<stats>().judgementcounter;
data.dialogcounter=player.GetComponent<stats>().dialogcounter;
data.timeplayed=player.GetComponent<stats>().timeplayed;
data.potcounter=player.GetComponent<potion>().potcounter;
data.savecounter=player.GetComponent<playerSaveLOad>().savecounter;
data.scene=SceneManager.GetActiveScene().buildIndex;
data.health=player.GetComponent<stats>().health;
data.stamina=player.GetComponent<stats>().stamina;
data.attackcooldown=player.GetComponent<stats>().attackcooldown;
data.skill1cooldown=player.GetComponent<stats>().skill1cooldown;
data.skill2cooldown=player.GetComponent<stats>().skill2cooldown;
data.skill3cooldown=player.GetComponent<stats>().skill3cooldown;
data.skill4cooldown=player.GetComponent<stats>().skill4cooldown;
data.axisx=player.transform.position.x;
data.axisy=player.transform.position.y;
data.damagecounter=player.GetComponent<stats>().damagecounter;
data.hitcounter=player.GetComponent<stats>().hitcounter;
data.boss1killed=player.GetComponent<stats>().boss1killed;
data.boss2killed=player.GetComponent<stats>().boss2killed;
FileStream fs=new FileStream(path, FileMode.Create);
format.Serialize(fs,data);
fs.Close();}


public static void Load(){
GameObject player=GameObject.Find("player");
BinaryFormatter format=new BinaryFormatter();
string path=Application.persistentDataPath + "/save.sav";
FileStream fs=new FileStream(path, FileMode.Open);
Data data = format.Deserialize(fs) as Data;
player.GetComponent<stats>().dialogcounter=data.dialogcounter-1;
player.GetComponent<stats>().health=data.health;
player.GetComponent<stats>().stamina=data.stamina;
player.GetComponent<stats>().attackcooldown=data.attackcooldown;
player.GetComponent<stats>().skill1cooldown=data.skill1cooldown;
player.GetComponent<stats>().skill2cooldown=data.skill2cooldown;
player.GetComponent<stats>().skill3cooldown=data.skill3cooldown;
player.GetComponent<stats>().skill4cooldown=data.skill4cooldown;
player.GetComponent<potion>().potcounter=data.potcounter;
player.GetComponent<stats>().timeplayed=data.timeplayed;
player.GetComponent<stats>().damagecounter=data.damagecounter;
player.GetComponent<stats>().hitcounter=data.hitcounter;
player.GetComponent<stats>().boss1killed=data.boss1killed;
player.GetComponent<stats>().boss2killed=data.boss2killed;
player.GetComponent<stats>().arrowcounter=data.arrowcounter;
player.GetComponent<stats>().judgementcounter=data.judgementcounter;

Vector2 location=new Vector2(data.axisx,data.axisy);
SceneManager.LoadScene(data.scene);
player.transform.position=location;
deathCounter.Load();
fs.Close();
}}
