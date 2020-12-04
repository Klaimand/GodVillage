using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _ObsidienneCollider : MonoBehaviour
{

    private void Update()
    {
        if ((Input.touchCount > 0) && (Input.GetTouch(0).phase == TouchPhase.Began))
        {
            Ray raycast = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit;

            if (Physics.Raycast(raycast, out hit))
            {
                if (hit.collider.gameObject.CompareTag("Obsidienne"))
                {
                    // Ajouter Ajout ressources
                    Destroy(hit.collider.gameObject);
                }
            }
        }
    }
}
