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



        if ((Input.touchCount > 0) && (Input.GetTouch(0).phase == TouchPhase.Moved))
        {

            Ray raycast = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit;

            if (Physics.Raycast(raycast, out hit))
            {
                if (hit.collider.CompareTag("Tree"))
                {
                    treeTouchCount++;

                }
            }

            if (treeTouchCount > numberofTouchRequiredTree)
            {

                treeTouchCount = 0;
                Destroy(gameObject);
            }


        }
  
    
    }

