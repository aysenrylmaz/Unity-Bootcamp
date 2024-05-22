
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
public class Continue : MonoBehaviour{
public GameObject loadscreen;
public GameObject notfound;
public void loading(){
if(File.Exists(Application.persistentDataPath + "/save.sav")){
loadscreen.SetActive(true);
BinaryFormatter format=new BinaryFormatter();
string path=Application.persistentDataPath + "/save.sav";
FileStream fs=new FileStream(path, FileMode.Open);
Data data = format.Deserialize(fs) as Data;
SceneManager.LoadSceneAsync(7);
Data.loaded=true;

fs.Close();} 
else{
notfound.GetComponent<Animator>().SetTrigger("achievement");}
}

}
