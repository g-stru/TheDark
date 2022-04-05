using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endScreenScript : MonoBehaviour
{
    public GameObject screen;
    public CanvasGroup screenAlpha;

    public GameObject laszlo;

    public GameObject drawer;

    public float distance;

    public bool fadeIn = false;
    public bool fadeOut = false;

    // Start is called before the first frame update
    void Awake()
    {
        screenAlpha.alpha = 0;
    }

    // Update is called once per frame
    void Update()
    {

        distance = Mathf.Abs(laszlo.transform.position.x - drawer.transform.position.x);

        Debug.Log(distance);

        fadeIt(screenAlpha);

        if(Input.GetKey(KeyCode.C) && distance < 5){
            Time.timeScale = 1;
            fadeIn = true;
        }
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
