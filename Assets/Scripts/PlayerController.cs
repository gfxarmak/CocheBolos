using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour

    //Propiedades o variables
  


{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Tenemos que mover el coche hacia delante
        transform.Translate(60* Time.deltaTime * Vector3.forward);
        
        
    }
}
