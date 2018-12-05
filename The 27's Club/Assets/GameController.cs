using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

    public GameObject comenzar;
    public GameObject fondo1;
    public GameObject fondo2;
    public GameObject opciones;
    public GameObject c1;
    public GameObject c2;
    public GameObject c3;
    public GameObject c4;
    public GameObject c5;
    public GameObject c6;

    public void Comenzar()
    {
        comenzar.SetActive(false);
        fondo2.SetActive(true);
        fondo1.SetActive(false);
        opciones.SetActive(false);
        c1.SetActive(true);
        c2.SetActive(true);
        c3.SetActive(true);
        c4.SetActive(true);
        c5.SetActive(true);
        c6.SetActive(true);
    }


    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Cancion1()
    {
        SceneManager.LoadScene("Cancion1");
    }
}
