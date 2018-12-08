using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Controle : MonoBehaviour {

    public float velocidadeJogo;
    public bool morto;

    float pontosTempo;
    int pontos;
    public Text txtPontos;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        pontosTempo += Time.deltaTime * 10;
        pontos = (int)pontosTempo;
        txtPontos.text = pontos.ToString();
    }

    public void RestartGame ()
    {
        SceneManager.LoadSceneAsync(0);
        Time.timeScale = 1;
    }
}
