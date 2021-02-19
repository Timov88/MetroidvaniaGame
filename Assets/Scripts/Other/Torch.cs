using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class Torch : MonoBehaviour
{
    Light2D light;
    
    // Start is called before the first frame update
    void Start()
    {
        light = GetComponent<Light2D>();

        InvokeRepeating("Intensity", 0, 0.12f);
    }

    void Intensity()
    {
        light.intensity = Random.Range(0.4f, 1.5f);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
