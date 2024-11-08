using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

public class bola : MonoBehaviour
{
    [SerializeField] int fuerzaMovimiento;
    [SerializeField] int fuerzaSalto;
    [SerializeField] float rayoSuelo;
    int vida;
    int puntuacion;
    float w;
    float s;
    Rigidbody rb;
    void Start()
    {
        vida = 1;
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {

         w = Input.GetAxisRaw("Vertical");
         s = Input.GetAxisRaw("Horizontal");

        if (detectarsuelo()) 
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



    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("recogible"))
        {
            puntuacion = puntuacion + 1;
            Destroy(other.gameObject);
        }

        if (other.gameObject.CompareTag("Dano"))
        {
            vida = vida - 1;
        }
    }
}
