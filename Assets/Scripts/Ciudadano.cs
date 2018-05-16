using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ciudadano : MonoBehaviour
{
    public CiudadanoE citizen;

	void Start ()
    {
        citizen.nombres = (Nombres)Random.Range(0, 20);
        citizen.edad = Random.Range(15, 101);
    }
	
	void Update () {
		
	}
}
