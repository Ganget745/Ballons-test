using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_baloons : MonoBehaviour {
   
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }

}