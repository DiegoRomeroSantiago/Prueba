using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

public class bola : MonoBehaviour
{
    [SerializeField] int fuerzaMovimiento;
    [SerializeField] int fuerzaSalto;
    [SerializeField] float rayoSuelo;
    float w;
    float s;
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {

         w = Input.GetAxisRaw("Vertical");
         s = Input.GetAxisRaw("Horizontal");

        if (rb != null) 
        {
            salto();            
        }


    }
    private void FixedUpdate()
    {
        rb.AddForce(new Vector3(s, 0, w) * fuerzaMovimiento, ForceMode.Force );
        
    }
    void salto()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(new Vector3(0, 1, 0) * fuerzaSalto, ForceMode.Impulse);

        }
    }

    bool detectarsuelo()
    {
        bool tocasuelo = Physics.Raycast(gameObject.transform.position, Vector3.down, rayoSuelo);
        return tocasuelo;

        
    }
}
