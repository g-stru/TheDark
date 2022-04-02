using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bobText : MonoBehaviour
{

    public GameObject bob;

    public bool up = true;

    private float change = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(up){
            if(change < 0.1){
                bob.transform.position += new Vector3(0, change, 0);
                change += Time.deltaTime;
                Debug.Log("UP:" + change);
            }
            else{
                up = false;
                change = 0f;
            }
        }
        else{
            if(change < 0.1){
                bob.transform.position -= new Vector3(0, change, 0);
                change += Time.deltaTime;
                Debug.Log("DOWN:" + change);
            }
            else{
                up = true;
                change = 0;
            }
        }
    }

    // public IEnumerator delay(float sec){
    //     yield
    // }
}
