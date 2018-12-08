using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinoMovimento : MonoBehaviour {

    public Rigidbody2D rb;
    public float jump;
    public BoxCollider2D abaixado;
    public bool abaixadoBool;

    private Animator anim;
    private Controle ctl;
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        ctl = FindObjectOfType<Controle>();
	}
	
	// Update is called once per frame
	void Update () {

        anim.SetBool("Abaixado", abaixadoBool);
        abaixado.enabled = !abaixadoBool;

        if(Input.GetKeyDown(KeyCode.Space) && ctl.morto)
        {
            ctl.RestartGame();
        }

        if (Input.GetKeyDown(KeyCode.Space) && transform.position.y < -1f)
        {
            rb.AddForce(new Vector2(0, jump));
        }
        if (Input.GetKey(KeyCode.DownArrow) && rb.velocity.y == 0)
        {
            abaixadoBool = true;
        } else
        {
            abaixadoBool = false;
        }
	}
}
