using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimonActiveState : IState
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



    GameObject _selection1 = null;
    GameObject _selection2 = null;
    GameObject _selection3 = null;
    GameObject _selection4 = null;
    GameObject _selection5 = null;
    GameObject _selection6 = null;
    GameObject _selection7 = null;
    GameObject _selection8 = null;
    GameObject _selection9 = null;
    GameObject _selection10 = null;
    GameObject _selection11 = null;
    GameObject _selection12 = null;

    int _box1Selected = 0;
    int _box2Selected = 0;
    int _box3Selected = 0;
    int _box4Selected = 0;
    int _box5Selected = 0;
    int _box6Selected = 0;
    int _box7Selected = 0;
    int _box8Selected = 0;
    int _box9Selected = 0;
    int _box10Selected = 0;
    int _box11Selected = 0;
    int _box12Selected = 0;
    float choiceDelay = 3;
    float _elapsedTime = 0;
    bool _timerActive = false;
    int level = 2;
    int selectionNumber = 0;
    int levelCounter = 0;

    public SimonActiveState(Simon simon, GameObject box1, GameObject box2, GameObject box3, GameObject box4, GameObject box5, GameObject box6, GameObject box7, GameObject box8, GameObject box9, GameObject box10, GameObject box11, GameObject box12)
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
    public void Enter()
    {
        _selection1 = null;
        _selection2 = null;
        _selection3 = null;
        _selection4 = null;
        _selection5 = null;
        _selection6 = null;
        _selection7 = null;
        _selection8 = null;
        _selection9 = null;
        _selection10 = null;
        _selection11 = null;
        _selection12 = null;

        Debug.Log(_simon.testInt);

        selectionNumber = 0;
        levelCounter = 0;
        BoxColorResetAll();
        Debug.Log("Entered into active state");
        _timerActive = true;
    }

    public void Exit()
    {
        level++;
        _simon.testInt = 1;
    }

    public void FixedTick()
    {
        if ((Time.time - _elapsedTime > choiceDelay) && levelCounter < level)
        {
            BoxColorResetAll();
            Debug.Log("Picking a thing here");
            
            levelCounter++;
            selectionNumber++;
            if (selectionNumber == 1)
            {
                BoxPick(level, _selection1);
            }
            if (selectionNumber == 2)
            {
                BoxPick(level, _selection2);
            }
            if (selectionNumber == 3)
            {
                BoxPick(level, _selection3);
            }
            if (selectionNumber == 4)
            {
                BoxPick(level, _selection4);
            }
            if (selectionNumber == 5)
            {
                BoxPick(level, _selection5);
            }
            if (selectionNumber == 6)
            {
                BoxPick(level, _selection6);
            }
            if (selectionNumber == 7)
            {
                BoxPick(level, _selection7);
            }
            if (selectionNumber == 8)
            {
                BoxPick(level, _selection8);
            }
            if (selectionNumber == 9)
            {
                BoxPick(level, _selection9);
            }
            if (selectionNumber == 10)
            {
                BoxPick(level, _selection10);
            }
            if (selectionNumber == 11)
            {
                BoxPick(level, _selection11);
            }
            if (selectionNumber == 12)
            {
                BoxPick(level, _selection12);
            }

            Debug.Log("Selection number: " + levelCounter);
            //Debug.Log("Time " + Time.time + ", elapsed time: " + _elapsedTime);
            _elapsedTime = Time.time;
            //_timerActive = false;
        }

        if ((Time.time - _elapsedTime > choiceDelay) && (levelCounter == level))
        {
            BoxColorResetAll();
            Debug.Log("Clearing box color and changing states.");
            //levelCounter++;
            _simon.ChangeState(_simon.WaitState);
        }
    }

    public void Tick()
    {


    }

    public void SelectionNumber(GameObject selection)
    {

    }

    public void BoxPick(int lvl, GameObject selection)
    {
        int randBox = 0;
        if (lvl <= 4)
        {
            randBox = Random.Range(1, 5);
            Debug.Log("Picked box: " + randBox);
        }
        if(lvl >= 5 && lvl < 9)
        {
            randBox = Random.Range(1, 9);
            Debug.Log("Picked box: " + randBox);
        }
        if(lvl >= 9)
        {
            randBox = Random.Range(1, 13);
            Debug.Log("Picked box: " + randBox);
        }
        if (randBox == 1 && _box1Selected == 0)
        {
            _box1.GetComponent<Renderer>().material = _simon.boxLight1;
            //var boxRender = _box1.GetComponent<Renderer>();
            //boxRender.material.SetColor("_Color", Color.red);
            var box1Selected = _box1.GetComponent<Selected>();
            box1Selected.selected = 1;
            box1Selected.selectionNumber = selectionNumber;
            
            _box1Selected = 1;
            

        }
        else if (randBox == 1 && _box1Selected == 1)
        {
            BoxPick(level, selection);
        }
        if (randBox == 2 && _box2Selected == 0)
        {
            _box2.GetComponent<Renderer>().material = _simon.boxLight2;
            //var boxRender = _box2.GetComponent<Renderer>();
            //boxRender.material.SetColor("_Color", Color.blue);
            var box2Selected = _box2.GetComponent<Selected>();
            box2Selected.selected = 1;
            box2Selected.selectionNumber = selectionNumber;
            _box2Selected = 1;
            
        }
        else if (randBox == 2 && _box2Selected == 1)
        {
            BoxPick(level, selection);
        }
        if (randBox == 3 && _box3Selected == 0)
        {
            _box3.GetComponent<Renderer>().material = _simon.boxLight3;
           // var boxRender = _box3.GetComponent<Renderer>();
           // boxRender.material.SetColor("_Color", Color.yellow);
            _box3Selected = 1;
            var box3Selected = _box3.GetComponent<Selected>();
            box3Selected.selected = 1;
            box3Selected.selectionNumber = selectionNumber;
        }
        else if (randBox == 3 && _box3Selected == 1)
        {
            BoxPick(level, selection);
        }
        if (randBox == 4 && _box4Selected == 0)
        {
            _box4.GetComponent<Renderer>().material = _simon.boxLight4;
            //var boxRender = _box4.GetComponent<Renderer>();
            //boxRender.material.SetColor("_Color", Color.green);
            _box4Selected = 1;
            var box4Selected = _box4.GetComponent<Selected>();
            box4Selected.selected = 1;
            box4Selected.selectionNumber = selectionNumber;
        }
        else if (randBox == 4 && _box4Selected == 1)
        {
            BoxPick(level, selection);
        }
        if (randBox == 5 && _box5Selected == 0)
        {
            var boxRender = _box5.GetComponent<Renderer>();
            boxRender.material.SetColor("_Color", Color.red);
            _box5Selected = 1;
            var box5Selected = _box5.GetComponent<Selected>();
            box5Selected.selected = 1;
            box5Selected.selectionNumber = selectionNumber;
        }
        else if (randBox == 5 && _box5Selected == 1)
        {
            BoxPick(level, selection);
        }
        if (randBox == 6 && _box6Selected == 0)
        {
            var boxRender = _box6.GetComponent<Renderer>();
            boxRender.material.SetColor("_Color", Color.red);
            _box6Selected = 1;
            var box6Selected = _box6.GetComponent<Selected>();
            box6Selected.selected = 1;
            box6Selected.selectionNumber = selectionNumber;
        }
        else if (randBox == 6 && _box6Selected == 1)
        {
            BoxPick(level, selection);
        }
        if (randBox == 7 && _box7Selected == 0)
        {
            var boxRender = _box7.GetComponent<Renderer>();
            boxRender.material.SetColor("_Color", Color.red);
            _box7Selected = 1;
            var box7Selected = _box7.GetComponent<Selected>();
            box7Selected.selected = 1;
            box7Selected.selectionNumber = selectionNumber;
        }
        else if (randBox == 7 && _box7Selected == 1)
        {
            BoxPick(level, selection);
        }
        if (randBox == 8 && _box8Selected == 0)
        {
            var boxRender = _box8.GetComponent<Renderer>();
            boxRender.material.SetColor("_Color", Color.red);
            _box8Selected = 1;
            var box8Selected = _box8.GetComponent<Selected>();
            box8Selected.selected = 1;
            box8Selected.selectionNumber = selectionNumber;
        }
        else if (randBox == 8 && _box8Selected == 1)
        {
            BoxPick(level, selection);
        }
        if (randBox == 9 && _box9Selected == 0)
        {
            var boxRender = _box9.GetComponent<Renderer>();
            boxRender.material.SetColor("_Color", Color.red);
            _box9Selected = 1;
            var box9Selected = _box1.GetComponent<Selected>();
            box9Selected.selected = 1;
            box9Selected.selectionNumber = selectionNumber;
        }
        else if (randBox == 9 && _box9Selected == 1)
        {
            BoxPick(level, selection);
        }
        if (randBox == 10 && _box10Selected == 0)
        {
            var boxRender = _box10.GetComponent<Renderer>();
            boxRender.material.SetColor("_Color", Color.red);
            _box10Selected = 1;
            var box10Selected = _box10.GetComponent<Selected>();
            box10Selected.selected = 1;
            box10Selected.selectionNumber = selectionNumber;
        }
        else if (randBox == 10 && _box10Selected == 1)
        {
            BoxPick(level, selection);
        }
        if (randBox == 11 && _box11Selected == 0)
        {
            var boxRender = _box11.GetComponent<Renderer>();
            boxRender.material.SetColor("_Color", Color.red);
            _box11Selected = 1;
            var box11Selected = _box11.GetComponent<Selected>();
            box11Selected.selected = 1;
            box11Selected.selectionNumber = selectionNumber;
        }
        else if (randBox == 11 && _box11Selected == 1)
        {
            BoxPick(level, selection);
        }
        if (randBox == 12 && _box12Selected == 0)
        {
            var boxRender = _box12.GetComponent<Renderer>();
            boxRender.material.SetColor("_Color", Color.red);
            _box12Selected = 1;
            var box12Selected = _box12.GetComponent<Selected>();
            box12Selected.selected = 1;
            box12Selected.selectionNumber = selectionNumber;
        }
        else if (randBox == 12 && _box12Selected == 1)
        {
            BoxPick(level, selection);
        }
    }
    void SimonSelection()
    {

        float counter = 0;
        if (_timerActive)
        {
            _elapsedTime += Time.deltaTime;
        }

        if(_elapsedTime > choiceDelay)
        {
            StopTimer();
        }
        while (counter < 2)
        {
            counter += Time.deltaTime;
            
        }
        //BoxPick(level);
    }
    void StartTimer()
    {
        _timerActive = true;
        _elapsedTime = 0;
    }
    void StopTimer()
    {
        _timerActive = false;
    }
    public void BoxColorReset(GameObject box)
    {
        box.GetComponent<Renderer>().material = _simon.baseMat;
       // var boxRender = box.GetComponent<Renderer>();
       // boxRender.material.SetColor("_Color", Color.white);
       // boxRender.material.SetColor("_Color", Color.white);

    }
    public void BoxColorResetAll()
    {
        BoxColorReset(_box1);
        BoxColorReset(_box2);
        BoxColorReset(_box3);
        BoxColorReset(_box4);
        BoxColorReset(_box5);
        BoxColorReset(_box6);
        BoxColorReset(_box7);
        BoxColorReset(_box8);
        BoxColorReset(_box9);
        BoxColorReset(_box10);
        BoxColorReset(_box11);
        BoxColorReset(_box12);
    }


}
