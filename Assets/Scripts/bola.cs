using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

public class bola : MonoBehaviour
{
    [SerializeField] int fuerzaMovimiento;
    [SerializeField] int fuerzaSalto;
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {

        float w = Input.GetAxisRaw("Vertical");
        float s = Input.GetAxisRaw("Horizontal");
        rb.AddForce(new Vector3(s, 0, w) * fuerzaMovimiento, ForceMode.Force );

        salto();


    }
    void salto()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(new Vector3(0, 1, 0) * fuerzaSalto, ForceMode.Impulse);

        }
    }
}
