// This script moves a GameObject to a new x position using a Vector2.
//Attach this script to a GameObject
//Set your x position in the Inspector

using UnityEngine;

public class Examples : MonoBehaviour
{
    Vector2 m_NewPosition;
    //This is the new X position. Set it in the Inspector.
    public float m_XPosition;

    // Use this for initialization
    void Start()
    {
        //Initialise the vector
        m_NewPosition = new Vector2(0.0f, 0.0f);
    }

    void Update()
    {
        //Press the space key to change the x component of the vector
        if (Input.GetKeyDown(KeyCode.Space))
        {
            m_NewPosition.x = m_XPosition;
        }
        //Change the position depending on the vector
        transform.position = m_NewPosition;
    }
}
