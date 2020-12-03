using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BDC_MiningMinigame : MonoBehaviour
{

    public UnityEvent onClickMining;
    public GameObject canvasMining;
    public bool miningPhase;
    public int numberOfTouchRequiredMining = 10;
    public int miningTouchCount;


    void Update()
    {
        Touch touch = Input.GetTouch(0);

        if (miningPhase == true)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                miningTouchCount++;

                if (miningTouchCount > numberOfTouchRequiredMining)
                {
                    canvasMining.GetComponent<SpriteRenderer>().enabled = false;
                    miningPhase = false;
                    miningTouchCount = 0;
                }   
            }

        }
    }

    public void MiningMinigame()
    {
        canvasMining.GetComponent<SpriteRenderer>() .enabled = true;
        miningPhase = true;

    }

}
