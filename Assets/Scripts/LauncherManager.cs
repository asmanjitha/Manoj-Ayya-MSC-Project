using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LauncherManager : MonoBehaviour
{
    public GameObject data;
    public GameObject dataText;
    // Start is called before the first frame update
    void Start()
    {
        data.SetActive(false);
        dataText.SetActive(false);
    }

    public void LoadStats(){
        int time = PlayerPrefs.GetInt("Time");
        data.SetActive(true);
        dataText.SetActive(true);
        if(time > 0){
            data.GetComponent<Text>().text = time.ToString() + " minutes";
        }else{
            data.GetComponent<Text>().text = "No recorded time";
        }
    }

    public void LoadAR(){
        SceneManager.LoadSceneAsync("SampleScene");
    }
}
