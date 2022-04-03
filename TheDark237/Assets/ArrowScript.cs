using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArrowScript : MonoBehaviour
{
    public GameObject laszlo;

    public GameObject drawers;

    private float distance;

    private float interval;

    public CanvasGroup arrowAlpha;

    public bool fadeIn = false;
    public bool fadeOut = false;

    private float start;

    void Start(){
        start = drawers.transform.position.x - laszlo.transform.position.x;
    }
    
    // Update is called once per frame
    void Update(){

        distance = Mathf.Abs(drawers.transform.position.x - laszlo.transform.position.x);

        fadeIt(arrowAlpha);
        
        if(laszlo.transform.position.x == start / 2){
            fadeIn = true;
            Debug.Log("HI");
        }

        if(distance < 14){
            // turn off
        }
    }

    public void fadeIt(CanvasGroup UI){
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
                }
            }

        }
    }    
}
