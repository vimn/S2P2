using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SimonWaitingState : IState
{
    Simon _simon;
    GameObject _box1;
    GameObject _box2;
    GameObject _box3;
    GameObject _box4;
    GameObject _box5;
    GameObject _box6;
    GameObject _box7;
    GameObject _box8;
    GameObject _box9;
    GameObject _box10;
    GameObject _box11;
    GameObject _box12;
    public SimonWaitingState(Simon simon, GameObject box1, GameObject box2, GameObject box3, GameObject box4, GameObject box5, GameObject box6, GameObject box7, GameObject box8, GameObject box9, GameObject box10, GameObject box11, GameObject box12)
    {
        _simon = simon;
        _box1 = box1;
        _box2 = box2;
        _box3 = box3;
        _box4 = box4;
        _box5 = box5;
        _box6 = box6;
        _box7 = box7;
        _box8 = box8;
        _box9 = box9;
        _box10 = box10;
        _box11 = box11;
        _box12 = box12;
    }
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
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("mouse down");
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.name == "Box") 
                { 
                   Debug.Log("Box 1 clicked!"); 
                }
                if (hit.transform.name == "Box2")
                {
                    Debug.Log("Box 2 clicked!");
                }
                if (hit.transform.name == "Box3")
                {
                    Debug.Log("Box 3 clicked!");
                }
                if (hit.transform.name == "Box4")
                {
                    Debug.Log("Box 4 clicked!");
                }
                if (hit.transform.name == "Box5")
                {
                    Debug.Log("Box 5 clicked!");
                }
                if (hit.transform.name == "Box6")
                {
                    Debug.Log("Box 6 clicked!");
                }
                if (hit.transform.name == "Box7")
                {
                    Debug.Log("Box 7 clicked!");
                }
                if (hit.transform.name == "Box8")
                {
                    Debug.Log("Box 8 clicked!");
                }
                if (hit.transform.name == "Box9")
                {
                    Debug.Log("Box 9 clicked!");
                }
                if (hit.transform.name == "Box10")
                {
                    Debug.Log("Box 10 clicked!");
                }
                if (hit.transform.name == "Box11")
                {
                    Debug.Log("Box 11 clicked!");
                }
                if (hit.transform.name == "Box12")
                {
                    Debug.Log("Box 12 clicked!");
                }

            }
        }
    }
}
