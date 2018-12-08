using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverObstaculo : MonoBehaviour {
    [SerializeField]
    private Rigidbody2D rb;
    public float velocidade;

    private Controle ctl;

	// Use this for initialization
	void Start () {
        Destroy(gameObject, 11);
        ctl = FindObjectOfType<Controle>();
        velocidade = ctl.velocidadeJogo;
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 direcao = new Vector2(-velocidade * Time.deltaTime, 0);
        rb.velocity = direcao;

    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.GetComponent<DinoMovimento>() != null)
        {
            GameObject dino = col.gameObject.GetComponent<DinoMovimento>().gameObject;
            dino.GetComponent<Animator>().SetTrigger("Dead");
            Time.timeScale = 0;
            ctl.morto = true;
        }
    }
}
