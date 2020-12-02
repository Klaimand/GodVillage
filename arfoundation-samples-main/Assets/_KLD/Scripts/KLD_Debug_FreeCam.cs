using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KLD_Debug_FreeCam : MonoBehaviour
{

    [SerializeField]
    float speed = 1f;

    [SerializeField]
    float sensitivity = 30f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        translateCam();

        if (Input.GetButton("Fire1"))
        {
            rotateCam();
        }
    }

    void translateCam()
    {
        transform.position += new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("ThirdAxis"), Input.GetAxisRaw("Vertical")) * speed * Time.deltaTime;
    }

    void rotateCam()
    {
        transform.Rotate(new Vector3(Input.GetAxisRaw("Mouse Y"), Input.GetAxisRaw("Mouse X") * -1f, 0f) * sensitivity * 10f * Time.deltaTime);
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, 0f);
    }
}
