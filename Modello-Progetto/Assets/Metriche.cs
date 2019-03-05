using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Metriche : MonoBehaviour
{
    Jsonfilenew ominoArancione;
    biancogiusto ominoBiancoGiusto;
    List<Frame> arancione, biancoGiusto;


    private void Awake()
    {
        arancione = ominoArancione.frames;
        biancoGiusto = ominoBiancoGiusto.frames;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
