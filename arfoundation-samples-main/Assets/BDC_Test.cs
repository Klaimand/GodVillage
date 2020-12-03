using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BDC_Test : MonoBehaviour
{

    public UnityEvent onclick;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        onclick.Invoke();
    }

    public void printent(string _message)
    {
        Debug.Log(_message);
    }
}
