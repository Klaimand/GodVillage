using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class KLD_RandomPointPlacer : MonoBehaviour
{
    [SerializeField]
    ARPlaneManager planeManager;

    [SerializeField]
    ARRaycastManager raycastManager;

    List<ARRaycastHit> hits = new List<ARRaycastHit>();

    [SerializeField]
    Transform arCam;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public Vector3 getRandomPointOnPlane()
    {
        bool haveGoodRay = false;

        while (!haveGoodRay)
        {
            Ray randomRay = new Ray(arCam.position, Random.onUnitSphere);
            if (raycastManager.Raycast(randomRay, hits, UnityEngine.XR.ARSubsystems.TrackableType.Planes))
            {
                haveGoodRay = true;
                return hits[0].pose.position;
            }
        }

        Debug.LogError("didnt get a random point on plane so return origin");
        return Vector3.zero;
    }



}
