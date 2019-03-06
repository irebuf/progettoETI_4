using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Metriche : MonoBehaviour
{

    public List<Frame> arancione, biancoGiusto;
    string pathArancione;
    string pathBianco;
    public int frameRate=1;
    int dimBoa;
    public float manoSx, manoDx, gomitoSx, gomitoDx, spallaSx, spallaDx;
    int frame_correnteArancione, frame_correnteBianco;
    bool attiva = false;

    void Start()
    {
        pathArancione = Application.dataPath + "/" + "ominoArancioneModello.json";
        pathBianco = Application.dataPath + "/" + "ominoBiancoGiusto.json";
        //tmp = gameObject.AddComponent<Jsonfilenew>() as Jsonfilenew;
        //mpt = gameObject.AddComponent<biancogiusto>() as biancogiusto;
        arancione = new List<Frame>();
        biancoGiusto = new List<Frame>();

        string contentArancione = System.IO.File.ReadAllText(pathArancione);
        string contentBianco = System.IO.File.ReadAllText(pathBianco);
        acquisisci_frame(contentArancione, ref arancione);
        acquisisci_frame(contentBianco, ref biancoGiusto);
        //Debug.Log("dim arancione : " + arancione.Count);
        //Debug.Log("dim biancoGiusto : " + biancoGiusto.Count);
        dimBoa = arancione.Count/10;

    }


    void Update()
    {
        if (attiva == true)
        {
            if (frame_correnteArancione > arancione.Count) frame_correnteArancione = 0;
            if (frame_correnteBianco > biancoGiusto.Count) frame_correnteBianco = 0;
            if (frame_correnteArancione % frameRate == 0)
            {
                manoSx = calcola_distanza(new Vector3(arancione[frame_correnteArancione].person_0.joint_4.x, arancione[frame_correnteArancione].person_0.joint_4.y, arancione[frame_correnteArancione].person_0.joint_4.z), new Vector3(biancoGiusto[frame_correnteBianco].person_0.joint_4.x, biancoGiusto[frame_correnteBianco].person_0.joint_4.y, biancoGiusto[frame_correnteBianco].person_0.joint_4.z));
                manoDx = calcola_distanza(new Vector3(arancione[frame_correnteArancione].person_0.joint_7.x, arancione[frame_correnteArancione].person_0.joint_7.y, arancione[frame_correnteArancione].person_0.joint_7.z), new Vector3(biancoGiusto[frame_correnteBianco].person_0.joint_7.x, biancoGiusto[frame_correnteBianco].person_0.joint_7.y, biancoGiusto[frame_correnteBianco].person_0.joint_7.z));
                gomitoSx = calcola_distanza(new Vector3(arancione[frame_correnteArancione].person_0.joint_3.x, arancione[frame_correnteArancione].person_0.joint_3.y, arancione[frame_correnteArancione].person_0.joint_3.z), new Vector3(biancoGiusto[frame_correnteBianco].person_0.joint_3.x, biancoGiusto[frame_correnteBianco].person_0.joint_3.y, biancoGiusto[frame_correnteBianco].person_0.joint_3.z));
                gomitoDx = calcola_distanza(new Vector3(arancione[frame_correnteArancione].person_0.joint_6.x, arancione[frame_correnteArancione].person_0.joint_6.y, arancione[frame_correnteArancione].person_0.joint_6.z), new Vector3(biancoGiusto[frame_correnteBianco].person_0.joint_6.x, biancoGiusto[frame_correnteBianco].person_0.joint_6.y, biancoGiusto[frame_correnteBianco].person_0.joint_6.z));
                spallaSx = calcola_distanza(new Vector3(arancione[frame_correnteArancione].person_0.joint_2.x, arancione[frame_correnteArancione].person_0.joint_2.y, arancione[frame_correnteArancione].person_0.joint_2.z), new Vector3(biancoGiusto[frame_correnteBianco].person_0.joint_2.x, biancoGiusto[frame_correnteBianco].person_0.joint_2.y, biancoGiusto[frame_correnteBianco].person_0.joint_2.z));
                spallaDx = calcola_distanza(new Vector3(arancione[frame_correnteArancione].person_0.joint_5.x, arancione[frame_correnteArancione].person_0.joint_5.y, arancione[frame_correnteArancione].person_0.joint_5.z), new Vector3(biancoGiusto[frame_correnteBianco].person_0.joint_5.x, biancoGiusto[frame_correnteBianco].person_0.joint_5.y, biancoGiusto[frame_correnteBianco].person_0.joint_5.z));

            }
            if (frame_correnteBianco < (biancoGiusto.Count - 1)) frame_correnteBianco++;
            if (frame_correnteArancione < (arancione.Count - 1)) frame_correnteArancione++;
            if (frame_correnteBianco == biancoGiusto.Count & frame_correnteArancione == arancione.Count) { frame_correnteArancione++; frame_correnteBianco++; }
        }



    }

    public void parti()
    {
        attiva = true;
    }
    public void ferma()
    {
        attiva = false;
    }
    public void framePlus()
    {
        attiva = false;

        if (frame_correnteArancione > arancione.Count) frame_correnteArancione = 0;
        if (frame_correnteBianco > biancoGiusto.Count) frame_correnteBianco = 0;
        if (frame_correnteArancione % frameRate == 0)
        {
            manoSx = calcola_distanza(new Vector3(arancione[frame_correnteArancione].person_0.joint_4.x, arancione[frame_correnteArancione].person_0.joint_4.y, arancione[frame_correnteArancione].person_0.joint_4.z), new Vector3(biancoGiusto[frame_correnteBianco].person_0.joint_4.x, biancoGiusto[frame_correnteBianco].person_0.joint_4.y, biancoGiusto[frame_correnteBianco].person_0.joint_4.z));
            manoDx = calcola_distanza(new Vector3(arancione[frame_correnteArancione].person_0.joint_7.x, arancione[frame_correnteArancione].person_0.joint_7.y, arancione[frame_correnteArancione].person_0.joint_7.z), new Vector3(biancoGiusto[frame_correnteBianco].person_0.joint_7.x, biancoGiusto[frame_correnteBianco].person_0.joint_7.y, biancoGiusto[frame_correnteBianco].person_0.joint_7.z));
            gomitoSx = calcola_distanza(new Vector3(arancione[frame_correnteArancione].person_0.joint_3.x, arancione[frame_correnteArancione].person_0.joint_3.y, arancione[frame_correnteArancione].person_0.joint_3.z), new Vector3(biancoGiusto[frame_correnteBianco].person_0.joint_3.x, biancoGiusto[frame_correnteBianco].person_0.joint_3.y, biancoGiusto[frame_correnteBianco].person_0.joint_3.z));
            gomitoDx = calcola_distanza(new Vector3(arancione[frame_correnteArancione].person_0.joint_6.x, arancione[frame_correnteArancione].person_0.joint_6.y, arancione[frame_correnteArancione].person_0.joint_6.z), new Vector3(biancoGiusto[frame_correnteBianco].person_0.joint_6.x, biancoGiusto[frame_correnteBianco].person_0.joint_6.y, biancoGiusto[frame_correnteBianco].person_0.joint_6.z));
            spallaSx = calcola_distanza(new Vector3(arancione[frame_correnteArancione].person_0.joint_2.x, arancione[frame_correnteArancione].person_0.joint_2.y, arancione[frame_correnteArancione].person_0.joint_2.z), new Vector3(biancoGiusto[frame_correnteBianco].person_0.joint_2.x, biancoGiusto[frame_correnteBianco].person_0.joint_2.y, biancoGiusto[frame_correnteBianco].person_0.joint_2.z));
            spallaDx = calcola_distanza(new Vector3(arancione[frame_correnteArancione].person_0.joint_5.x, arancione[frame_correnteArancione].person_0.joint_5.y, arancione[frame_correnteArancione].person_0.joint_5.z), new Vector3(biancoGiusto[frame_correnteBianco].person_0.joint_5.x, biancoGiusto[frame_correnteBianco].person_0.joint_5.y, biancoGiusto[frame_correnteBianco].person_0.joint_5.z));

        }
        if (frame_correnteBianco < (biancoGiusto.Count - 1)) frame_correnteBianco++;
        if (frame_correnteArancione < (arancione.Count - 1)) frame_correnteArancione++;
        if (frame_correnteBianco == biancoGiusto.Count & frame_correnteArancione == arancione.Count) { frame_correnteArancione++; frame_correnteBianco++; }
    }
    public void frameMinus()
    {
        attiva = false;

        if (frame_correnteArancione > arancione.Count) frame_correnteArancione = 0;
        if (frame_correnteBianco > biancoGiusto.Count) frame_correnteBianco = 0;
        if (frame_correnteArancione % frameRate == 0)
        {
            manoSx = calcola_distanza(new Vector3(arancione[frame_correnteArancione].person_0.joint_4.x, arancione[frame_correnteArancione].person_0.joint_4.y, arancione[frame_correnteArancione].person_0.joint_4.z), new Vector3(biancoGiusto[frame_correnteBianco].person_0.joint_4.x, biancoGiusto[frame_correnteBianco].person_0.joint_4.y, biancoGiusto[frame_correnteBianco].person_0.joint_4.z));
            manoDx = calcola_distanza(new Vector3(arancione[frame_correnteArancione].person_0.joint_7.x, arancione[frame_correnteArancione].person_0.joint_7.y, arancione[frame_correnteArancione].person_0.joint_7.z), new Vector3(biancoGiusto[frame_correnteBianco].person_0.joint_7.x, biancoGiusto[frame_correnteBianco].person_0.joint_7.y, biancoGiusto[frame_correnteBianco].person_0.joint_7.z));
            gomitoSx = calcola_distanza(new Vector3(arancione[frame_correnteArancione].person_0.joint_3.x, arancione[frame_correnteArancione].person_0.joint_3.y, arancione[frame_correnteArancione].person_0.joint_3.z), new Vector3(biancoGiusto[frame_correnteBianco].person_0.joint_3.x, biancoGiusto[frame_correnteBianco].person_0.joint_3.y, biancoGiusto[frame_correnteBianco].person_0.joint_3.z));
            gomitoDx = calcola_distanza(new Vector3(arancione[frame_correnteArancione].person_0.joint_6.x, arancione[frame_correnteArancione].person_0.joint_6.y, arancione[frame_correnteArancione].person_0.joint_6.z), new Vector3(biancoGiusto[frame_correnteBianco].person_0.joint_6.x, biancoGiusto[frame_correnteBianco].person_0.joint_6.y, biancoGiusto[frame_correnteBianco].person_0.joint_6.z));
            spallaSx = calcola_distanza(new Vector3(arancione[frame_correnteArancione].person_0.joint_2.x, arancione[frame_correnteArancione].person_0.joint_2.y, arancione[frame_correnteArancione].person_0.joint_2.z), new Vector3(biancoGiusto[frame_correnteBianco].person_0.joint_2.x, biancoGiusto[frame_correnteBianco].person_0.joint_2.y, biancoGiusto[frame_correnteBianco].person_0.joint_2.z));
            spallaDx = calcola_distanza(new Vector3(arancione[frame_correnteArancione].person_0.joint_5.x, arancione[frame_correnteArancione].person_0.joint_5.y, arancione[frame_correnteArancione].person_0.joint_5.z), new Vector3(biancoGiusto[frame_correnteBianco].person_0.joint_5.x, biancoGiusto[frame_correnteBianco].person_0.joint_5.y, biancoGiusto[frame_correnteBianco].person_0.joint_5.z));

        }
        if (frame_correnteBianco < (biancoGiusto.Count - 1)) frame_correnteBianco--;
        if (frame_correnteArancione < (arancione.Count - 1)) frame_correnteArancione--;
        if (frame_correnteBianco == biancoGiusto.Count & frame_correnteArancione == arancione.Count) { frame_correnteArancione++; frame_correnteBianco++; }
    }

    float calcola_distanza(Vector3 posArancione, Vector3 posBianco)
    {
        float distanza = 0;
        Vector3 delta_pos = new Vector3(posArancione.x-posBianco.x, posArancione.y-posBianco.y, posArancione.z-posBianco.z);

        distanza = Mathf.Sqrt(delta_pos.x*delta_pos.x + delta_pos.y*delta_pos.y + delta_pos.z*delta_pos.z);

        return distanza;
    }



    void acquisisci_frame(string contents, ref List<Frame> lista)
    {
        int i = 0;
        int pos = 0;
        int el = 0;
        do
        {
            int ini = contents.IndexOf("frame", pos);
            int dif = contents.IndexOf('"', ini) - ini;
            contents = contents.Remove(ini, dif);
            contents = contents.Insert(ini, "frame_primo");

            FrameWrap wrapper = JsonUtility.FromJson<FrameWrap>(contents);

            lista.Add(wrapper.frame_primo);
            i++;
            el = contents.IndexOf("frame", ini + 100);
            contents = contents.Remove(contents.IndexOf('{', 0) + 1, el - (contents.IndexOf('{', 0) + 2));
        } while (contents.IndexOf("frame", 100) > 0);
    }

}
