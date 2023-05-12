using UnityEngine;
using UnityEngine.Events;
using System.Collections;

public class UnityEventExample : MonoBehaviour
{
    public UnityEvent myEvent;

    void Start()
    {
        if (myEvent == null)
            myEvent = new UnityEvent();

        myEvent.AddListener(Ping);
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.K) && myEvent != null)
        {
            myEvent.Invoke();
        }
    }

    void Ping()
    {
        Debug.Log("Ping");
    }
}