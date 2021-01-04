using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterButtonBehaviour : MonoBehaviour
{
    
    [SerializeField] private GameObject Letter;
    // Start is called before the first frame update
    

    public void ActivateLetter(){
        ARSceneManager.HideAllLetters();
        Letter.SetActive(true);
        HowtoWriteButtonBehaviour.SetLetter(Letter);
    
        ARSceneManager.ActivateHowToWrite();
    
    }
}
