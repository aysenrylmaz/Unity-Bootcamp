using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class loadscreen : MonoBehaviour
{
public bool loading=false;
int currentscene;
void Start(){
DontDestroyOnLoad(gameObject);
}


}
