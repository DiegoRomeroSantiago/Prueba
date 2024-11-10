using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movercubo : MonoBehaviour
{
    [SerializeField] Vector3 direccion;
    [SerializeField] float velocidad;
    float timer;
    int sentido = 1;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0) 
        {
            sentido =-sentido;
            timer = 2;
        }
        transform.Translate(direccion * sentido * velocidad * Time.deltaTime);
    }
}
