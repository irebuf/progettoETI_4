using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Metriche : MonoBehaviour
{

    public List<Frame> arancione, biancoGiusto;
    bool appoggio = true;
    Jsonfilenew tmp;
    biancogiusto mpt;

    private void Awake()
    {


    }
    // Start is called before the first frame update
    void Start()
    {
        tmp = gameObject.AddComponent<Jsonfilenew>() as Jsonfilenew;
        mpt = gameObject.AddComponent<biancogiusto>() as biancogiusto;
        arancione = new List<Frame>();
        biancoGiusto = new List<Frame>();

    }
    int intt=0;
    // Update is called once per frame
    void Update()
    {
        if(intt<120)intt++;
        if (intt==100 && appoggio == true)
        {
            arancione = tmp.frames;
            biancoGiusto = mpt.frames;
            Debug.Log("dim lista arancione: " + arancione.Count);
            Debug.Log("dim lista bianca: " + biancoGiusto.Count);
            appoggio = false;
        }





    }








}
