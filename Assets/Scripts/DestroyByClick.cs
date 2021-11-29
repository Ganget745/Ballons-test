using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByClick : MonoBehaviour
{

    public Spawn Spawner;
    private void OnMouseDown()
    {
            Destroy(gameObject);
        Spawner.UpdateScore(1);
    }
}
