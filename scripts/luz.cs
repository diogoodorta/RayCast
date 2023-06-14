using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class luz : MonoBehaviour
{

    public bool estaligada;
    // Start is called before the first frame update
    void Start()
    {
        estaligada = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(!estaligada) {
            GetComponent<Light> (). enabled = false;
         } else {
            GetComponent<Light> (). enabled = true;
         }

        if(Input.GetKeyDown(KeyCode.Mouse1) && !estaligada) {
            estaligada = true;
         } else if(Input.GetKeyDown(KeyCode.Mouse1) && estaligada) {
            estaligada = false;
         }
    }
}
