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

    KLD_GameManager gameManager;
    public Transform towerEmpty;
    public Transform rotateObj;

    private void Awake()
    {
        gameManager = GetComponent<KLD_GameManager>();
    }

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
        //spawnedObjInst = placeOnPlane.spawnedObject;

    }

    public void validatePosition()
    {
        isPlacingVillage = false;
        spawnedObjInst = placeOnPlane.spawnedObject;
        placeOnPlane.enabled = false;
        //getCurVillageInst();


        if (spawnedObjInst != null)
        {
            curTouchScaler = spawnedObjInst.transform.GetChild(0).GetComponent<KLD_TouchScaler>();
            curTouchScaler.isScalable = true;

            KLD_Village_Variables curVillage_Variables = spawnedObjInst.GetComponent<KLD_Village_Variables>();
            curVillage_Variables.assignTargetCam(gameManager.simulationCam);
            gameManager.RessourceUIParents = curVillage_Variables.RessourceUIParentsInst;

            towerEmpty = curVillage_Variables.towerEmpty;
            rotateObj = curVillage_Variables.rotateObj;

            gameManager.initializeTextes();
            gameManager.updateTowerUI();

        }
        else
        {
            Debug.LogError("there is no spawnedobj");
            print("there is no spawnedobj_p");
        }
    }

    public void validateScale()
    {
        curTouchScaler.isScalable = false;
    }

    void getCurVillageInst()
    {
        if (isPlacingVillage && placeOnPlane.spawnedObject != null)
        {
            spawnedObjInst = placeOnPlane.spawnedObject;
        }
    }


}
