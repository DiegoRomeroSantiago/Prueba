using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prefabrotador : MonoBehaviour
{
    [SerializeField] int fuerzaMovimiento;
    Rigidbody rb;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        rb.AddTorque(new Vector3(1, 1, 1) * fuerzaMovimiento, ForceMode.Force);

    }
}
