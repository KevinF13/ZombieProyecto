using System.Transactions;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Collections.ObjectModel;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterRaycast : MonoBehaviour
{
    public bool disparo = false;
    public Ray rayo;
    public RaycastHit impacto;
    public Transform bala;
    public GameObject sonido;    // Add your Audi Clip Here;
     // This Will Configure the  AudioSource Component; 
     // MAke Sure You added AudioSouce to death Zone;
     
    
 void Update()
    {
        if (Input.GetButtonDown("Fire1") && !disparo)
        {
          Shoot(); 
        }
    }

    void Shoot(){
        disparo = true;
        Instantiate(sonido);
        rayo.origin = bala.position;
        rayo.direction = bala.forward;
        if(Physics.Raycast(rayo, out impacto))
        {
            UnityEngine.Debug.DrawLine(rayo.origin, impacto.point, Color.red, 1.0f);
            if(impacto.collider.tag == "zombie")
            {
                UnityEngine.Debug.Log("Raycast a golpeado a zombie");
                impacto.collider.gameObject.GetComponent <DestruirCubo>().destruircubito();
            }
        }
        disparo=false;
    }
}
