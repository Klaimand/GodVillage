using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BDC_TreeMinigame : MonoBehaviour
{

    [SerializeField]
    GameObject popParticle;

    [SerializeField]
    GameObject bois_ressource;

    public int numberofTouchRequiredTree = 10;
    private int treeTouchCount;


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
                    Instantiate(popParticle, hit.point, Quaternion.identity);
                }
            }

            if (treeTouchCount > numberofTouchRequiredTree)
            {
                //instantiate ressources
                Instantiate(bois_ressource, transform.position, Quaternion.identity);
                treeTouchCount = 0;
                Destroy(gameObject);
            }


        }
    }

}
