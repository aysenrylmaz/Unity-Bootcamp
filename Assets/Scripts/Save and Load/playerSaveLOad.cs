using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerSaveLOad : MonoBehaviour{
public int savecounter=0;

public void Update(){

if(Data.newgameopened){
SceneManager.LoadScene(1);
File.Delete (Application.persistentDataPath + "/save.sav");
File.Delete (Application.persistentDataPath + "/deaths.sav");
if(File.Exists(Application.persistentDataPath + "/achievements.sav"))
achievements.loaded=true;
Data.newgameopened=false;}



if(Data.loaded==true){
load();
if(File.Exists(Application.persistentDataPath + "/achievements.sav"))
achievements.loaded=true;
}

}
public void Awake(){
DontDestroyOnLoad(this);}

public void save(){
Data.Save();}

public static void load(){
Data.Load();
Data.loaded=false;}

}
