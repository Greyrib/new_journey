using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controls : MonoBehaviour
{
    Rigidbody rb;

    void Start () {
        rb = GetComponent<Rigidbody>();
    }

    void Update () {
        transform.Rotate (new Vector3 (0f, Input.GetAxis ("Mouse X") * 120f, 0f) * Time.deltaTime);

        Movement ();

        // Jumping
        if (Input.GetKeyDown (KeyCode.Space) && rb != null) {
            rb.AddForce (Vector3.up * rb.mass * 200f);
        }
    }

    void Movement () {
        float speed = 3f;
        Vector3 forwardMovement = Vector3.forward * Input.GetAxis ("Vertical") * speed;
        Vector3 strafeMovement = Vector3.right * Input.GetAxis ("Horizontal") * speed;
        Vector3 finalMovement = forwardMovement + strafeMovement;
        transform.Translate (finalMovement * Time.deltaTime);
    }

    void FixedUpdate () {
        if (rb != null) {
            Vector3 forwardForce = rb.transform.forward * Input.GetAxis ("Vertical");
            Vector3 strafeForce = rb.transform.right * Input.GetAxis ("Horizontal");
            //rb.AddForce ((forwardForce + strafeForce) * rb.mass);
        }
    }

    void LateUpdate () {
        // Set camera to player's view
        if (Camera.main != null) {
            Camera.main.transform.position = transform.position + (Vector3.up * 0.5f);
            Camera.main.transform.rotation = Quaternion.Euler (Camera.main.transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, Camera.main.transform.rotation.eulerAngles.z);
        }
    }
}
