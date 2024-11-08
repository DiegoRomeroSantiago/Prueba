using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParedCubos : MonoBehaviour
{
    [SerializeField] private Rigidbody[] rbs;
    private bool iniciarTimer;
    private float timer;


    private void Start()
    {
        rbs=GetComponentsInChildren<Rigidbody>();
        iniciarTimer = false;
        timer = 2;
    }
    private void Update()
    {
        if (iniciarTimer)
        {
           timer = timer - Time.unscaledDeltaTime;
            if (timer <= 0) 
            {
                Time.timeScale = 1.0f;
                for (int i = 0; i < rbs.Length; i++)
                {
                    rbs[i].useGravity = true;
                }
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Time.timeScale = 0.2f;
            iniciarTimer = true;
        }
    }
}
