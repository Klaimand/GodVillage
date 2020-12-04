using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _FruitsCollider : MonoBehaviour
{
    BDC_FruitMiniGame fruitsGame;

    KLD_GameManager gameManager;

    public int neededLevel;

    private void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<KLD_GameManager>();

        fruitsGame = GetComponentInParent<BDC_FruitMiniGame>();
    }

    private void Update()
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
                        fruitsGame.numberOfFruits -= 1;
                        //print(gameObject.name + "Destroyed by " + this.name);
                        Destroy(gameObject);
                    }
                }
            }
        }
    }
}
