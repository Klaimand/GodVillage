using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KLD_Village_Variables : MonoBehaviour
{

    public GameObject[] RessourceUIParentsInst;

    KLD_GameManager gameManager;

    [SerializeField]
    KLD_WorldCanvasToCam worldCanvasToCam;

    public Transform towerEmpty;

    public Transform rotateObj;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<KLD_GameManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void assignTargetCam(Transform _camera)
    {
        worldCanvasToCam.targetCam = _camera;
    }

    public void tryToLevelUpInst()
    {
        gameManager.tryToLevelUp();
        Debug.Log("tried to level up");
    }
}
