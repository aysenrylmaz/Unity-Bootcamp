using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

[System.Serializable]
public class deathCounter{
public int death=0;
public bool died=false;

public static void Save(){
BinaryFormatter format=new BinaryFormatter();
string path=Application.persistentDataPath + "/deaths.sav";
deathCounter data=new deathCounter();
data.death=GameObject.Find("player").GetComponent<stats>().deathcounter;
FileStream fs=new FileStream(path, FileMode.Create);
format.Serialize(fs,data);
fs.Close();
}
public static void Load(){
if(File.Exists(Application.persistentDataPath + "/deaths.sav")){
BinaryFormatter format=new BinaryFormatter();
string path=Application.persistentDataPath + "/deaths.sav";
FileStream fs=new FileStream(path, FileMode.Open);
deathCounter data = format.Deserialize(fs) as deathCounter;
GameObject.Find("player").GetComponent<stats>().deathcounter=data.death;
} }



}
