using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objetorecoger : MonoBehaviour
{
    [SerializeField] Vector3 rotar;
    [SerializeField] float velocidad;


    void Start()
    {
        
    }

    void Update()
    {
       transform.Rotate(rotar*velocidad*Time.deltaTime,Space.World);
    }
}
