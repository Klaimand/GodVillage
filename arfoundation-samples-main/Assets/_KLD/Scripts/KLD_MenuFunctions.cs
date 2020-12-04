using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;


public class KLD_MenuFunctions : MonoBehaviour
{

    [SerializeField]
    KLD_GameManager gameManager;

    [SerializeField]
    Transform arSessionOrigin;

    ARPlaneManager planeManager;
    ARPointCloudManager pointCloudManager;

    KLD_RandomPointPlacer randomPointPlacer;

    bool isArDebugVisible = true;

    [Header("SpawnPointsPlacer"), SerializeField]
    float minDistanceBetweenPoints = 10f;
    [SerializeField]
    GameObject spawnPointObj;

    List<Vector3> spawnPointsPositions = new List<Vector3>();


    private void Awake()
    {
        randomPointPlacer = GetComponent<KLD_RandomPointPlacer>();
    }

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

    public void addSpawnPointsToWorld(int _number)
    {
        for (int i = 0; i < _number + 1; i++)
        {
            bool isCurPointValid = false;
            Vector3 verifiedSpPosition = Vector3.zero;
            do
            {

                Vector3 pointInst = randomPointPlacer.getRandomPointOnPlane();

                bool isPositionTooClose = false;
                foreach (Vector3 spPosition in spawnPointsPositions)
                {
                    if (Vector3.Distance(pointInst, spPosition) < minDistanceBetweenPoints)
                    {
                        isPositionTooClose = true;
                    }
                }

                isCurPointValid = !isPositionTooClose;

                if (isCurPointValid)
                {
                    verifiedSpPosition = pointInst;
                }

            } while (!isCurPointValid);

            //inst
            int curRessourceIndex = i % gameManager.ressourcesPrefabs.Count;
            print("RessourceIndex : " + curRessourceIndex);
            //GameObject objToInst = gameManager.ressourcesPrefabs[0][1];
            Instantiate(spawnPointObj, verifiedSpPosition, Quaternion.identity);

        }
    }


    public void testfunc()
    {
        for (int i = 0; i < 10; i++)
        {
            print(i % 7);
        }
    }

}
