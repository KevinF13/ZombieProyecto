using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public Rigidbody projectile;
    public Transform bala;
    public GameObject sonido;    // Add your Audi Clip Here;
     // This Will Configure the  AudioSource Component; 
     // MAke Sure You added AudioSouce to death Zone;
     
    
 void Update()
    {
        
        
        if (Input.GetButtonDown("Fire1"))
        {
          Shoot(); 
        }
    }

    void Shoot(){
        Instantiate(sonido);
        Rigidbody bullet;
        bullet = Instantiate(projectile, bala.position, bala.rotation);
        bullet.velocity = bala.TransformDirection(Vector3.forward*6);
        Destroy(bullet, 5);
       
        
    }
}
