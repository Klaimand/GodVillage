using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BDC_FruitMiniGame : MonoBehaviour
{
    public GameObject[] fruits;
    public GameObject Baies;
    public int numberOfFruits;

    KLD_GameManager gameManager;

    private void Start()
    {
        numberOfFruits = fruits.Length;
    }
    void Update()
    {
        if (numberOfFruits <= 0)
        {
            Instantiate(Baies, gameObject.transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }

}
