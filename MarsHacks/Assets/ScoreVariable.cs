using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreVariable : MonoBehaviour
{
    public GameObject basket;
    public static int scoreVar = basket.score;
    Text score;

    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Score: " + scoreVar;
        Debug.Log(scoreVar);
    }

    void Collision (collision collideInfo)
    {

    }
}
