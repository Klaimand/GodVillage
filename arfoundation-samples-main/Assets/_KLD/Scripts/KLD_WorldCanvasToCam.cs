using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KLD_WorldCanvasToCam : MonoBehaviour
{
    [SerializeField]
    Transform rotateObj;

    //[SerializeField]
    public Transform targetCam;

    [SerializeField]
    CanvasGroup canvasGroup;

    [SerializeField]
    Vector2 minMaxFadeDistance;

    [SerializeField]
    float damping = 1f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (targetCam != null)
        {
            doCanvasAlpha();
            doCanvasRotation();
        }
        else
        {
            canvasGroup.alpha = 0f;
        }

    }

    void doCanvasAlpha()
    {
        float distance = Vector3.Distance(rotateObj.position, targetCam.position);
        float alpha = 0f;

        if (distance < minMaxFadeDistance.x)
        {
            alpha = 1f;
        }
        else if (distance > minMaxFadeDistance.y)
        {
            alpha = 0f;
        }
        else
        {
            alpha = 1 - (distance - minMaxFadeDistance.x) / (minMaxFadeDistance.y - minMaxFadeDistance.x);
            //Debug.Log("in btw");
        }

        canvasGroup.alpha = alpha;
    }

    void doCanvasRotation()
    {
        //rotateObj.LookAt(targetCam);

        var lookPos = targetCam.position - rotateObj.position;
        lookPos.y = 0;
        var rotation = Quaternion.LookRotation(lookPos);
        rotateObj.rotation = Quaternion.Slerp(rotateObj.rotation, rotation, Time.deltaTime * damping);
    }


}
