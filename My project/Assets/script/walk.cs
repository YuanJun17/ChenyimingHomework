using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walk : MonoBehaviour
{
    public float walkspeed;
    
    // Start is called before the first frame update
    void Start()
    {
        GameManager.instance.myrigidbody = GetComponent<Rigidbody2D>();
        GameManager.instance.myanim = GetComponent<Animator>();
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
        Vector2 playerVel = new Vector2(moveDir * walkspeed, GameManager.instance.myrigidbody.velocity.y);
        GameManager.instance.myrigidbody.velocity = playerVel;
        bool playerHasXAxisSpeed =Mathf.Abs(GameManager.instance.myrigidbody.velocity.x) > Mathf.Epsilon;
        GameManager.instance.myanim.SetBool("walk", playerHasXAxisSpeed);
      

    }
    void Filp()
    {
        bool playerHasXAxisSpeed = Mathf.Abs(GameManager.instance.myrigidbody.velocity.x) >  Mathf.Epsilon;
        if(playerHasXAxisSpeed)
        {
            if(GameManager.instance.myrigidbody.velocity.x > 0.1f)
            {
                transform.localRotation = Quaternion.Euler(0,0,0);
            }

            if (GameManager.instance.myrigidbody.velocity.x < - 0.1f)
            {
                transform.localRotation = Quaternion.Euler(0, 180, 0);
            }
        }
    }
    


}

