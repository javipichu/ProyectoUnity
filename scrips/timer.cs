using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class temporizador : MonoBehaviour{
    public float tiempo =1;
    public string nivel; 
    void Start(){
        StartCoroutine (Temp ());
    
    }

   IEnumerator Temp()  {
        yield return new WaitForSeconds(tiempo);
        Application.LoadLevel(nivel);




    }
   

}
