using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slider : MonoBehaviour{


    public static Slider instance;
    void Start() {
        if (!instance)
            instance = this;
        else
            DestroyImmediate(this);
    }
    public void Speed(float a) {
        Runnere.instance.speed = a;
    }
}
