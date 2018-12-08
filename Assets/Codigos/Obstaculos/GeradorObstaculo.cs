using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorObstaculo : MonoBehaviour {

    public List<GameObject> listaDeObstaculos;
    private GameObject obstaculo;
    private float tempo;
    private float contadorTempo;

    public bool nuvem;

    

    private Controle ctl;

    // Use this for initialization
    void Start() {
        ctl = FindObjectOfType<Controle>();
        if (!nuvem)
        {
            tempo = ctl.velocidadeJogo / 400;
            if (tempo < 2.5f)
                tempo = 2.5f;
        }
        else { 
            tempo = ctl.velocidadeJogo / 150;
        }
        

	}
	
	// Update is called once per frame
	void Update () {
       

        contadorTempo -= Time.deltaTime;
		if (contadorTempo <= 0)
        {
            int num = Random.Range(0, listaDeObstaculos.Count);
            obstaculo = listaDeObstaculos[num];
            Instantiate(obstaculo, transform.position, transform.rotation);
            contadorTempo = Random.Range(tempo - 1.3f, tempo + 1.3f);
        }
	}
}
