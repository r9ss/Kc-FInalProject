
using UnityEngine;

public class gun : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;
    public float impactForce = 160f;
    public bool HoldingGun = false;

    public Camera fpsCam;
    public ParticleSystem muzzleFlash;
    public GameObject impactEffect;
    public AudioSource audio;
    
  


    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
           ;
           Shoot();
           
        }

    }

    void Shoot ()
    {
       muzzleFlash.Play();
       audio = GetComponent<AudioSource>();
       audio.Play();

       RaycastHit hit;
      if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
         {
            Debug.Log(hit.transform.name);

            target target = hit.transform.GetComponent<target>();
            if (target != null)
            {
               target.TakeDamage(damage);
               GameObject impactGo = Instantiate(impactEffect, hit.point, Quaternion.LookRotation(hit.normal));
            Destroy(impactGo, 0.9f);
            }
                
                if (hit.rigidbody != null)
                {
                    hit.rigidbody.AddForceAtPosition(transform.forward * impactForce, hit.point);
                }
            
            
         }
    }
   
}
