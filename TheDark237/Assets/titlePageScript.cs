using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class titlePageScript : MonoBehaviour
{

    public GameObject screen;
    public CanvasGroup titleAlpha;
    public CanvasGroup spaceAlpha;
    public CanvasGroup blobAlpha;

    public bool fadeIn = true;
    public bool fadeOut = false;

    // Start is called before the first frame update
    void Awake()
    {
        titleAlpha.alpha = 0;
        spaceAlpha.alpha = 0;
    }

    // Update is called once per frame
    void Update()
    {
        fadeSpace();
        fadeTitle();
        if(Input.GetKeyDown("space") && !fadeIn){
            Time.timeScale = 1;
            fadeOut = true;
        }
    }


    public void fadeSpace(){
        fadeIt(spaceAlpha);
    }

    public void fadeTitle(){
        fadeIt(titleAlpha);
        fadeIt(blobAlpha);
    }


    public void fadeIt(CanvasGroup UI){
        if(fadeIn){
            if(UI.alpha < 1){
                UI.alpha += Time.deltaTime;
                if(UI.alpha >= 1){
                    fadeIn = false;
                    Time.timeScale = 0;
                }
            }
        }
        if(fadeOut){
            if(UI.alpha > 0){
                UI.alpha -= Time.deltaTime;
                if(UI.alpha <= 0){
                    fadeOut = false;
                    screen.SetActive(false);
                }
            }

        }
    }

}