using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BDC_FruitMiniGame : MonoBehaviour
{
    public GameObject[] fruits;
    public int fruitRessources;
    public int numberOfFruits;

    private void Start()
    {
        numberOfFruits = fruits.Length;
    }
    void Update()
    {
        if (numberOfFruits <= 0)
        {
            //CurValue += fruitRessources
            Destroy(gameObject);
        }
    }

}
