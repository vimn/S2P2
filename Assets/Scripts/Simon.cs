using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Simon : StateMachineMB
{
    public SimonWaitingState WaitState { get; private set; }
    public SimonActiveState ActiveState { get; private set; }
    [SerializeField] GameObject box1 = null;
    [SerializeField] GameObject box2 = null;
    [SerializeField] GameObject box3 = null;
    [SerializeField] GameObject box4 = null;
    [SerializeField] GameObject box5 = null;
    [SerializeField] GameObject box6 = null;
    [SerializeField] GameObject box7 = null;
    [SerializeField] GameObject box8 = null;
    [SerializeField] GameObject box9 = null;
    [SerializeField] GameObject box10 = null;
    [SerializeField] GameObject box11 = null;
    [SerializeField] GameObject box12 = null;

    [SerializeField] TextMeshProUGUI accuracy;

    [SerializeField] AudioClip _Music;
    public AudioClip _boxSound1;
    public AudioClip _boxSound2;
    public AudioClip _boxSound3;
    public AudioClip _boxSound4;
    public AudioClip _boxSound5;
    public AudioClip _boxSound6;
    public AudioClip _boxSound7;
    public AudioClip _boxSound8;
    public AudioClip _boxSound9;
    public AudioClip _boxSound10;
    public AudioClip _boxSound11;
    public AudioClip _boxSound12;
    public AudioClip _loseSound;
    public AudioClip _winSound;

    public GameObject simonTurn;
    public GameObject playerTurn;
    public GameObject playerText;
    public GameObject simonText;

    public Material boxLight1;
    public Material boxLight2;
    public Material boxLight3;
    public Material boxLight4;
    public Material boxLight5;
    public Material boxLight6;
    public Material boxLight7;
    public Material boxLight8;
    public Material boxLight9;
    public Material boxLight10;
    public Material boxLight11;
    public Material boxLight12;
    public Material baseMat;

    public int level;
    public float correct = 0;
    public float total = 0;
    public int testInt = 0;


    private void Awake()
    {
        ActiveState = new SimonActiveState(this, box1, box2, box3, box4, box5, box6, box7, box8, box9, box10, box11, box12);
        WaitState = new SimonWaitingState(this, box1, box2, box3, box4, box5, box6, box7, box8, box9, box10, box11, box12);
        AudioHelper.PlayClip2D(_Music, 1f);
    }

    private void Start()
    {

        ChangeState(ActiveState);
    }

    private void LateUpdate()
    {
        if (total > 0)
        {
            float playerAccuracy = (correct / total) * 100f;
            accuracy.text = "Accuracy: " + playerAccuracy.ToString("0.00") + "%";
        }
    }

    public void ClearColors()
    {

    }

    
    IEnumerator SimonSelection()
    {
        BoxColor(box1);
        BoxColor(box2);
        BoxColor(box3);
        BoxColor(box4);
        BoxColor(box5);
        BoxColor(box6);
        BoxColor(box7);
        BoxColor(box8);
        BoxColor(box9);
        BoxColor(box10);
        BoxColor(box11);
        BoxColor(box12);
        yield return new WaitForSeconds(1);
        //BoxPick(level);
    }
    public void BoxPick(int lvl)
    {
        int randBox = 0;
        if (lvl <= 4)
        {
            randBox = Random.Range(1, 5);
            Debug.Log("Picked box: " + randBox + ", from level: " + lvl);
        }
        if (lvl >= 5 && lvl < 9)
        {
            randBox = Random.Range(1, 9);
            Debug.Log("Picked box: " + randBox + ", from level: " + lvl);
        }
        if (lvl >= 9)
        {
            randBox = Random.Range(1, 13);
            Debug.Log("Picked box: " + randBox + ", from level: " + lvl);
        }
        if (randBox == 1)
        {
            var boxRender = box1.GetComponent<Renderer>();
            boxRender.material.SetColor("_Color", Color.red);
        }
        if (randBox == 2)
        {
            var boxRender = box2.GetComponent<Renderer>();
            boxRender.material.SetColor("_Color", Color.red);
        }
        if (randBox == 3)
        {
            var boxRender = box3.GetComponent<Renderer>();
            boxRender.material.SetColor("_Color", Color.red);
        }
        if (randBox == 4)
        {
            var boxRender = box4.GetComponent<Renderer>();
            boxRender.material.SetColor("_Color", Color.red);
        }
        if (randBox == 5)
        {
            var boxRender = box5.GetComponent<Renderer>();
            boxRender.material.SetColor("_Color", Color.red);
        }
        if (randBox == 6)
        {
            var boxRender = box6.GetComponent<Renderer>();
            boxRender.material.SetColor("_Color", Color.red);
        }
        if (randBox == 7)
        {
            var boxRender = box7.GetComponent<Renderer>();
            boxRender.material.SetColor("_Color", Color.red);
        }
        if (randBox == 8)
        {
            var boxRender = box8.GetComponent<Renderer>();
            boxRender.material.SetColor("_Color", Color.red);
        }
        if (randBox == 9)
        {
            var boxRender = box9.GetComponent<Renderer>();
            boxRender.material.SetColor("_Color", Color.red);
        }
        if (randBox == 10)
        {
            var boxRender = box10.GetComponent<Renderer>();
            boxRender.material.SetColor("_Color", Color.red);
        }
        if (randBox == 11)
        {
            var boxRender = box11.GetComponent<Renderer>();
            boxRender.material.SetColor("_Color", Color.red);
        }
        if (randBox == 12)
        {
            var boxRender = box12.GetComponent<Renderer>();
            boxRender.material.SetColor("_Color", Color.red);
        }
    }
    public void BoxColor(GameObject box)
    {
        var boxRender = box.GetComponent<Renderer>();
        boxRender.material.SetColor("_Color", Color.white);

    }
}


