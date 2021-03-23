using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    [SerializeField]
    Scorekeeper scorekeeper;

    private void OnCollisionEnter2D(Collision2D collision)
    {
       /*
        * Quando a bola bater, avisamos o Scorekeeper
        * para aumentar a pontuação
        */
    }


}
