using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    private Transform cam;
    public Transform lookAtTarget;

    void Start()
    {
        cam = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        cam.LookAt(lookAtTarget, Vector3.up);
    }
}
