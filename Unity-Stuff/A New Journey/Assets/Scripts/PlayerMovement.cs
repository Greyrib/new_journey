using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb;
    private float moveHorizontal;
    private float moveVertical;
    private float mouseHorizontal;
    private float mouseVertical;
    public Camera playerCam;
    public PlayerInfo playerInfo;
    
    private float YRotation;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        moveHorizontal = Input.GetAxis("Horizontal");
        moveVertical = Input.GetAxis("Vertical");
        mouseHorizontal = Input.GetAxis("Mouse X");
        mouseVertical = Input.GetAxis("Mouse Y");
        YRotation += mouseVertical * playerInfo.sensitivity;
        YRotation = Mathf.Clamp(YRotation, playerInfo.minCameraAngle, playerInfo.maxCameraAngle);
        playerCam.transform.localRotation = Quaternion.Euler(-YRotation, 0f, 0f);
        if (Input.GetKey(KeyCode.Space)) rb.AddForce(transform.up * playerInfo.jumpForce, ForceMode.Impulse);
    }

    // Todo: use fixed update for vertical camera rotation
    void FixedUpdate()
    {
        //move player
        transform.Translate(transform.forward * (moveVertical * playerInfo.moveSpeedMultiplier), Space.World);
        transform.Translate(transform.right * (moveHorizontal * playerInfo.moveSpeedMultiplier), Space.World);
        //turn player from mouse X axis
        transform.Rotate(0, mouseHorizontal * playerInfo.sensitivity, 0);
    }
}