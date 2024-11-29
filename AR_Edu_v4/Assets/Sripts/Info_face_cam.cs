using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Info_face_cam : MonoBehaviour
{
    void LateUpdate()
    {
        transform.LookAt(transform.position - Camera.main.transform.rotation * Vector3.forward);
        // transform.LookAt(Camera.main.transform.position);
    }
}
