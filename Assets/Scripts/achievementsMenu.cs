using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class achievementsMenu : MonoBehaviour{
GameObject player;
public GameObject achievement;
public static bool sadEggs = false;
public static bool unkillableDemonKing = false;
public static bool devilsNeverCry = false;
public static bool noRobinhoodsAllowed = false;
public static bool hurry = false;
public static bool itsCommon = false;
public static bool imNotaWitcher = false;
public static bool soulsMaster = false;
public static bool all›nSphere = false;

public bool achievementUnlocked=false;

public Image sadEggsClose;
public Image sadEggsOpen;
public Image unkillableDemonKingClose;
public Image unkillableDemonKingOpen;
public Image devilsNeverCryClose;
public Image devilsNeverCryOpen;
public Image noRobinhoodsAllowedClose;
public Image noRobinhoodsAllowedOpen;
public Image hurryClose;
public Image hurryOpen;
public Image itsCommonClose;
public Image itsCommonOpen;
public Image imNotaWitcherClose;
public Image imNotaWitcherOpen;
public Image soulsMasterClose;
public Image soulsMasterOpen;
public Image allInSphereClose;
public Image allInSphereOpen;


    private void Start()
    {
    player=GameObject.Find("player");
    }
public void Update(){

if(achievements.loaded){ 
Load();
achievements.loaded=false;}


if(player.GetComponent<stats>().boss1killed && player.GetComponent<stats>().deathcounter==0 && sadEggs==false){
sadEggs=true;
Save();
achievement.GetComponent<Animator>().SetTrigger("achievement");}
if(player.GetComponent<stats>().boss2killed && player.GetComponent<stats>().deathcounter==0 && unkillableDemonKing==false){
unkillableDemonKing=true;
Save();
achievement.GetComponent<Animator>().SetTrigger("achievement");
}
if(player.GetComponent<stats>().boss2killed && player.GetComponent<stats>().minuteplayed<=15 && hurry==false){
hurry=true;
Save();
achievement.GetComponent<Animator>().SetTrigger("achievement");
}
if(player.GetComponent<stats>().deathcounter>=1 && itsCommon==false){
itsCommon=true;
Save();
achievement.GetComponent<Animator>().SetTrigger("achievement");}
if(player.GetComponent<potion>().potcounter==0 && imNotaWitcher==false && player.GetComponent<stats>().boss2killed){
imNotaWitcher=true;
Save();
achievement.GetComponent<Animator>().SetTrigger("achievement");}
if(player.GetComponent<playerSaveLOad>().savecounter==0 && player.GetComponent<stats>().boss2killed && soulsMaster==false){
soulsMaster=true;
Save();
achievement.GetComponent<Animator>().SetTrigger("achievement");}
if(player.GetComponent<stats>().boss2killed && all›nSphere==false){
all›nSphere=true;
Save();
achievement.GetComponent<Animator>().SetTrigger("achievement");}
if(player.GetComponent<stats>().boss2killed && player.GetComponent<stats>().minuteplayed<7 && hurry==false){
hurry=true;
Save();
hurry=true;}
if(player.GetComponent<stats>().boss2killed && player.GetComponent<stats>().arrowcounter==0 && noRobinhoodsAllowed==false){
noRobinhoodsAllowed=true;
Save();
achievement.GetComponent<Animator>().SetTrigger("achievement");}
if(player.GetComponent<stats>().boss2killed && player.GetComponent<stats>().judgementcounter==0 && devilsNeverCry==false){
devilsNeverCry=true;
Save();
achievement.GetComponent<Animator>().SetTrigger("achievement");}

if(sadEggs){
sadEggsClose.enabled = false;
sadEggsOpen.enabled = true;}

if(unkillableDemonKing){
unkillableDemonKingClose.enabled = false;
unkillableDemonKingOpen.enabled = true;}

if(devilsNeverCry){
devilsNeverCryClose.enabled = false;
devilsNeverCryOpen.enabled = true;}

if(noRobinhoodsAllowed){
noRobinhoodsAllowedClose.enabled = false;
noRobinhoodsAllowedOpen.enabled = true;}

if(hurry){
hurryClose.enabled = false;
hurryOpen.enabled = true;}

if(itsCommon){
itsCommonClose.enabled = false;
itsCommonOpen.enabled = true;}

if(imNotaWitcher){
imNotaWitcherClose.enabled = false;
imNotaWitcherOpen.enabled = true;}

if(soulsMaster){
soulsMasterClose.enabled = false;
soulsMasterOpen.enabled = true;}

if(all›nSphere){
allInSphereClose.enabled = false;
allInSphereOpen.enabled = true;}


}
public void Load(){
BinaryFormatter format=new BinaryFormatter();
string path=Application.persistentDataPath + "/achievements.sav";
FileStream fs=new FileStream(path, FileMode.Open);
achievements data = format.Deserialize(fs) as achievements;
sadEggs=data.sadEggs;
unkillableDemonKing=data.unkillableDemonKing;
devilsNeverCry=data.devilsNeverCry;
noRobinhoodsAllowed=data.noRobinhoodsAllowed;
hurry=data.hurry;
itsCommon=data.itsCommon;
imNotaWitcher=data.imNotaWitcher;
soulsMaster=data.soulsMaster;
all›nSphere=data.all›nSphere;
fs.Close();}


public static void Save(){ 
BinaryFormatter format=new BinaryFormatter();
string path=Application.persistentDataPath + "/achievements.sav";
achievements data=new achievements();
data.sadEggs=sadEggs;
data.soulsMaster=soulsMaster;
data.hurry=hurry;
data.all›nSphere=all›nSphere;
data.unkillableDemonKing=unkillableDemonKing;
data.devilsNeverCry=devilsNeverCry;
data.imNotaWitcher=imNotaWitcher;
data.itsCommon=itsCommon;
data.noRobinhoodsAllowed=noRobinhoodsAllowed;
FileStream fs=new FileStream(path, FileMode.Create);
format.Serialize(fs,data);
fs.Close();}
}
