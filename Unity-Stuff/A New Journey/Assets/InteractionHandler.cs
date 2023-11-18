using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class InteractionHandler : MonoBehaviour
{
    public static InteractionHandler instance;

    [Header ("References")]
    public TextMeshProUGUI interactText;

    [Header ("Progress Indicators")]
    public GameObject progressIndicatorPrefab;
    public Transform progressIndicatorParent;

    void Awake () {
        if (instance == null) instance = this; else Destroy (this);
    }

    public void Set_InteractPrompt_Text (string newText) {
        if (interactText != null) {
            interactText.text = newText;
        }
    }

    #region progress_indicators
    public void Request_New_ProgressIndicators (Transform requester) {
        GameObject newProg = Instantiate (progressIndicatorPrefab, progressIndicatorParent) as GameObject;
        newProg.name = progressIndicatorPrefab.name;
    }

    
    #endregion progress_indicators

}
