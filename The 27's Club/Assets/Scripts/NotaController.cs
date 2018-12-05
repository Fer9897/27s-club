using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotaController : MonoBehaviour
{
    public KeyCode nota;
    RecepController notas;
    public GameObject pressNote;

    bool active = false;
    GameObject note;

    // Use this for initialization
    void Start ()
    {

	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(nota) && active)
        {
            Debug.Log("Presionaste");
            Destroy(note);
            RecepController.instance.notasAciertos++;
            active = false;
            RecepController.instance.vida = 5;
        }

        if(Input.GetKey(nota))
        {
            pressNote.SetActive(true);
        }
        else
        {
            pressNote.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Note")
        {
            active = true;
            note = other.gameObject;
            RecepController.instance.notasPasan++;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        active = false;
    }
}
