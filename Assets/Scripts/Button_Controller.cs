using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class Button_Controller : MonoBehaviour {
    public InputField n1;
    public InputField n2;


    public void Apply_Button () {
        Transformer.instance.n1 = Convert.ToInt32(n1.text);
        Transformer.instance.n2 = Convert.ToInt32(n2.text);
        Transformer.instance.Up();
    }




    public void Transformer_Button() {
        SceneManager.LoadScene("Transformer");
    }
    public void Electromagnetic_induction_Button() {
        SceneManager.LoadScene("Coil_S");
    }
    public void exit_Button() {
        SceneManager.LoadScene("Main");
    }
    public void Change_Button() {
        if (Application.loadedLevelName == "Coil_N") {
            SceneManager.LoadScene("Coil_S");
        } else if (Application.loadedLevelName == "Coil_S") {
            SceneManager.LoadScene("Coil_N");
        }
    }
}
