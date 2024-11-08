using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prefabrotador : MonoBehaviour
{
    [SerializeField] int fuerzaMovimiento;
    [SerializeField] Vector3 dir;
    Rigidbody rb;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddTorque(dir * fuerzaMovimiento, ForceMode.VelocityChange);
    }

    
    void Update()
    {

    }
}
