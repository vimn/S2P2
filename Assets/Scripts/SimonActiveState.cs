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

    GameObject _selection1;
    
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
    int level = 4;
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
        selectionNumber = 0;
        levelCounter = 0;
        BoxColorResetAll();
        Debug.Log("Entered into active state");
        _timerActive = true;
    }

    public void Exit()
    {
        Debug.Log("SHould be exiting");
        level++;
        
    }

    public void FixedTick()
    {
        if ((Time.time - _elapsedTime > choiceDelay) && levelCounter < level)
        {
            BoxColorResetAll();
            Debug.Log("Picking a thing here");
            BoxPick(level);
            levelCounter++;
            selectionNumber++;
            Debug.Log("Level now " + levelCounter);
            Debug.Log("Time " + Time.time + ", elapsed time: " + _elapsedTime);
            _elapsedTime = Time.time;
            //_timerActive = false;
        }

        if (levelCounter == level)
        {
            //levelCounter++;
            _simon.ChangeState(_simon.WaitState);
        }
    }

    public void Tick()
    {
        //if all picks done
        // enter into player's turn
        // else keep picking
        




    }


    public void BoxPick(int lvl)
    {
        int randBox = 0;
        if (lvl <= 4)
        {
            randBox = Random.Range(1, 5);
            Debug.Log("Picked box: " + randBox + ", from level: " + lvl);
        }
        if(lvl >= 5 && lvl < 9)
        {
            randBox = Random.Range(1, 9);
            Debug.Log("Picked box: " + randBox + ", from level: " + lvl);
        }
        if(lvl >= 9)
        {
            randBox = Random.Range(1, 13);
            Debug.Log("Picked box: " + randBox + ", from level: " + lvl);
        }
        if (randBox == 1 && _box1Selected == 0)
        {
            var boxRender = _box1.GetComponent<Renderer>();
            boxRender.material.SetColor("_Color", Color.red);
            _box1Selected = 1;
        }
        else if (randBox == 1 && _box1Selected == 1)
        {
            BoxPick(level);
        }
        if (randBox == 2 && _box2Selected == 0)
        {
            var boxRender = _box2.GetComponent<Renderer>();
            boxRender.material.SetColor("_Color", Color.blue);
            _box2Selected = 1;
        }
        else if (randBox == 2 && _box2Selected == 1)
        {
            BoxPick(level);
        }
        if (randBox == 3 && _box3Selected == 0)
        {
            var boxRender = _box3.GetComponent<Renderer>();
            boxRender.material.SetColor("_Color", Color.yellow);
            _box3Selected = 1;
        }
        else if (randBox == 3 && _box3Selected == 1)
        {
            BoxPick(level);
        }
        if (randBox == 4 && _box4Selected == 0)
        {
            var boxRender = _box4.GetComponent<Renderer>();
            boxRender.material.SetColor("_Color", Color.green);
            _box4Selected = 1;
        }
        else if (randBox == 4 && _box4Selected == 1)
        {
            BoxPick(level);
        }
        if (randBox == 5)
        {
            var boxRender = _box5.GetComponent<Renderer>();
            boxRender.material.SetColor("_Color", Color.red);
        }
        if (randBox == 6)
        {
            var boxRender = _box6.GetComponent<Renderer>();
            boxRender.material.SetColor("_Color", Color.red);
        }
        if (randBox == 7)
        {
            var boxRender = _box7.GetComponent<Renderer>();
            boxRender.material.SetColor("_Color", Color.red);
        }
        if (randBox == 8)
        {
            var boxRender = _box8.GetComponent<Renderer>();
            boxRender.material.SetColor("_Color", Color.red);
        }
        if (randBox == 9)
        {
            var boxRender = _box9.GetComponent<Renderer>();
            boxRender.material.SetColor("_Color", Color.red);
        }
        if (randBox == 10)
        {
            var boxRender = _box10.GetComponent<Renderer>();
            boxRender.material.SetColor("_Color", Color.red);
        }
        if (randBox == 11)
        {
            var boxRender = _box11.GetComponent<Renderer>();
            boxRender.material.SetColor("_Color", Color.red);
        }
        if (randBox == 12)
        {
            var boxRender = _box12.GetComponent<Renderer>();
            boxRender.material.SetColor("_Color", Color.red);
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
        BoxPick(level);
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
        var boxRender = box.GetComponent<Renderer>();
        boxRender.material.SetColor("_Color", Color.white);

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

    /*
    IEnumerator pick(int lvl)
    {
        if (lvl == 0)
        {
            
        }

        while (counter < duration)
        {
            counter += Time.deltaTime;
            fromPosition.position = Vector3.Lerp(startPos, endPos, counter / duration);

            yield return null;
        }
        int randMove = Random.Range(1, 5);
        MoveBoss(randMove);
        isMoving = false;
        StartCoroutine(rise(bossBody.transform, 1f));
    }
    */

}
