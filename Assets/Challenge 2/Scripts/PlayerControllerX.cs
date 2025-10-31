using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private bool readyToSpawn = true;
    public float coolDownInterval = 0.5f;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (readyToSpawn)
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                readyToSpawn = false;
                Invoke(nameof(BecomeReady), coolDownInterval);
            }
        }        
    }
    void BecomeReady()
    {
        readyToSpawn = true;
    }
}


