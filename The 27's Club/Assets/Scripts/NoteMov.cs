using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteMov : MonoBehaviour
{
    public float speed;

    public GameObject[] notas;

	// Use this for initialization
	void Start ()
    {
        
    }
	
	// Update is called once per frame
	void Update ()
    {
        notas = GameObject.FindGameObjectsWithTag("Note");

        for (int i = 0; i < notas.Length; i++)
        {
            notas[i].transform.Translate(Vector3.back * speed * Time.deltaTime);

            if(notas[i].transform.position.z < -2.0f)
            {
                Destroy(notas[i]);                
                RecepController.instance.notasMiss++;

                if(RecepController.instance.vida > 0)
                {
                    RecepController.instance.vida--;
                }
            }
        }

        if(RecepController.instance.vida == 0)
        {
            Debug.Log("Perdiste");
        }
    }
}
