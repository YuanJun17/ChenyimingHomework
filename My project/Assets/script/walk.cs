using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walk : MonoBehaviour
{
    public float walkspeed;
    private Rigidbody2D myrigidbody;
    private Animator myanim;

    // Start is called before the first frame update
    void Start()
    {
        myrigidbody = GetComponent<Rigidbody2D>();
        myanim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Walk();
        Filp();

    }
    void Walk()
    {
        float moveDir = Input.GetAxis("Horizontal");
        Vector2 playerVel = new Vector2(moveDir * walkspeed,myrigidbody.velocity.y);
        myrigidbody.velocity = playerVel;
        bool playerHasXAxisSpeed =Mathf.Abs(myrigidbody.velocity.x) > Mathf.Epsilon;
        myanim.SetBool("walk", playerHasXAxisSpeed);

    }
    void Filp()
    {
        bool playerHasXAxisSpeed = Mathf.Abs(myrigidbody.velocity.x) >  Mathf.Epsilon;
        if(playerHasXAxisSpeed)
        {
            if(myrigidbody.velocity.x > 0.1f)
            {
                transform.localRotation = Quaternion.Euler(0,0,0);
            }

            if (myrigidbody.velocity.x < - 0.1f)
            {
                transform.localRotation = Quaternion.Euler(0, 180, 0);
            }
        }
    }

    
}

