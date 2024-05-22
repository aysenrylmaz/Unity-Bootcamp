using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
public class loadlastsave : MonoBehaviour{
public GameObject playerattack;
public GameObject playerbow;
public GameObject player;
public GameObject notfound;
private void OnEnable(){
player=GameObject.Find("player");
playerattack=GameObject.Find("player attack");
playerbow=GameObject.Find("player bow");

}
public void loadsave(){
if(File.Exists(Application.persistentDataPath + "/save.sav")){ 
Destroy(playerattack);
Destroy(playerbow);
Destroy(player);
BinaryFormatter format=new BinaryFormatter();
string path=Application.persistentDataPath + "/save.sav";
FileStream fs=new FileStream(path, FileMode.Open);
Data data = format.Deserialize(fs) as Data;
SceneManager.LoadScene(7);
Data.loaded=true;

fs.Close();
}
else{
notfound.GetComponent<Animator>().SetTrigger("achievement");}
}
}
