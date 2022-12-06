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
    Selected selectedBox;
    float choiceDelay = 1;
    float _elapsedTime;
    bool musicPlayed;

    int selectionNumber;
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
        _simon.simonTurn.SetActive(false);
        _simon.playerTurn.SetActive(true);
        _simon.simonText.SetActive(false);
        _simon.playerText.SetActive(true);
        selectionNumber = 1;
        musicPlayed = false;
    }

    public void Exit()
    {
        
    }

    public void FixedTick()
    {
        
    }

    public void Tick()
    {

        if (selectionNumber > _simon.level)
        {
            if(!musicPlayed)
            {
                musicPlayed = true;
                AudioHelper.PlayClip2D(_simon._winSound, 1f);
            }
            
            if (Time.time - _elapsedTime > choiceDelay)
            {
                _simon.ChangeState(_simon.ActiveState);
                
                _simon.level++;
            }
        }

        if (Input.GetMouseButtonDown(0))
        {
            _elapsedTime = Time.time;
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            
            
            if (Physics.Raycast(ray, out hit))
            {
                selectedBox = hit.transform.gameObject.GetComponent<Selected>();
                if (hit.transform.name == "Box") 
                { 
                   if(selectedBox.selectionNumber == selectionNumber)
                    {
                        _simon.correct += 1;
                        _simon.total += 1;
                        _box1.GetComponent<Renderer>().material = _simon.boxLight1;
                        AudioHelper.PlayClip2D(_simon._boxSound1, 1f);
                        selectionNumber++;
                    }
                    else
                    {
                        _simon.total += 1;
                        AudioHelper.PlayClip2D(_simon._loseSound, 1f);
                    }
                   
                }
                if (hit.transform.name == "Box2")
                {
                    if (selectedBox.selectionNumber == selectionNumber)
                    {
                        _simon.correct += 1;
                        _simon.total += 1;
                        _box2.GetComponent<Renderer>().material = _simon.boxLight2;
                        AudioHelper.PlayClip2D(_simon._boxSound2, 1f);
                        selectionNumber++;
                    }
                    else
                    {
                        _simon.total += 1;
                        AudioHelper.PlayClip2D(_simon._loseSound, 1f);
                    }
                }
                if (hit.transform.name == "Box3")
                {
                    if (selectedBox.selectionNumber == selectionNumber)
                    {
                        _simon.correct += 1;
                        _simon.total += 1;
                        _box3.GetComponent<Renderer>().material = _simon.boxLight3;
                        AudioHelper.PlayClip2D(_simon._boxSound3, 1f);
                        selectionNumber++;
                    }
                    else
                    {
                        _simon.total += 1;
                        AudioHelper.PlayClip2D(_simon._loseSound, 1f);
                    }
                }
                if (hit.transform.name == "Box4")
                {
                    if (selectedBox.selectionNumber == selectionNumber)
                    {
                        _simon.correct += 1;
                        _simon.total += 1;
                        _box4.GetComponent<Renderer>().material = _simon.boxLight4;
                        AudioHelper.PlayClip2D(_simon._boxSound4, 1f);
                        selectionNumber++;
                    }
                    else
                    {
                        _simon.total += 1;
                        AudioHelper.PlayClip2D(_simon._loseSound, 1f);
                    }
                }
                if (hit.transform.name == "Box5")
                {
                    if (selectedBox.selectionNumber == selectionNumber)
                    {
                        _simon.correct++;
                        _simon.total++;
                        _box5.GetComponent<Renderer>().material = _simon.boxLight5;
                        AudioHelper.PlayClip2D(_simon._boxSound5, 1f);
                        selectionNumber++;
                    }
                    else
                    {
                        _simon.total++;
                        AudioHelper.PlayClip2D(_simon._loseSound, 1f);
                    }
                }
                if (hit.transform.name == "Box6")
                {
                    if (selectedBox.selectionNumber == selectionNumber)
                    {
                        _simon.correct++;
                        _simon.total++;
                        _box6.GetComponent<Renderer>().material = _simon.boxLight6;
                        AudioHelper.PlayClip2D(_simon._boxSound6, 1f);
                        selectionNumber++;
                    }
                    else
                    {
                        _simon.total++;
                        AudioHelper.PlayClip2D(_simon._loseSound, 1f);
                    }
                }
                if (hit.transform.name == "Box7")
                {
                    if (selectedBox.selectionNumber == selectionNumber)
                    {
                        _simon.correct++;
                        _simon.total++;
                        _box7.GetComponent<Renderer>().material = _simon.boxLight7;
                        AudioHelper.PlayClip2D(_simon._boxSound7, 1f);
                        selectionNumber++;
                    }
                    else
                    {
                        _simon.total++;
                        AudioHelper.PlayClip2D(_simon._loseSound, 1f);
                    }
                }
                if (hit.transform.name == "Box8")
                {
                    if (selectedBox.selectionNumber == selectionNumber)
                    {
                        _simon.correct++;
                        _simon.total++;
                        _box8.GetComponent<Renderer>().material = _simon.boxLight8;
                        AudioHelper.PlayClip2D(_simon._boxSound8, 1f);
                        selectionNumber++;
                    }
                    else
                    {
                        _simon.total++;
                        AudioHelper.PlayClip2D(_simon._loseSound, 1f);
                    }
                }
                if (hit.transform.name == "Box9")
                {
                    Debug.Log("Box 9 clicked!");
                    if (selectedBox.selectionNumber == selectionNumber)
                    {
                        _simon.correct++;
                        _simon.total++;
                        _box9.GetComponent<Renderer>().material = _simon.boxLight9;
                        AudioHelper.PlayClip2D(_simon._boxSound9, 1f);
                        selectionNumber++;
                    }
                    else
                    {
                        _simon.total++;
                        AudioHelper.PlayClip2D(_simon._loseSound, 1f);
                    }
                }
                if (hit.transform.name == "Box10")
                {
                    if (selectedBox.selectionNumber == selectionNumber)
                    {
                        _simon.correct++;
                        _simon.total++;  
                        _box10.GetComponent<Renderer>().material = _simon.boxLight10;
                        AudioHelper.PlayClip2D(_simon._boxSound10, 1f);
                        selectionNumber++;
                    }
                    else
                    {
                        _simon.total++;
                        AudioHelper.PlayClip2D(_simon._loseSound, 1f);
                    }
                }
                if (hit.transform.name == "Box11")
                {
                    if (selectedBox.selectionNumber == selectionNumber)
                    {
                        _simon.correct++;
                        _simon.total++;
                        _box11.GetComponent<Renderer>().material = _simon.boxLight11;
                        AudioHelper.PlayClip2D(_simon._boxSound11, 1f);
                        selectionNumber++;
                    }
                    else
                    {
                        _simon.total++;
                        AudioHelper.PlayClip2D(_simon._loseSound, 1f);
                    }
                }
                if (hit.transform.name == "Box12")
                {
                    if (selectedBox.selectionNumber == selectionNumber)
                    {
                        _simon.correct++;
                        _simon.total++;
                        _box12.GetComponent<Renderer>().material = _simon.boxLight12;
                        AudioHelper.PlayClip2D(_simon._boxSound12, 1f);
                        selectionNumber++;
                    }
                    else
                    {
                        _simon.total++;
                        AudioHelper.PlayClip2D(_simon._loseSound, 1f);
                    }
                }

            }
        }
    }
}
