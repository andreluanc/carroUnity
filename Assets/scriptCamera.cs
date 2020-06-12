using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptCamera : MonoBehaviour {
    public Transform carro;

    public float smoothSpeed = 0.125f;
    public Vector3 offset;

    private void LateUpdate () {
        transform.position = carro.position + offset;
    }
}