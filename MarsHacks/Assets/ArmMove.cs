using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmMove : MonoBehaviour
{

    public Transform pivot;
    public float dtheta;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.RotateAround(pivot.position, new Vector3(0, 0, 1f), - 1 * dtheta);
        
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.RotateAround(pivot.position, new Vector3(0, 0, 1f), dtheta);
        }
    }

    
}
