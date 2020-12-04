using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EMD_Tremblement : MonoBehaviour
{
    public GameObject Volcan;
    public GameObject Obsidienne;
    Vector3 defaultPos ;
    Vector3 BasePos;
    public float shakeAmount;
    public float Timer;
    bool IsShacking = false;
    bool IsDone = false;
    public int VillageLevel; //Récupérer le niveau de village 

    private void Start()
    {
        BasePos = Volcan.transform.position;
    }
    void Update()
    {
        DetectTouch();

        if (IsShacking == true)
        {
            Timer -= Time.deltaTime;
            Shacking();
        }

        if (Timer <= 0 && IsDone == false)
        {
            IsShacking = false;
            //instantiate ressources
            Instantiate(Obsidienne, BasePos, Quaternion.identity);
            Destroy(Volcan);
            IsDone = true;
        }
    }

    void Shacking()
    {
        defaultPos = Volcan.transform.position;
        Volcan.transform.position = defaultPos + Random.insideUnitSphere * shakeAmount;
    }
    void DetectTouch()
    {
        if ((Input.touchCount > 0) && (Input.GetTouch(0).phase == TouchPhase.Began) && (VillageLevel > 4))
        {
            Ray raycast = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit;
            if (Physics.Raycast(raycast, out hit))
            {
                if (hit.collider.gameObject.CompareTag("Volcan"))
                {
                    IsShacking = true;
                }
            }
        }
    }
}
