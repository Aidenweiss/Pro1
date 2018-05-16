using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Zombie : MonoBehaviour {

    public ZombieE zombis;
    
    int dir;

    behavior estado;

    int idle = 0;
    int moving;

    //	coorutina
    IEnumerator MovimientoZombie()
    {
        yield return new WaitForSeconds(2);
        estado = (behavior)Random.Range(0, 2);
        dir = Random.Range(0, 4);
        Moving();
        StartCoroutine(MovimientoZombie());
    }

    // Use this for initialization
    void Start()
    {
        zombis.partes = (gusto)Random.Range(0,5);
        zombis.zombiespd = 1.5f;
        StartCoroutine(MovimientoZombie());
    }
	
	// Update is called once per frame
	void Update () {
        switch (estado)
        {
          
            case behavior.moving:
                Moving();
                
                break;
        }
    }

    public void Moving()
    {
        switch (dir)
        {
            case 0:
                transform.position += transform.forward * zombis.zombiespd * Time.deltaTime;
                break;

            case 1:
                transform.position -= transform.forward * zombis.zombiespd * Time.deltaTime;
                break;

            case 2:
                transform.position += transform.right * zombis.zombiespd * Time.deltaTime;
                break;

            case 3:
                transform.position -= transform.right * zombis.zombiespd * Time.deltaTime;
                break;
        }
    }
}
