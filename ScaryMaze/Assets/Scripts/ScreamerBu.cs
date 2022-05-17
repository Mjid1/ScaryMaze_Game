using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]
public class ScreamerBu : MonoBehaviour
{

    public GameObject Susto;
    public float TiempoEspera;
    
    private void OntriggerEnter(Collider other) 
    {
        if (other.tag == "Player")
        {

            Susto.SetActive(true);
            Destroy(gameObject, 2);
            Destroy(Susto, 2);

        }
    }
}
