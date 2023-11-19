using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class SeagullInfo : ScriptableObject
{
    public String prefabName;
    
    public float Speed;
    public List<Vector3> Waypoints; 
}
