using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    public enum Wallname { Left, Right }

    [SerializeField]
    Scorekeeper marcador;

    [SerializeField]
    Wallname wallname = Wallname.Left;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        /*
         * Quando a bola bater, avisamos o Scorekeeper
         * para aumentar a pontuação
         */

        marcador.Goal(wallname);
    }



}
