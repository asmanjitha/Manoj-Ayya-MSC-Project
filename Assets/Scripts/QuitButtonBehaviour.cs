using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitButtonBehaviour : MonoBehaviour
{
    public void DoQuit(){
        try{
            SceneManager.LoadScene("Launcher");
        }catch{
            Application.Quit();
        }
    }
}
