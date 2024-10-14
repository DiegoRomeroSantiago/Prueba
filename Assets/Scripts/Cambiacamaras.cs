using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Cambiacamaras : MonoBehaviour
{
    [SerializeField] private GameObject camaraApagar;
    [SerializeField] private GameObject camaraEncender;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            if (camaraApagar.activeSelf)
            {
                camaraApagar.SetActive(false);
                camaraEncender.SetActive(true);
            }
            else
            {
                camaraApagar.SetActive(true);
                camaraEncender.SetActive(false);
            }
        }
    }



}
