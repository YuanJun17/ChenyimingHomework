using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ftspsoundPlay : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void footstep1()
    {
        AudioManager.instance.PlayFootstepSound1();
    }
}
