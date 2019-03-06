using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Metriche : MonoBehaviour
{
    //Jsonfilenew ominoArancione;
    //biancogiusto ominoBiancoGiusto;
    List<Frame> arancione, biancoGiusto;
    GameObject tmpArancione, tmpBianco;
    bool appoggio = true;

    private void Awake()
    {
        arancione = new List<Frame>();
        biancoGiusto = new List<Frame>();
        tmpBianco = new GameObject();
        tmpArancione = new GameObject();

    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (appoggio == true)
        {
            Jsonfilenew ominoArancioneTMP = tmpArancione.GetComponent<Jsonfilenew>();
            biancogiusto ominoBiancoGiustoTMP = tmpBianco.GetComponent<biancogiusto>();

            arancione = ominoArancioneTMP.frames;
            biancoGiusto = ominoBiancoGiustoTMP.frames;
            appoggio = false;
            Debug.Log(arancione.Count);
            Debug.Log(biancoGiusto.Count);
        }




        /*for (int i=0; i<50; ++i)
        {
            Debug.Log(arancione[i*2].person_0.joint_4.x);
        }*/

    }
}
