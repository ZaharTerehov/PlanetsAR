using System;
using UnityEngine;
using UnityEngine.WSA;

public class RatationController : MonoBehaviour
{
    public GameObject Planet;
    public Vector3 Rotation;

    private void Update()
    {
        Planet.transform.Rotate(Rotation * Time.deltaTime);
    }
}
