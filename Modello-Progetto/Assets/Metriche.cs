using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Metriche : MonoBehaviour
{

    public List<Frame> arancione, biancoGiusto;
    string pathArancione;
    string pathBianco;
    public int frameRate;
    int dimBoa;
    public float manoSx, manoDx, gomitoSx, gomitoDx, spallaSx, spallaDx;
    int frame_corrente;
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
        manoSx = calcola_distanza(new Vector3(arancione[frame_corrente].person_0.joint_4.x, arancione[frame_corrente].person_0.joint_4.y, arancione[frame_corrente].person_0.joint_4.z) ,new Vector3(biancoGiusto[frame_corrente].person_0.joint_4.x, biancoGiusto[frame_corrente].person_0.joint_4.y, biancoGiusto[frame_corrente].person_0.joint_4.z) );








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
