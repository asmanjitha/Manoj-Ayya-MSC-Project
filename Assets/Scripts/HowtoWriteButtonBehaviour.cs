using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HowtoWriteButtonBehaviour : MonoBehaviour
{
    private static GameObject letter;

    public static void SetLetter(GameObject let){
        letter = let;
    }

    public void OnClick(){
        Animate();
    }

    /// <summary>
    /// This function is called when the behaviour becomes disabled or inactive.
    /// </summary>
    void OnDisable()
    {
       if (letter != null){
            Animator anim = letter.GetComponentInChildren<Animator>();
            if(anim != null){
                anim.SetBool("Show", false);
            }
        } 
    }
    

    public void Animate(){
        if (letter != null){
            Animator anim = letter.GetComponentInChildren<Animator>();
            if(anim != null){
                bool show = anim.GetBool("Show");
                if(!show){
                    anim.SetBool("Show", true);
                }
            }
        }
    }

}
