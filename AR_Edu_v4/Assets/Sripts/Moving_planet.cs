using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving_planet : MonoBehaviour
{
    [Tooltip("Changes the rotation speed of the planet")]
    public float rotateSpeed = 1f;

    [Tooltip("Changes orientation of the planet")]
    public Vector3 objectRotation;

    [Tooltip("Planets Orbit Distance")]
    public float orbitDist = 1f;

    [Tooltip("Planets Orbit Speed")]
    public float orbitSpeed = 0.1f;
    
    public Transform target;
    public float angle = 0f;
    private float speedScale = 0.2f;
    // Update is called once per frame
    void Update()
    {
      float x = target.position.x + Mathf.Cos(angle) * orbitDist;
      float y = target.position.y;
      float z = target.position.z + Mathf.Sin(angle) * orbitDist;

      transform.Rotate(objectRotation * Time.deltaTime * rotateSpeed);
      transform.position = new Vector3(x, y, z);
      angle += (orbitSpeed + Time.deltaTime) * speedScale;

    }
}
