using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Color color;

    private Renderer rend;
    void Start()
    {
       rend = GetComponent<Renderer>();
       rend.material.color = GetRandomColor();


    }

    public Color GetRandomColor()
    {
        return new Color(UnityEngine.Random.Range(0f,1f), UnityEngine.Random.Range(0f, 1f), UnityEngine.Random.Range(0f, 1f));
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
