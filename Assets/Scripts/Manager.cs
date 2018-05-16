using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour {

    HeroeE hero;
    ZombieE zombi;
    CiudadanoE ciudad;

 
    // Use this for initialization
	public void Start () {

        zombi.color = new Color[]
        {
            Color.cyan, Color.green, Color.magenta
        };

        GameObject heroe = GameObject.CreatePrimitive(PrimitiveType.Capsule);

        Vector3 pos1 = new Vector3();
        pos1.x = Random.Range(-10, 10);
        pos1.y = 1f;
        pos1.z = Random.Range(-10, 10);
        heroe.transform.position = pos1;

        Camera.main.transform.SetParent(heroe.transform, false);
        Camera.main.transform.localPosition = new Vector3(0f, 1f, 0.5f);
        heroe.AddComponent(typeof(FPSmove));
        Camera.main.gameObject.AddComponent<FPSAim>();

        heroe.AddComponent<Heroe>();
        Rigidbody rgbdy1 = heroe.AddComponent<Rigidbody>();
        rgbdy1.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ;
        heroe.tag = "Heroe";

        int i = Random.Range(9, 20);

        for (int j = 0; j <= i; j++)
        {
            int k = Random.Range(0, 2);
            if (k == 0)
            {
                GameObject zombie = GameObject.CreatePrimitive(PrimitiveType.Cube);
                int col = Random.Range(0, 3);
                 
                switch (col)
                {
                    case 0:
                        col = 0;
                        
                        break;
                    case 1:
                        col = 1;
                        
                        break;
                    case 2:
                        col = 2;
                        
                        break;

                }
                zombie.GetComponent<Renderer>().material.color = zombi.color [col];

                

                Vector3 pos2 = new Vector3();
                pos2.x = Random.Range(-10, 10);
                pos2.y = 0.5f;
                pos2.z = Random.Range(-10, 10);
                zombie.transform.position = pos2;
                zombie.tag = "Zombie";
              
                zombie.AddComponent<Heroe>();
                zombie.AddComponent<Rigidbody>();
                zombie.AddComponent<Zombie>();
            }
            else
            {
                ciudad.edad = Random.Range(15, 101);
                

                GameObject ciudada = GameObject.CreatePrimitive(PrimitiveType.Cylinder);

                Vector3 pos3 = new Vector3();
                pos3.x = Random.Range(-10, 10);
                pos3.y = 1f;
                pos3.z = Random.Range(-10, 10);
                ciudada.transform.position = pos3;

                Rigidbody rgbdy2 = ciudada.AddComponent<Rigidbody>();
                rgbdy2.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ;
                ciudada.tag =  "Ciudadano";
                ciudada.AddComponent<Ciudadano>();
               
            }
        }

    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
