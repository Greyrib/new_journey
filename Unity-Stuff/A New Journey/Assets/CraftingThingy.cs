using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftingThingy : MonoBehaviour
{
    [Header ("Dynamics")]
    public bool itemsDetected;

    void Start () {
        if (InteractionHandler.instance != null) {
            InteractionHandler.instance.Request_New_ProgressIndicators (transform);
        }
    }

    
    
}
