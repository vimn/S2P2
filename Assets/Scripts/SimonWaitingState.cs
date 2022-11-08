using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SimonWaitingState : IState
{
    Simon _simon;

    public SimonWaitingState()
    {
        //player takes actions
        //check against what simon did
        //when player selections match simon go to next state

    }
    public void Enter()
    {
        //change border to show it's player's turn
        Debug.Log("Entered waiting state");

    }

    public void Exit()
    {
        
    }

    public void FixedTick()
    {
        
    }

    public void Tick()
    {
        
    }
}
