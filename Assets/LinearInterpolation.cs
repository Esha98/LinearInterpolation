using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinearInterpolation : MonoBehaviour
{
    private int frame = 0;
    private GameObject ball;

    void Start () 
    {
        ball = GameObject.CreatePrimitive (PrimitiveType.Sphere);
    }

    void Update () 
    {	int maxFrames = 500;
    	Vector3 startP = new Vector3 (0, 0, 0);
        Vector3 endP = new Vector3 (10, 0, 10);
        ball.transform.position = new Vector3(Mathf.Cos(frame/50f), 0, Mathf.Sin(frame/50f));

        frame++;
        
        if (frame == maxFrames) 
        { 
            frame = 0; 
        }
    } 

}
