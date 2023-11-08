using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StateMachine : MonoBehaviour
{
    public float walkspeed;


    public static bool signalFromwalkstate = false;
    void Start()
    {
        GameManager.instance.myrigidbody = GetComponent<Rigidbody2D>();
        GameManager.instance.myanim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        walkstate();
    }
    public void walkstate()
    {
        float moveDir = Input.GetAxis("Horizontal");
        Vector2 playerVel = new Vector2(moveDir * walkspeed, GameManager.instance.myrigidbody.velocity.y);
        GameManager.instance.myrigidbody.velocity = playerVel;
        bool playerHasXAxisSpeed = Mathf.Abs(GameManager.instance.myrigidbody.velocity.x) > Mathf.Epsilon;
        GameManager.instance.myanim.SetBool("walk", playerHasXAxisSpeed);
        
        if (playerHasXAxisSpeed)
        {
            signalFromwalkstate = true;
            if (GameManager.instance.myrigidbody.velocity.x > 0.1f)
            {
                transform.localRotation = Quaternion.Euler(0, 0, 0);
            }

            if (GameManager.instance.myrigidbody.velocity.x < -0.1f)
            {
                transform.localRotation = Quaternion.Euler(0, 180, 0);
            }
        }
        else
        {
            signalFromwalkstate = false;
        }
    }
}
