using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heroe : MonoBehaviour
{
   // ZombieE zombi;
   // CiudadanoE ciudadano;
    
	// Use this for initialization
	void Start ()
    {
        
       
    }
	
	// Update is called once per frame
	void Update ()
    {
        
       // Debug.Log("warrrr quiero comer " + zombi.partes);
	}

   void OnCollisionEnter (Collision colision)
    {
        if (colision.gameObject.tag == "Zombie")
        {
            Debug.Log("warrrr quiero comer " + colision.gameObject.GetComponent<Zombie>().zombis.partes);
        }
        if (colision.gameObject.tag == "Ciudadano")
        {
            Debug.Log("Hola soy " + colision.gameObject.GetComponent<Ciudadano>().citizen.nombres + " y Tengo " + colision.gameObject.GetComponent<Ciudadano>().citizen.edad + " de edad");
        }
    }
}
