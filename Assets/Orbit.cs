using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour
{
    //private float countdown = 1.0f;
    public GameObject planet;

    public Vector3 rotationAxis;
    public float rotationAngle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //CountdownToColorChange();
        transform.RotateAround(planet.transform.position, rotationAxis, rotationAngle);
    }

    /*public void CountdownToColorChange()
    {
        if (countdown < 0)
        {
            Renderer rend = planet.GetComponent<Renderer>();
            rend.material.color = planet.GetComponent<NewBehaviourScript>().GetRandomColor();
            countdown = 1.0f;
        } else
        {
            countdown -= Time.deltaTime;
        }
    }
    */
}
