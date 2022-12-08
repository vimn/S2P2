using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


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
    public GameObject blocker1;
    public GameObject blocker2;

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
        AudioHelper.PlayClip2D(_Music, .6f);
    }

    private void Start()
    {

        ChangeState(ActiveState);
    }

    private void LateUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            SceneManager.LoadScene(0);
        }
        if (level >= 5)
        {
            blocker1.SetActive(false);
        }
        if (level >= 9)
        {
            blocker2.SetActive(false);
        }
        if (total > 0)
        {
            float playerAccuracy = (correct / total) * 100f;
            accuracy.text = "Accuracy: " + playerAccuracy.ToString("0.00") + "%";
        }
    }


}


