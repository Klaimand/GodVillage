using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BDC_FruitMiniGame : MonoBehaviour
{

    public UnityEvent onClick;
    public GameObject canvasFruit;
    public bool fruitPhase;
    public int numberOfTouchRequiredMining = 10;
    public int miningTouchCount;


    void Update()
    {
        Touch touch = Input.GetTouch(0);

        if (fruitPhase == true)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                miningTouchCount++;

                if (miningTouchCount > numberOfTouchRequiredMining)
                {
                    canvasFruit.GetComponent<SpriteRenderer>().enabled = false;
                    fruitPhase = false;
                    miningTouchCount = 0;
                }
            }

        }
    }

    public void MiningMinigame()
    {
        canvasFruit.GetComponent<SpriteRenderer>().enabled = true;
        fruitPhase = true;

    }

}
