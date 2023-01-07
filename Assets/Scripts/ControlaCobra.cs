using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaCobra : MonoBehaviour {

    private Vector2 direcao;
    private bool emMovimento;
    [SerializeField] private float velocidadeMovimento;

    private void Update() {
        if (Input.GetButton("Horizontal") || Input.GetButton("Vertical")) {
            direcao = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
            emMovimento = true;
        } 
        emMovimento = false;
    }

   private void FixedUpdate() {
        if (emMovimento) {
            transform.Translate(direcao * velocidadeMovimento);
        }
        transform.Translate(Vector2.zero);
    }
}
