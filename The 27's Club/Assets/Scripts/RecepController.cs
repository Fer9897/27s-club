using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecepController : MonoBehaviour
{
    //Singleton
    public static RecepController instance;
    private void Awake()
    {
        if (RecepController.instance == null)
        {
            RecepController.instance = this;
        }
        else if (RecepController.instance != this)
        {
            Destroy(gameObject);
        }
    }

    public int notasPasan;
    public int notasAciertos;
    public int notasMiss;

    public float puntaje;
    public Text score;

    public int vida = 5;


	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        puntaje = notasAciertos * 12.0f;
        score.text = puntaje.ToString("" + puntaje);
	}
}
