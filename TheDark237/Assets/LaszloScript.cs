using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaszloScript : MonoBehaviour
{

    public Rigidbody2D rBody;
    public float speed;

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
    }
}
