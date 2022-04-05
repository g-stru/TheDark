using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArrowScript : MonoBehaviour
{
    public GameObject laszlo;

    public GameObject drawers;

    public CanvasGroup arrowAlpha;

    public AudioSource knock;

    public bool fadeIn = false;
    public bool fadeOut = false;

    public bool inProcess = false;

    public GameObject[] checkpoints;

    // Update is called once per frame
    void Update(){

        fadeIt(arrowAlpha);

        foreach(GameObject checkpoint in checkpoints){
            if(laszlo.transform.position.x < checkpoint.transform.position.x + 0.5 && laszlo.transform.position.x > checkpoint.transform.position.x - 0.5 && !inProcess){
                fadeIn = true;
                knock.Play();
                inProcess = true;
            }
        }
    
    }

    public void fadeIt(CanvasGroup UI){
        Debug.Log(fadeIn);
        if(fadeIn){
            if(UI.alpha < 1){
                UI.alpha += Time.deltaTime;
                if(UI.alpha >= 1){
                    fadeIn = false;
                    fadeOut = true;
                }
            }
        }
        if(fadeOut){
            if(UI.alpha > 0){
                UI.alpha -= Time.deltaTime;
                if(UI.alpha <= 0){
                    fadeOut = false;
                    inProcess = false;
                }
            }

        }
    }    
}
