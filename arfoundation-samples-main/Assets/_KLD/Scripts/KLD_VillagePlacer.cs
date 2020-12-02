using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation.Samples;

public class KLD_VillagePlacer : MonoBehaviour
{

    [SerializeField]
    PlaceOnPlane placeOnPlane;
    bool isPlacingVillage = false;


    GameObject spawnedObjInst;
    KLD_TouchScaler curTouchScaler;

    // Start is called before the first frame update
    void Start()
    {
        isPlacingVillage = true;
        placeOnPlane.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {

        /*
        if (Input.GetKeyDown(KeyCode.A))
        {
            validatePosition();
        }*/
    }

    public void validatePosition()
    {
        isPlacingVillage = false;
        placeOnPlane.enabled = false;
        //getCurVillageInst();

        spawnedObjInst = placeOnPlane.spawnedObject;

        if (spawnedObjInst != null)
        {
            curTouchScaler = spawnedObjInst.GetComponent<KLD_TouchScaler>();
            curTouchScaler.isScalable = true;

        }
        else
        {
            Debug.LogError("there is no spawnedobj");
        }


    }

    void getCurVillageInst()
    {
        if (isPlacingVillage && placeOnPlane.spawnedObject != null)
        {
            spawnedObjInst = placeOnPlane.spawnedObject;
        }
    }


}
