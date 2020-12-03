using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KLD_TouchScaler : MonoBehaviour
{

    [SerializeField]
    Vector2 minMaxScale = new Vector2(0.02f, 0.2f);

    float curScale = 1f;

    [SerializeField]
    float sensitivity = 1f;

    public bool isScalable = false;

    float curTouchDistance, lastFrameTouchDistance;

    //MeshRenderer meshRenderer;

    private void Awake()
    {
        //meshRenderer = GetComponent<MeshRenderer>();
    }

    // Start is called before the first frame update
    void Start()
    {
        curScale = transform.localScale.x;
    }

    // Update is called once per frame
    void Update()
    {


        if (isScalable)
        {
            doScale();
        }
        else
        {
            //meshRenderer.material.color = Color.gray;
        }

        linkScale();
    }

    void doScale()
    {
        if (Input.touchCount >= 2)
        {
            //meshRenderer.material.color = Color.green;

            lastFrameTouchDistance = curTouchDistance;


            Vector2 a = Input.GetTouch(0).position;
            Vector2 b = Input.GetTouch(1).position;
            //Vector2 b = Vector2.one * 0.5f;

            //print(a);

            curTouchDistance = Vector2.Distance(a, b);

            float distanceDelta = curTouchDistance - lastFrameTouchDistance;

            curScale += distanceDelta * sensitivity * 0.01f;

            curScale = Mathf.Clamp(curScale, minMaxScale.x, minMaxScale.y);

        }
        else
        {
            //meshRenderer.material.color = Color.red;

            print("not enough touches");
        }
    }

    void linkScale()
    {
        transform.localScale = Vector3.one * curScale;
    }

}
