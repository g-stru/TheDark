using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheDarkCameraScript : MonoBehaviour
{

    public Camera cameraMain;

    public LaszloScript laszlo;

    public float delay = 500f;

    private float rightBound;
    private float leftBound;

    // Start is called before the first frame update
    void Start()
    {
        rightBound = 83.19f;
        leftBound = -10.56093f;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float xPos = laszlo.transform.position.x;

        // Changing the Camera's position
        //  --> If the current Camera position isn't matching the players...
        if((transform.position.x != laszlo.transform.position.x || transform.position.x != laszlo.transform.position.x) && laszlo.transform.position.x > leftBound && laszlo.transform.position.x < rightBound)
        {
            // Change Camera movement to the new xPos and yPos
            // Lerp method allows us to add the delay
            transform.position = Vector3.Lerp(transform.position, new Vector3(xPos, transform.position.y, transform.position.z), delay);
        }
        
    }
}
