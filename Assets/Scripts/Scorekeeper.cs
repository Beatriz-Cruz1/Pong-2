using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Scorekeeper : MonoBehaviour
{
    int leftscore = 0;
    int rightscore = 0;

    [SerializeField]
    TextMeshProUGUI leftscoreTxT;

    [SerializeField]
    TextMeshProUGUI rightscoreTXT;

    public void Goal(Wall.Wallname parede)
    {
        if (parede == Wall.Wallname.Right)
        {
            leftscore = leftscore + 1;
            leftscoreTxT.text = leftscore.ToString();
        } 
        else if (parede == Wall.Wallname.Left)
        {
            rightscore = rightscore + 1;
            rightscoreTXT.text = rightscore.ToString();
        }
        Debug.Log(leftscore + " " + rightscore);
    }
    
}
