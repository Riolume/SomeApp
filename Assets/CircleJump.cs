using System.Collections;
using System.Collections.Generic;
using Random = UnityEngine.Random;
using UnityEngine;
using UnityEngine.UI;


public class CircleJump : MonoBehaviour
{
    public float RandX = 0f;
    public float RandY = 0f;
    public float RandScale = 0f;
    


    void Start()
    {
        
    }

    void Update()
    {
        RandX = Random.Range(-9, 9);
        RandY = Random.Range(-4, 4);
        RandScale = Random.Range(1, 4);

    }
    private void OnMouseDown()
    {
        transform.position = new Vector2(RandX, RandY);
        transform.localScale = new Vector2(RandScale, RandScale);
        ScoreScript.ScoreVal += 1;

    }
}
