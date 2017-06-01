using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagoDosNumeros : MonoBehaviour {
	int max;
	int min;
	int supor;

	// Use this for initialization
	void Start () {
		StartGame ();
	}

	void StartGame() {
		max = 2000;
		min = 1;
		supor = 1000;
		max = max + 1;

		print ("=============================");
		print ("Bem vindo ao mago dos numeros");
		print ("Pense em um numero");

		print ("O maior numero que voce pode pensar e " + max);
		print ("O menor numero que voce pode pensar e " + min);

		print ("Esse numero e maior ou menor que " + supor + "?");
		print ("Cima = maior, Baixo = menor, Enter = igual");
	}
		
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow)) {
			//print ("Seta de cima pressionada");
			min = supor;
			ProximoSupor();
		} else if (Input.GetKeyDown(KeyCode.DownArrow)) {
			//print ("Seta de baixo pressionada");
			max = supor;
			ProximoSupor();
		} else if (Input.GetKeyDown(KeyCode.Return)) {
			print ("O MAGO E IMPLACAVEL!");
			print ("Deseja tentar de novo?");
			if (Input.GetKey("escape")) {
				Application.Quit();
			} else {
				StartGame();
			}
		}
	}

	void ProximoSupor() {
		supor = (max + min) / 2;
		print ("Maior ou menor que " + supor + "?");
		print ("Cima = maior, Baixo = menor, Enter = igual");
	}
}
