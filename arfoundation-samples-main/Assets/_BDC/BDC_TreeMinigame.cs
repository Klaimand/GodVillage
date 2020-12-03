using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BDC_TreeMinigame : MonoBehaviour
{
    public UnityEvent onClickTree;
    public GameObject canvasTree;
    public bool treePhase;
    public int numberofTouchRequiredTree = 10;
    public int treeTouchCount;


    void Update()
    {
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

}
