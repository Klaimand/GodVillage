using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;


public class KLD_MenuFunctions : MonoBehaviour
{

    [SerializeField]
    Transform arSessionOrigin;

    ARPlaneManager planeManager;
    ARPointCloudManager pointCloudManager;

    bool isArDebugVisible = true;

    private void Start()
    {
        planeManager = arSessionOrigin.GetComponent<ARPlaneManager>();
        pointCloudManager = arSessionOrigin.GetComponent<ARPointCloudManager>();
    }

    private void Update()
    {
        if (!isArDebugVisible)
        {
            foreach (var plane in planeManager.trackables)
            {
                plane.gameObject.SetActive(false);
            }
            foreach (var point in pointCloudManager.trackables)
            {
                point.gameObject.SetActive(false);
            }
            //print("p");
        }
    }

    public void disablePlaneVisibility()
    {
        isArDebugVisible = false;
    }

    public void stopArCalculations()
    {
        planeManager.enabled = false;
        pointCloudManager.enabled = false;
    }

    public void disableARDebugVisibility()
    {
        foreach (var plane in planeManager.trackables)
        {
            plane.gameObject.SetActive(false);
        }
        planeManager.enabled = false;

        foreach (var point in pointCloudManager.trackables)
        {
            point.gameObject.SetActive(false);
        }
        pointCloudManager.enabled = false;

    }


}
