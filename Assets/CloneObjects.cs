using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloneObjects : MonoBehaviour
{



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public GameObject Cubo;

    int i;

    public void CloneObject()
    {
        

        while (i != 3)
        {
            Instantiate(Cubo);

            i++;
        }

        i = 0;



        
    }

    
}
