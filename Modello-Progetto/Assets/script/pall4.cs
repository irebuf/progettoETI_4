using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pall4 : MonoBehaviour
{
    public GameObject another;
    int i = 0;
    List<Vector3> Posi;
    Vector3 movimento;
    public void Pos()
    {
        // return altro.vet1();


    }
    // Start is called before the first frame update
    public void Start()
    {
        //Debug.Log("ciao");


    }

    // Update is called once per frame
    void Update()
    {

        JsonFile altro = another.GetComponent<JsonFile>();
        framerate fra = another.GetComponent<framerate>();
        int rate = fra.frame_rate;
        Posi = altro.vet4();
       //Debug.Log(Posi[1].x);
        //Posi = Pos();
        int n = Posi.Count;
        if (i % rate == 0)
        {
            movimento = Posi[i / 100];
            //Debug.Log("ciao");
            transform.position = movimento;
        }
        i++;
        if (i > n * rate) { i = 0; }
       // Debug.Log(i);
        // Debug.Log(n);


    }
}

