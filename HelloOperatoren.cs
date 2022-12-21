using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloOperatoren : MonoBehaviour
{
    public bool boolV1 = true;
    public bool boolV2 = false;
    public bool boolV3 = true;

    public int zahl1 = 5;
    public int zahl2 = 7;

    void Start()
    {
        if (boolV1 || boolV2 || boolV3)
        {
            Debug.Log("HelloWorld");
        }

        if (boolV3 && boolV1)
        {
            Debug.Log("Sheeeesh");
        }

        if (zahl2 > zahl1)
        {
            Debug.Log("Richtiiig");
        }

        if (zahl1 < 14)
        {
            Debug.Log("Niiice");
        }

        if (zahl2 > 14)
        {
            Debug.Log("Oha");
        }
    }
}
