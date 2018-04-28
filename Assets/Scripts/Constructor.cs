using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Constructor : MonoBehaviour
{


    // Use this for initialization
    void Start ()
    {
        string[] nombres = new string[]
        {
            "Abraham","Juan","Alejo","William","Cote",
            "Tatiana","Carolina","Vanesa","Juliana","Cristina",
            "Elkin","Sebastian","Roberto","Omar","Diego",
            "Sara","Andrea","Jennifer","Laura","Karla"
        };

        Heroe z = new Heroe();
        int i = Random.Range(4, 10);

        for (int j = 0; j <= i; j++)
        {
            int k = Random.Range(0, 2);
            if (k == 0)
            {
                Color u = Color.clear;
                int p = Random.Range(0, 3);

                if (p == 0)
                {
                    u = Color.cyan;
                }
                else if (p == 1)
                {
                    u = Color.magenta;
                }
                else if (p == 2)
                {
                    u = Color.green;
                }
                Zombie s = new Zombie(u); 
            }
            else
            {
                int e = Random.Range(15, 101);
                int o = Random.Range(0, 20);
                Citizen g = new Citizen(e, nombres[o]);
            }
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public class Heroe
    {
        GameObject hero;

        public Heroe()
        {
            hero = GameObject.CreatePrimitive(PrimitiveType.Capsule);
            Vector3 pos1 = new Vector3();
            pos1.x = Random.Range(-10, 10);
            pos1.y = 1f;
            pos1.z = Random.Range(-10, 10);
            hero.transform.position = pos1;
            
            
            Camera.main.transform.SetParent(hero.transform, false);
            Camera.main.transform.localPosition = new Vector3(0f, 1f, 0.5f);
            hero.AddComponent(typeof(FPSmove));
            Camera.main.gameObject.AddComponent<FPSAim>();
        }
    } 

    public class Zombie
    {
        public Color zombicolor;
        GameObject zombi;

        public Zombie(Color a)
        {
            zombicolor = a;
            zombi = GameObject.CreatePrimitive(PrimitiveType.Cube);
            zombi.GetComponent<Renderer>().material.color = a;

            if (a == Color.cyan)
            {
                Debug.Log("Hola, soy un zombie mariposon color Cyan");
            }
            else if (a == Color.green)
            {
                Debug.Log("Hola, soy un zombie de color verde");
            }
            else if (a == Color.magenta)
            {
                Debug.Log("Hola, soy un zombie mariposon color magenta");
            }

            Vector3 pos2 = new Vector3();
            pos2.x = Random.Range(-10, 10);
            pos2.y = 0.5f;
            pos2.z = Random.Range(-10, 10);
            zombi.transform.position = pos2;
        }
    }

    public class Citizen
    {
        public string names;
        GameObject ciudad;

        public Citizen(int edad, string k)
        {
            names = k;
            ciudad = GameObject.CreatePrimitive(PrimitiveType.Cylinder);

            Debug.Log("Hola, mi nombre es " +k +" y tengo " +edad +" años");

            Vector3 pos3 = new Vector3();
            pos3.x = Random.Range(-10, 10);
            pos3.y = 1f;
            pos3.z = Random.Range(-10, 10);
            ciudad.transform.position = pos3;
        }
    }

   
   
}

