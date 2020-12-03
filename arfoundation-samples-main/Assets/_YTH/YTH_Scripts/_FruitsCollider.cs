using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _FruitsCollider : MonoBehaviour
{
    BDC_FruitMiniGame fruitsGame;

    private void Start()
    {
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
                if (hit.collider.gameObject.CompareTag("Fruits"))
                {
                    fruitsGame.numberOfFruits -= 1;
                    print(gameObject.name + "Destroyed by " + this.name);
                    Destroy(hit.collider.gameObject);
                }
            }
        }
    }
}
