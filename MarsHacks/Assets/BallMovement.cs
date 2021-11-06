using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    
    public float theta = 3.14f/4.0f;
    public float xComp;
    public float yComp;
    public float dtheta;
    // public float speed;
    public float gravity;
    public Rigidbody2D rb2D;
    public float thrust;
    public float move;
    public Transform arm;
    public Vector2 force = new Vector2 (0f, 1f);
    private bool onArm;
    //public Vector3 positionOnArm;
    // Start is called before the first frame update
    void Start()
    {
        xComp = Mathf.Cos(theta);
        yComp = Mathf.Sin(theta);
        onArm = true;
    }




    void OnCollisionEnter2D (Collision2D collision)
    {
        onArm = true;
        transform.position = arm.position;
    }


    // Update is called once per frame
    void Update()
    {
        
        if (onArm)
        {
            transform.position = arm.position;
        }

        if (Input.GetKeyDown(KeyCode.Space)) {
            if(onArm)
            {
                rb2D.AddForce(force * thrust, ForceMode2D.Impulse);
            }
            
            onArm = false;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            theta = theta - dtheta * Time.deltaTime;
            xComp = Mathf.Cos(theta);
            yComp = Mathf.Sin(theta);
            force = new Vector2(xComp, yComp);
        }
        
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            theta = theta + dtheta * Time.deltaTime;
            xComp = Mathf.Cos(theta);
            yComp = Mathf.Sin(theta);
            force = new Vector2(xComp, yComp);
        }
    }

}
