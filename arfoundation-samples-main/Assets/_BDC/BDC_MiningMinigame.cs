using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BDC_MiningMinigame : MonoBehaviour
{
    KLD_GameManager gameManager;

    public int numberOfTouchRequiredMining = 10;
    private int miningTouchCount;

    public int neededLevel;

    public GameObject particle;
    public GameObject ressource;

    private void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<KLD_GameManager>();
    }

    void Update()
    {


        if ((Input.touchCount > 0) && (Input.GetTouch(0).phase == TouchPhase.Began))
        {

            Ray raycast = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit;

            if (Physics.Raycast(raycast, out hit))
            {
                if (hit.collider.gameObject == gameObject)
                {
                    if (gameManager.getVillageLevel() >= neededLevel)
                    {
                        miningTouchCount++;
                        Instantiate(particle, hit.point, Quaternion.identity);
                    }
                }
            }

            if (miningTouchCount > numberOfTouchRequiredMining)
            {
                //instantiate ressources
                Instantiate(ressource, transform.position, Quaternion.identity);
                miningTouchCount = 0;
                Destroy(gameObject);
            }


        }

    }

}
