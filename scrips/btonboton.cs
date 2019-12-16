using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boton 
{

    public Animator BotonN;
    public Animator puerta;
    // Start is called before the first frame update
    void Start()
    {
        BotonN.SetBool("ON", false);
        puerta.SetBool("abrir", false);
    }

    // Update is called once per frame
    void onTriggerEntrer(Collider otro)
    {
        BotonN.SetBool("ON", true);
        puerta.SetBool("abrir", true);
    }
}
