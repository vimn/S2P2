using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selected : MonoBehaviour
{
    // Start is called before the first frame update
    public int selectionNumber;
    public int selected;

    public void Awake()
    {
        selected = 0;
        selectionNumber = 0;
    }
}
