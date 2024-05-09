using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    // makes game object for dog and sets a fire delay for how often it can be spawned
    public GameObject dogPrefab;
    public float fireDelay = 3.0f;

    // Update is called once per frame
    void Update()
    {

        fireDelay -= 0.1F;

        // On spacebar press, send dog and sets a fire delay for how often you can fire the dog
        if (Input.GetKeyDown(KeyCode.Space) && fireDelay <= 0.0f)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            fireDelay = 3.0f;
        }
    }
}
