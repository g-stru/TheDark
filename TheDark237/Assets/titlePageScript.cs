using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class titlePageScript : MonoBehaviour
{


    public CanvasGroup titleAlpha;
    public CanvasGroup spaceAlpha;

    public bool fadeIn = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("Space")){
            fadeSpace();
            
            yield return new WaitForSeconds(1);

            fadeTitle();
        }
    }


    public void fadeSpace(){

    
    }

    public void fadeTitle(){


    }

}