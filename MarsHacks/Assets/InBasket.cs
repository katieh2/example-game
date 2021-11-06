using UnityEngine;

public class InBasket : MonoBehaviour
{
    void OnCollisionEnter2D ()
    {
        Debug.Log("We hit something");
        scoreVar++;
    }
}
