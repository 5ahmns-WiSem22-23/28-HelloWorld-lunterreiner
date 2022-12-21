using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloVerzweigung : MonoBehaviour
{
    public bool boolV1 = true;
    public bool boolV2 = false;
    public bool boolV3 = true;

    public int i = 0;


    void Start()
    {
       
        if (boolV3 && boolV1)
        {
            Debug.Log("Sheeeesh");
        }
        else
        {
            Debug.Log("Falsch");
        }

        if (boolV1 && boolV2)
        {
            Debug.Log("Richtiiig");
        }
        else if (boolV1 && boolV2)
        {
            Debug.Log("sunst hoid richtig");
        }

        switch (i)
        {
            case 0:
                Debug.Log("Case 0 happend");
                break;
            case 1:
                Debug.Log("Case 1 happend");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
