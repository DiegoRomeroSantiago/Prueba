using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;


public class bola : MonoBehaviour
{
    [SerializeField] int fuerzaMovimiento;
    [SerializeField] int fuerzaSalto;
    [SerializeField] float rayoSuelo;
    [SerializeField] TMP_Text textoVidas;
    [SerializeField] TMP_Text textoPuntos;
    [SerializeField] GameObject perder;
    [SerializeField] GameObject ganar;
    Vector3 inicio = new Vector3(-926, 1209, 69);
    int vida;
    int puntuacion;
    float w;
    float s;
    Rigidbody rb;
    void Start()
    {
        transform.position = inicio;
        vida = 3;
        puntuacion = 0;
        Time.timeScale = 1;
        rb = GetComponent<Rigidbody>();

    }
    void Update()
    {
        textoPuntos.SetText("Puntos:" + puntuacion);
        textoVidas.SetText("Vidas:" + vida);

         w = Input.GetAxisRaw("Vertical");
         s = Input.GetAxisRaw("Horizontal");

        if (detectarsuelo()) 
        {
            salto();            
        }

        if (vida<=0)
        {
            Time.timeScale = 0;
            SceneManager.LoadScene(0);
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

        if (other.CompareTag("danho"))
        {
            vida = vida - 1;
        }

        if (other.CompareTag("meta"))
        {
            Time.timeScale = 0;
            SceneManager.LoadScene(0);
        }
    }
}
