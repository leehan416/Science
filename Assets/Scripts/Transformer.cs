using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Transformer : MonoBehaviour {

    public static Transformer instance;

    public float n1, n2;
    public float n;

    public Text V2, I2;

    void Start() {
        if (!instance)
            instance = this;
        else
            DestroyImmediate(this);
    }

    public void Up() {
        Runnere.instance.Volt = 220f;
        Runnere.instance.Ampere = 3; // 혹시 모를 초기화
        Runnere.instance.Volt = n2/n1 * 220f;
        V2.text =Runnere.instance.Volt.ToString();
        Runnere.instance.Ampere = 660 / Runnere.instance.Volt;
        I2.text = Runnere.instance.Ampere.ToString();
    }
}