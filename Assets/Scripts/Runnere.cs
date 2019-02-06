using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Runnere : MonoBehaviour {

    public static Runnere instance;
    public Collider2D col;
    public float Volt = 220;
    public float Ampere = 1f;
    public int Watt;
    public float speed = 0f;
    void Start() {
        speed = 0f;
            
        if (!instance)
        {
            instance = this;
            col = this.GetComponent<Collider2D>();
        }
        else
            DestroyImmediate(this);     
    }

}
