using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    public AudioSource _as;
    public AudioClip collectSound;




    void Start(Collider2D col)
    {
        _as = GetComponent<AudioSource>();
    }


    void OnTriggerEnter2D(Collider2D col)
    {
       
       _as.PlayOneShot(collectSound);
     
        Destroy(gameObject);
    

    }


}
