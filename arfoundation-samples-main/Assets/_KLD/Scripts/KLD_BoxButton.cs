using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class KLD_BoxButton : MonoBehaviour
{

    public UnityEvent OnClick;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (detectClick())
        {
            OnClick.Invoke();
        }
    }


    bool detectClick()
    {
        if ((Input.touchCount > 0) && (Input.GetTouch(0).phase == TouchPhase.Began))
        {
            Ray raycast = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit;

            if (Physics.Raycast(raycast, out hit))
            {
                if (hit.collider.gameObject == gameObject)
                {
                    return true;
                }
            }
        }
        return false;
    }



}
