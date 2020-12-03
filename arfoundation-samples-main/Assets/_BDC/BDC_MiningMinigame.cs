using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BDC_MiningMinigame : MonoBehaviour
{


    public int numberOfTouchRequiredMining = 10;
    private int miningTouchCount;


    void Update()
    {


        if ((Input.touchCount > 0) && (Input.GetTouch(0).phase == TouchPhase.Began))
        {

            Ray raycast = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit;

            if (Physics.Raycast(raycast, out hit))
            {
                if (hit.collider.CompareTag("Minerals"))
                {
                    miningTouchCount++;

                }
            }

            if (miningTouchCount > numberOfTouchRequiredMining)
            {

                miningTouchCount = 0;
                Destroy(gameObject);
            }


        }

    }

}
