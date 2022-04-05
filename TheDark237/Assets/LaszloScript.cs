using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaszloScript : MonoBehaviour
{

    public Rigidbody2D rBody;
    public float speed;

    public GameObject l;

    public GameObject flashLightRIGHT;

    public GameObject flashLightLEFT;
    public GameObject flashLight;

    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        speed = 5;
    }

    // Update is called once per frame
    void Update()
    {
        rBody.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, rBody.velocity.y);

        if(Input.GetKey(KeyCode.W)){
            rBody.velocity = new Vector2(rBody.velocity.x, speed);
        }
        if(Input.GetKey(KeyCode.L)){
            l.SetActive(false);
            flashLight.SetActive(true);
        }
        else{
            l.SetActive(true);
            flashLight.SetActive(false);
        }

        checkAnimation();
    } 

    public void checkAnimation(){
        if(Input.GetKey(KeyCode.D)){
            animator.SetBool("RUN", true);
            animator.SetFloat("Move", 1);
            flashLight = flashLightRIGHT;
            flashLightLEFT.SetActive(false);
        }
        else if(Input.GetKey(KeyCode.A)){
            animator.SetBool("RUN", true);
            animator.SetFloat("Move", -1);
            flashLight = flashLightLEFT;
            flashLightRIGHT.SetActive(false);
        }
        else{
            animator.SetBool("RUN", false);
        }
    }
}
