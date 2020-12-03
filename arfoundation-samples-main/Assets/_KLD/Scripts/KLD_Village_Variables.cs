using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KLD_Village_Variables : MonoBehaviour
{

    public GameObject[] RessourceUIParentsInst;

    [SerializeField]
    KLD_WorldCanvasToCam worldCanvasToCam;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void assignTargetCam(Transform _camera)
    {
        worldCanvasToCam.targetCam = _camera;
    }
}
