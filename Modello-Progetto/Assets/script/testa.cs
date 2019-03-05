using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testa : MonoBehaviour
{
    public GameObject anotther;
    int i = 0;
    List<Vector3> Posi;
    List<Vector3> Posi2;
    List<Vector3> Posi3;
    Vector3 movimento;
    Vector3 var;
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

        JsonFile altro = anotther.GetComponent<JsonFile>();
        framerate fra = anotther.GetComponent<framerate>();
        int rate = fra.frame_rate;
        Posi = altro.vet16();
        Posi2 = altro.vet17();
        int n = Posi.Count;
        /*for (int i = 0; i < n; i++)
        {
           // Posi3[i] = ((Posi[i] + Posi2[i]) / 2);
        }*/

        //Debug.Log(Posi[1].x);
        //Posi = Pos();
        var = transform.localScale;
        var.x = 0.3f;
        var.z = 0.3f;
        var.y = 0.3f;
        /*var.x *= ((float)0.1);
        var.y *= ((float)0.1);
        var.z *= ((float)0.1);*/
        transform.localScale = var;
        if (i % rate == 0)
        {
            movimento = ((Posi[i] + Posi2[i]) / 2);
            //Debug.Log("ciao");
            transform.position = movimento;
        }
        i++;
        if (i > n * rate) { i = 0; }
        //Debug.Log(i);
        // Debug.Log(n);


    }
}

