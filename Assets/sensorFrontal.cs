using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sensorFrontal : MonoBehaviour {
    movimento script;
    // Start is called before the first frame update
    void Start () {
        script = transform.parent.GetComponent<movimento> ();
    }

    // Update is called once per frame
    void Update () {

    }

    private void OnTriggerStay2D (Collider2D other) {
        script.moverFrente ();
    }

}