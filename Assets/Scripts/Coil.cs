
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coil : MonoBehaviour {
    public GameObject magnet;

    //Max = 앞으로 가는 최대 거리
    //Min = 뒤로 가는 최대거리
    public float MaxD = 300f;
    public float MinD = 50f;
    public float d = 0;
    public Text t1, t2;
    public void Start() {
        StartCoroutine(Exercise());
    }
    public IEnumerator Exercise() {
        while (true) {
            if (Application.loadedLevelName == "Coil_N") { 
                t1.text = "N";
                t2.text = "S";
            } else { 
                t1.text = "S";
                t2.text = "N";
            }

            while ( d <= MaxD ) {


                magnet.transform.Translate(-Runnere.instance.speed, 0f, 0f, Space.World);
                d += Runnere.instance.speed;
                yield return null;
            }
            if (Application.loadedLevelName == "Coil_N") {
                t1.text = "S";
                t2.text = "N";
            }
            else {
                t1.text = "N";
                t2.text = "S";
            }

            while (d >= -MinD )
            {
               

                magnet.transform.Translate(Runnere.instance.speed, 0f, 0f, Space.World);
                d += -Runnere.instance.speed;
                yield return null;
            }
        }
    }
}

