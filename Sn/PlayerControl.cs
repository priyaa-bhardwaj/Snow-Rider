using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    SurfaceEffector2D surfaceEffector2D;
    [SerializeField] float torque= 1f;
    [SerializeField] float boost= 50f;
    [SerializeField] float normalSpeed=0.1f;
    Rigidbody2D rb2d;
    bool canmove=true;
    void Start()
    {
        rb2d= GetComponent<Rigidbody2D>();
        surfaceEffector2D=FindObjectOfType<SurfaceEffector2D>();
    }
    void Update()
    {
        if(canmove)
        {
            rotateplayer();
            movingforward();
        }
    } 
     public void DisableControl()
    {
        canmove = false;
    }
    void movingforward()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            surfaceEffector2D.speed=boost;
        }
        else
        {
            surfaceEffector2D.speed=normalSpeed;
        }
    }
    void rotateplayer()
    {
     if(Input.GetKey(KeyCode.LeftArrow))
        {
            rb2d.AddTorque(torque);
        }
        else if(Input.GetKey(KeyCode.RightArrow))
        {
            rb2d.AddTorque(-torque);
        }
    }
}