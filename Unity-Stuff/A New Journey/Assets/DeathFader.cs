using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class DeathFader : MonoBehaviour
{
    public static DeathFader instance;

    [Header ("References")]
    public Image blackscreen;
    public TextMeshProUGUI youDiedText;
    
    [Header ("Dynamics")]
    public bool playerHasDied = false; // Globally accessible by other classes, so e.g. player move input or player shoot-gun-at-seagulls-firebutton knows if player is dead or not

    void Awake () {
        if (instance == null) instance = this; else Destroy (this);

        if (blackscreen != null) {
            blackscreen.color = new Color (blackscreen.color.r, blackscreen.color.g, blackscreen.color.b, 0f);
        }
        if (youDiedText != null) {
            youDiedText.color = new Color (youDiedText.color.r, youDiedText.color.g, youDiedText.color.b, 0f);
        }
    }

    public void Player_Died () {
        if (playerHasDied == true) {
            return;
        } else {
            playerHasDied = true;
            StartCoroutine (Death_Fade_Sequence ());
        }
    }

    IEnumerator Death_Fade_Sequence () {
        if (blackscreen != null) {
            while (blackscreen.color.a < 1f) {
                float faderate = 1f;
                blackscreen.color = new Color (blackscreen.color.r, blackscreen.color.g, blackscreen.color.b, blackscreen.color.a + faderate * Time.deltaTime);
                yield return new WaitForEndOfFrame();
            }
        }

        if (youDiedText != null) {
            youDiedText.color = new Color (youDiedText.color.r, youDiedText.color.g, youDiedText.color.b, 1f);
        }

        yield return null;
    }

}
