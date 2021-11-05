using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Galletas : MonoBehaviour
{

    public int NumDeGalletas;
    public TextMeshProUGUI textoMision;
    public GameObject BotonDeMision;
    // Start is called before the first frame update
    void Start()
    {
        NumDeGalletas = GameObject.FindGameObjectsWithTag("Galleta").Length;
        textoMision.text = "Obtén las Galletas" +
                             "\n Restantes: " + NumDeGalletas;
    }

   
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "Galleta")
        {
            Destroy(col.transform.parent.gameObject);
            NumDeGalletas--;
            textoMision.text = "Obtén las Galletas" +
                                "\n Restantes: " + NumDeGalletas;

            if (NumDeGalletas <= 0)
            {
                textoMision.text = "Completaste la Misión";
                BotonDeMision.SetActive(true);

            }
        }
    }
}
