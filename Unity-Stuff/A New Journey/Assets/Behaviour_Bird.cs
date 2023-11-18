using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Behaviour_Bird : MonoBehaviour
{
    Vector3 originScale;

    void Awake () {
        originScale = transform.localScale;
    }

    void Update () {
        Scale_Animation ();
        Birb_Movement ();
    }

    void Scale_Animation () {
        float sin = Mathf.Abs (Mathf.Sin (Time.time));
        float invert = 1f - sin;
        //Debug.Log (sin +" | " +invert);
        transform.localScale = new Vector3 (originScale.x + (originScale.x * 2.0f * sin), originScale.y + (originScale.y * 0.5f * invert), originScale.z);
    }

    void Birb_Movement () {
        float speed = 10f;
        transform.Translate (transform.forward * speed * Time.deltaTime);
        transform.Rotate (new Vector3 (0f, -10f, 0f) * Time.deltaTime);
    }

}
