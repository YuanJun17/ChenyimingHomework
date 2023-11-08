using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StateTextChange : MonoBehaviour
{
    public Text IfWalkState;
    // Start is called before the first frame update
    void Start()
    {
        IfWalkState.text = "Present State : Idle";
    }

    // Update is called once per frame
    void Update()
    {
        WalkState();

    }
    void WalkState()
    {
        if (StateMachine.signalFromwalkstate)
        {
            IfWalkState.text = "Present State : Walk";
        
        }
        else
        {
            IfWalkState.text = "Present State : Idle";
        }
    }
}
