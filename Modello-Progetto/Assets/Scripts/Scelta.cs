using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scelta : MonoBehaviour
{
    public GameObject pannello_mano;
    public GameObject pannello_spalla;
    public GameObject pannello_gamba;
    public GameObject pannello_piede;
    public GameObject pannello_collo;
    public void Mano()
    {
        pannello_spalla.SetActive(false);
        pannello_gamba.SetActive(false);
        pannello_piede.SetActive(false);
        pannello_collo.SetActive(false);
        if (pannello_mano!=null)
        pannello_mano.SetActive(true);
        
    }
    public void Spalla()
    {
        pannello_mano.SetActive(false);
        pannello_gamba.SetActive(false);
        pannello_piede.SetActive(false);
        pannello_collo.SetActive(false);
        if (pannello_spalla != null)
            pannello_spalla.SetActive(true);
    }
    public void Gamba()
    {
        pannello_spalla.SetActive(false);
        pannello_mano.SetActive(false);
        pannello_piede.SetActive(false);
        pannello_collo.SetActive(false);
        if (pannello_gamba != null)
            pannello_gamba.SetActive(true);
    }
    public void Piede()
    {
        pannello_spalla.SetActive(false);
        pannello_gamba.SetActive(false);
        pannello_mano.SetActive(false);
        pannello_collo.SetActive(false);
        if (pannello_piede != null)
            pannello_piede.SetActive(true);
    }
    public void Collo()
    {
        pannello_spalla.SetActive(false);
        pannello_gamba.SetActive(false);
        pannello_piede.SetActive(false);
        pannello_mano.SetActive(false);
        if (pannello_collo != null)
            pannello_collo.SetActive(true);
    }
}
