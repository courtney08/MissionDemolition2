using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;


public class PlayAgain : MonoBehaviour
{
   public void Restart(){
    SceneManager.LoadScene("_Scene_0");
   }
}
