using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamController : MonoBehaviour
{
    public Camera cam;
    public float ScrollSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate( new Vector3(Input.GetAxis("Horizontal"),0,Input.GetAxis("Vertical")));
        cam.fieldOfView -= Input.GetAxis("Mouse ScrollWheel") * ScrollSpeed;
        cam.fieldOfView = Mathf.Clamp(cam.fieldOfView,50,75);
    }
}
