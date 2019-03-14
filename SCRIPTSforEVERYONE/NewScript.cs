using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewScript : MonoBehaviour
{
   
    public void EsercizioGiusto()
    {
        SceneManager.LoadScene("EsercizioGiusto");
    }

    public void EsercizioSbagliato()
    {
        SceneManager.LoadScene("EsercizioSbagliato");
    }

    public void HomePage()
    {
        SceneManager.LoadScene("HomePage");
    }
}
