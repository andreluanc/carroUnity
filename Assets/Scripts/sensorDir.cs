using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sensorDir : MonoBehaviour {
    movimento script;
    // Start is called before the first frame update
    void Start () {
        script = transform.parent.GetComponent<movimento> ();
    }

    // Update is called once per frame
    void Update () {

    }
    // private void OnTriggerEnter2D (Collider2D other) {
    //     if (other.tag == "caminho") {
    //         script.rodandoDir = true;
    //         script.rodandoEsq = false;
    //     }
    // }

    private void OnTriggerStay2D (Collider2D other) {
        if (other.tag == "caminho") {
            // if (!script.rodandoEsq) {
                script.girarDir ();
                Debug.Log (other.tag);
            // }
        }
    }
    private void OnTriggerExit2D (Collider2D other) {
        if (other.tag == "caminho") {
            script.rodandoDir = false;
        }
    }
}