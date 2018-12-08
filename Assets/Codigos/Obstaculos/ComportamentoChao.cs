using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComportamentoChao : MonoBehaviour {

    private float velocidade;
    [SerializeField]
    private Rigidbody2D rb;

    private Controle ctl;

	// Use this for initialization
	void Start () {
        ctl = FindObjectOfType<Controle>();
        velocidade = ctl.velocidadeJogo;
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 direcao = new Vector2(-velocidade * Time.deltaTime, 0);
        rb.velocity = direcao;

        if (transform.position.x < -22f)
        {
            transform.position = new Vector2 (22f, transform.position.y);
        }
	}
}
