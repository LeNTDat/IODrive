using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DriverMove : MonoBehaviour
{
    [SerializeField][Range(1, 10)] int speed;
    [SerializeField] int turnSpeed = 150;

    void Start()
    {
        
    }

    void Update()
    {
        MovementDriver();
    }

    void MovementDriver ()
    {
        float inputX = Input.GetAxis("Horizontal") * Time.deltaTime * turnSpeed;
        float inputY = Input.GetAxis("Vertical") * Time.deltaTime * speed;

        transform.Translate(new Vector2(0, inputY));
        transform.Rotate(new Vector3(0,0, -inputX));

    }
}
