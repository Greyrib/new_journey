using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision_PlayerDiesOnContact : MonoBehaviour
{
    void OnCollisionEnter (Collision col) {
        if (col.transform.root.tag == "Player" && DeathFader.instance != null) {
            DeathFader.instance.Player_Died ();
        }
    }
}
