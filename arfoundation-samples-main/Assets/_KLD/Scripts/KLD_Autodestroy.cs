using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KLD_Autodestroy : MonoBehaviour
{

    [SerializeField]
    float timeToWait = 5f;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, timeToWait);
    }
}
