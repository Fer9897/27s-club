using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteGenerator : MonoBehaviour
{
    public float speed;
    public GameObject generador;

    public Transform Green;
    public Transform Blue;
    public Transform Red;

    public GameObject PrefGreen;
    public GameObject PrefBlue;
    public GameObject PrefRed;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        generador.transform.Translate(Vector3.forward * speed * Time.deltaTime);

        if(Input.GetKeyDown(KeyCode.A))
        {
            Instantiate(PrefGreen, Green.transform.position, Green.transform.rotation);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            Instantiate(PrefBlue, Blue.transform.position, Blue.transform.rotation);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            Instantiate(PrefRed, Red.transform.position, Red.transform.rotation);
        }
    }
}
