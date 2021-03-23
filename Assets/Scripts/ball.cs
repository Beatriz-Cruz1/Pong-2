using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    [SerializeField]
    float velocidade = 5f;


    // Start is called before the first frame update
    void Start()
    {
        //if(Random.value < 0.5f)
        //{
        //    GetComponent<Rigidbody2D>().velocity = velocidade * Vector2.right;
        //}
        //else
        //{
        //    GetComponent<Rigidbody2D>().velocity = velocidade * Vector2.left;
        //}

        GetComponent<Rigidbody2D>().velocity = velocidade * Random.insideUnitSphere;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
