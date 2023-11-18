using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class PlayerInfo : ScriptableObject
{
    public float moveSpeedMultiplier = 10f;
    public float sensitivity = 10f;
    public float minCameraAngle = -32f;
    public float maxCameraAngle = 60f;
    public float jumpForce = 10f;
}
