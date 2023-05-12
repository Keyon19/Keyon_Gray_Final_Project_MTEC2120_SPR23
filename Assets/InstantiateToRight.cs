using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateToRight : MonoBehaviour
{
    public GameObject someObject;
    public Vector3 thePosition;
    // Start is called before the first frame update
    void Start()
    {
        thePosition = transform.TransformPoint(Vector3.right*2);
        Instantiate(someObject,thePosition,someObject.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
