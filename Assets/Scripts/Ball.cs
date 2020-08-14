using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField]
    Canvas _canvas;

    private int pointPerBall = 2;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CallAddPoints()
    {
        _canvas.GetComponent<UI_Manager>().AddPoints(pointPerBall);
    }
}
