using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ARSceneManager : MonoBehaviour
{
    public static GameObject[] Letters = new GameObject[5];
    // public GameObject particle;
    public GameObject planeFinder;
    public static GameObject howToWriteButton;
    private int startTime;

    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    void Start()
    {
        startTime = PlayerPrefs.GetInt("Time");
        Letters[0] = GameObject.Find("A");
        Letters[1] = GameObject.Find("B");
        Letters[2] = GameObject.Find("C");
        Letters[3] = GameObject.Find("D");
        Letters[4] = GameObject.Find("E");
        howToWriteButton = GameObject.Find("How to Write Button");
        HideAllLetters();
    }

    

    void OnDestroy()
    {
        PlayerPrefs.SetInt("Time", startTime + (int)(Time.time)/60);
    }
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            Ray ray = Camera.main.ScreenPointToRay(touch.position);

            RaycastHit hit;

            if(Physics.Raycast(ray, out hit )){
                if(hit.collider != null){
                    GameObject obj = hit.collider.gameObject;
                    if(obj.tag == "OBJ"){
                        obj.GetComponent<AudioSource>().Play();
                    }
                }
            }

        }
    }


    public static void HideAllLetters(){
        foreach(GameObject letter in Letters){
            letter.SetActive(false);
        }
        howToWriteButton.SetActive(false);
    
    }


    public void DisablePlaneTracking(){
        planeFinder.SetActive(false);
    }

    public void EnablePlanrTracking(){
        planeFinder.SetActive(true);
    }

    public static void ActivateHowToWrite(){
        howToWriteButton.SetActive(true);
    }


    public void ReloadScene(){
        SceneManager.LoadSceneAsync("SampleScene");
    }

}
