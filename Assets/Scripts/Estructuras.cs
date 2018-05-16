using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct HeroeE
    { 

        public float speed;
    }

    public struct ZombieE
    {
        public Color[] color;
        public float zombiespd;
        public gusto partes;
    }

public enum behavior
{
    idle, moving
}

public enum gusto
{
    cerebro, pies, manos, higado, riñones

}

public struct CiudadanoE
    {
        public Nombres nombres;
        public int edad;
    }

public enum Nombres
{
    Abraham, Juan, Alejo, William, Cote,
    Tatiana, Carolina, Vanesa, Juliana, Cristina,
    Elkin, Sebastian, Roberto, Omar, Diego,
    Sara, Andrea, Jennifer, Laura, Karla
}

