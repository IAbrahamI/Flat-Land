using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Followingcamera : MonoBehaviour
{
    //The following Object
    public Transform target;

    //Zeros out the velocity
    Vector3 velocity = Vector3.zero;

    //Time to follow target
    public float smoothTime = 15f;

    //Enable and set  the max Y Value
    public bool YMaxEnabled = false;
    public float YMaxValue = 0;
    //Enable and set  the min Y Value
    public bool YMinEnabled = false;
    public float YMinValue = 0;

    //Enable and set  the max X Value
    public bool XMaxEnabled = false;
    public float XMaxValue = 0;
    //Enable and set  the min X Value
    public bool XMinEnabled = false;
    public float XMinValue = 0;
    
    private void LateUpdate()
    {
        //Target Position
        Vector3 targetpos = target.position;

        //Vertical
        if(YMinEnabled && YMaxEnabled)
        {
            targetpos.y = Mathf.Clamp(target.position.y, YMinValue, YMaxValue);
        } else if (YMinEnabled)
        {
            targetpos.y = Mathf.Clamp(target.position.y, YMinValue, target.position.y);
        } else if (YMaxEnabled)
        {
            targetpos.y = Mathf.Clamp(target.position.y, target.position.y, YMaxValue);
        }
        //Horizontal
        if (XMinEnabled && XMaxEnabled)
        {
            targetpos.x = Mathf.Clamp(target.position.x, XMinValue, XMaxValue);
        }
        else if (XMinEnabled)
        {
            targetpos.x = Mathf.Clamp(target.position.x, XMinValue, target.position.x);
        }
        else if (XMaxEnabled)
        {
            targetpos.x = Mathf.Clamp(target.position.x, target.position.x, XMaxValue);
        }

        //Align the Camera Position
        targetpos.z = transform.position.z;

        transform.position = Vector3.SmoothDamp(transform.position, targetpos, ref velocity, smoothTime);
    }
}
