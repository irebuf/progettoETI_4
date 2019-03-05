using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewScript : MonoBehaviour
{
    public void EsercizioGiusto()
    {
        Application.LoadLevel("EsercizioGiusto");
    }

    public void EsercizioSbagliato()
    {
        Application.LoadLevel("EsercizioSbagliato");
    }

    public void HomePage()
    {
        Application.LoadLevel("HomePage");
    }
}
