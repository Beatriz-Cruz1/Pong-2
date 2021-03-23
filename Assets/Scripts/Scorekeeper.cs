using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorekeeper : MonoBehaviour
{
    int leftscore = 0;
    int rightscore = 0;

    public void Goal()
    {
        leftscore = leftscore + 1;
        rightscore = rightscore + 1;
        Debug.Log(leftscore + " " + rightscore);
    }
    
}
