using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Light : MonoBehaviour {
    public Collider2D collider;
    public Image im;
    public Text[] k;
    void Start() {
        k = GetComponentsInChildren<Text>();
        collider = GetComponent<Collider2D>();
        im = GetComponent<Image>();
        im.CrossFadeAlpha(0, 0f, true);
        for (int a = 0; a < k.Length; a++) {
           // k[a].CrossFadeAlpha(1, 0f, true);

            k[a].CrossFadeAlpha(0, 0f, true);//끝이누
        }

    }

    void light(float t = 1f, bool b = true) {

        im.CrossFadeAlpha(1, 0f, true);
        im.CrossFadeAlpha(0, t, true);
        for (int a = 0; a < k.Length; a++) {

            k[a].CrossFadeAlpha(1, 0f, true);
            k[a].CrossFadeAlpha(0, .5f, true);
        }
        if (b == true) {
            if (Application.loadedLevelName == "Coil_N") {
                for (int a = 2; a < k.Length; a++) {
                    k[a].text = "<";
                }
            }
            else if (Application.loadedLevelName == "Coil_S") {
                for (int a = 2; a < k.Length; a++) {
                    k[a].text = ">";
                }
            }

        }
        else {
            if (Application.loadedLevelName == "Coil_N") {
                for (int a = 2; a < k.Length; a++) {
                    k[a].text = ">";
                }
            } else if (Application.loadedLevelName == "Coil_S") {
                for (int a = 2; a < k.Length; a++) {
                        k[a].text = "<";
                }
            }
        }
    }



    void OnTriggerEnter2D(Collider2D collision) {
    light( 1f, false );
    }

    void OnTriggerExit2D(Collider2D collision) {
    light( 1f, true );
    }
}
