using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttachedToCamera : MonoBehaviour
{
    [SerializeField]
    public Transform cameraTransform;
    [SerializeField]
    Vector3 offsetFromCamera;
    [SerializeField]
    float turnBufferInDegrees = 30f;
    [SerializeField]
    float turnSpeed = 30f;
    [SerializeField]
    bool lockPitch = false;
    public bool locked = true;
   

    GameObject obj;

    
    void Start()
    {
        
        transform.localPosition = cameraTransform.localPosition + offsetFromCamera;

        //transform.rotation.eulerAngles.y = cameraTransform.rotation.eulerAngles.y;
        /*Vector3 cameraEuler = cameraTransform.rotation.eulerAngles;



        if(lockPitch)
        {
            cameraEuler.z = 0f;
            cameraEuler.x = 0f;
        }

        Quaternion targetQuat = Quaternion.Euler(cameraEuler);

        float angle = Quaternion.Angle(transform.rotation, targetQuat);

        transform.rotation = Quaternion.Lerp(transform.rotation, targetQuat, turnSpeed);

        if (angle > turnBufferInDegrees)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, targetQuat, turnSpeed);
        }*/
    }

    // Update is called once per frame
    void Update()
    {
        obj = GameObject.Find("Cube Chair");
        OVRGrabbable check = obj.GetComponent <OVRGrabbable>();

        /*Vector3 cameraEuler = cameraTransform.rotation.eulerAngles;

        if (lockPitch)
        {
            cameraEuler.z = 0f;
            cameraEuler.x = 0f;
        }

        Quaternion targetQuat = Quaternion.Euler(cameraEuler);

        float angle = Quaternion.Angle(transform.rotation, targetQuat);*/

        



        bool grabbedOnce = check.isGrabbed;
        if(grabbedOnce == true)
        {
            locked = false;
        }

        if (locked == true)
        {
            transform.localPosition = cameraTransform.localPosition + offsetFromCamera;
            //transform.rotation = Quaternion.Lerp(transform.rotation, targetQuat, turnSpeed);
        }

        //transform.localPosition = cameraTransform.localPosition + offsetFromCamera;

    }
}
