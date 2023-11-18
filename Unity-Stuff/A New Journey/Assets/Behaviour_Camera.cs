using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Behaviour_Camera : MonoBehaviour
{
    void Update () {
        float tiltSpeed = 120f;
        transform.Rotate (new Vector3 (-Input.GetAxis ("Mouse Y") * tiltSpeed, 0f, 0f) * Time.deltaTime);
    }
}
