using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cil1 : MonoBehaviour
{
    public GameObject a;
    public GameObject b;
    Vector3 start, end;
    Vector3 var;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //posizionamento
        start = a.transform.position;
        end = b.transform.position;
        transform.position = (end - start) / 2 + start;
        //scala
        var = transform.localScale;
        var.x=0.1f;
        var.z = (float)0.1;
        var.y = (end - start).magnitude / 2;
        /*var.x *= ((float)0.1);
        var.y *= ((float)0.1);
        var.z *= ((float)0.1);*/
        transform.localScale = var;
        //rotazione
        transform.rotation = Quaternion.FromToRotation(Vector3.up, end - start);

    }

}
