using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimento : MonoBehaviour {
    public bool rodandoEsq = false;
    public bool rodandoDir = false;
    public float velocidade = 5f;
    public float grauRotacao = 45f;


    Rigidbody2D rb;
    void Start () {
        rb = GetComponent<Rigidbody2D> ();
    }


    void Update () {

    }
    private void FixedUpdate () {

    }

    public void moverFrente () {
        transform.position += transform.up * Time.deltaTime * velocidade;
    }

    public void girarEsq () {
        transform.Rotate (0, 0, grauRotacao);
    }
    public void girarDir () {
        transform.Rotate (0, 0, -grauRotacao);
    }
}