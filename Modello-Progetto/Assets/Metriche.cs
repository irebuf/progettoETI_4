using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Metriche : MonoBehaviour
{
    public int range;
    public List<Frame> arancione, biancoGiusto;
    string pathArancione;
    string pathBianco;
    public int frameRate;
    int dimBoa, appoggio, percentuale;
    public float manoSx, manoDx, gomitoSx, gomitoDx, spallaSx, spallaDx;
    int frame_correnteArancione, frame_correnteBianco;
    bool attiva = false;
    public bool sogliaManoSx, sogliaManoDx, sogliaGomitoSx, sogliaGomitoDx, sogliaSpallaSx, sogliaSpallaDx;
    public float threshold;
    public Button play;
    public Button pausa;
    public Button framemin;
    public Text spallaR;
    public Text gomitoR;
    public Text polsoR;
    public Text spallaL;
    public Text gomitoL;
    public Text polsoL;
    public Text percentaleSvolto;

    void Start()
    {
        pathArancione = Application.dataPath + "/" + "ominoArancioneModello.json";
        pathBianco = Application.dataPath + "/" + "ominoBiancoGiusto.json";
        arancione = new List<Frame>();
        biancoGiusto = new List<Frame>();
        appoggio = 1;
        string contentArancione = System.IO.File.ReadAllText(pathArancione);
        string contentBianco = System.IO.File.ReadAllText(pathBianco);
        acquisisci_frame(contentArancione, ref arancione);
        acquisisci_frame(contentBianco, ref biancoGiusto);
        dimBoa = arancione.Count / 10;
        frameRate = 1;
        threshold = 0.1f;
        range = 100;
    }


    void Update()
    {
        if (attiva == true)
        {
            if (frame_correnteArancione % frameRate == 0)
            {
                //Debug.Log("arancio " + frame_correnteArancione + " bianco " + frame_correnteBianco);
                manoSx = calcola_distanza(new Vector3(arancione[frame_correnteArancione / frameRate].person_0.joint_4.x, arancione[frame_correnteArancione / frameRate].person_0.joint_4.y, arancione[frame_correnteArancione / frameRate].person_0.joint_4.z), new Vector3(biancoGiusto[frame_correnteBianco / frameRate].person_0.joint_4.x, biancoGiusto[frame_correnteBianco / frameRate].person_0.joint_4.y, biancoGiusto[frame_correnteBianco / frameRate].person_0.joint_4.z));
                manoDx = calcola_distanza(new Vector3(arancione[frame_correnteArancione / frameRate].person_0.joint_7.x, arancione[frame_correnteArancione / frameRate].person_0.joint_7.y, arancione[frame_correnteArancione / frameRate].person_0.joint_7.z), new Vector3(biancoGiusto[frame_correnteBianco / frameRate].person_0.joint_7.x, biancoGiusto[frame_correnteBianco / frameRate].person_0.joint_7.y, biancoGiusto[frame_correnteBianco / frameRate].person_0.joint_7.z));
                gomitoSx = calcola_distanza(new Vector3(arancione[frame_correnteArancione / frameRate].person_0.joint_3.x, arancione[frame_correnteArancione / frameRate].person_0.joint_3.y, arancione[frame_correnteArancione / frameRate].person_0.joint_3.z), new Vector3(biancoGiusto[frame_correnteBianco / frameRate].person_0.joint_3.x, biancoGiusto[frame_correnteBianco / frameRate].person_0.joint_3.y, biancoGiusto[frame_correnteBianco / frameRate].person_0.joint_3.z));
                gomitoDx = calcola_distanza(new Vector3(arancione[frame_correnteArancione / frameRate].person_0.joint_6.x, arancione[frame_correnteArancione / frameRate].person_0.joint_6.y, arancione[frame_correnteArancione / frameRate].person_0.joint_6.z), new Vector3(biancoGiusto[frame_correnteBianco / frameRate].person_0.joint_6.x, biancoGiusto[frame_correnteBianco / frameRate].person_0.joint_6.y, biancoGiusto[frame_correnteBianco / frameRate].person_0.joint_6.z));
                spallaSx = calcola_distanza(new Vector3(arancione[frame_correnteArancione / frameRate].person_0.joint_2.x, arancione[frame_correnteArancione / frameRate].person_0.joint_2.y, arancione[frame_correnteArancione / frameRate].person_0.joint_2.z), new Vector3(biancoGiusto[frame_correnteBianco / frameRate].person_0.joint_2.x, biancoGiusto[frame_correnteBianco / frameRate].person_0.joint_2.y, biancoGiusto[frame_correnteBianco / frameRate].person_0.joint_2.z));
                spallaDx = calcola_distanza(new Vector3(arancione[frame_correnteArancione / frameRate].person_0.joint_5.x, arancione[frame_correnteArancione / frameRate].person_0.joint_5.y, arancione[frame_correnteArancione / frameRate].person_0.joint_5.z), new Vector3(biancoGiusto[frame_correnteBianco / frameRate].person_0.joint_5.x, biancoGiusto[frame_correnteBianco / frameRate].person_0.joint_5.y, biancoGiusto[frame_correnteBianco / frameRate].person_0.joint_5.z));
                polsoL.text = manoSx.ToString();
                polsoR.text = manoDx.ToString();
                gomitoL.text = gomitoSx.ToString();
                gomitoR.text = gomitoDx.ToString();
                spallaL.text = spallaSx.ToString();
                spallaR.text = spallaDx.ToString();
            }
            if (frame_correnteBianco < biancoGiusto.Count - 1) frame_correnteBianco++;
            if (frame_correnteArancione < arancione.Count - 1) frame_correnteArancione++;
            if (frame_correnteBianco == biancoGiusto.Count - 1 && frame_correnteArancione == arancione.Count - 1) { ferma(); frame_correnteArancione = 0; frame_correnteBianco = 0; appoggio = 1; percentuale = 0; }

            if (manoSx < threshold) sogliaManoSx = true; else sogliaManoSx = false;
            if (manoDx < threshold) sogliaManoDx = true; else sogliaManoDx = false;
            if (gomitoSx < threshold) sogliaGomitoSx = true; else sogliaGomitoSx = false;
            if (gomitoDx < threshold) sogliaGomitoDx = true; else sogliaGomitoDx = false;
            if (spallaSx < threshold) sogliaSpallaSx = true; else sogliaSpallaSx = false;
            if (spallaDx < threshold) sogliaSpallaDx = true; else sogliaSpallaDx = false;

            //manca la percentuale
            if (frame_correnteArancione == dimBoa * appoggio)
            {
                if (appoggio <= 0 || appoggio > 10) appoggio = 1;

                //Debug.Log("percentuale: " + 10 * appoggio + "%");
                if (boa(dimBoa * appoggio) == true) percentuale += 10; else Debug.Log("al frame " + dimBoa * appoggio + " non è stata rispettata la boa");
                Debug.Log("numero Boa: " + appoggio + " percentuale: " + percentuale + "%");
                ++appoggio;
                percentaleSvolto.text = percentuale.ToString();
            }


        }



    }

    bool boa(int nFrame)
    {
        int i = 0;
        if (nFrame <= range / 2)//siamo a inizio esercizio
        {
            for (int j = 0; j < range * 2 / 3; ++j)
            {
                if (calcola_distanza(new Vector3(arancione[nFrame].person_0.joint_4.x, arancione[nFrame].person_0.joint_4.y, arancione[nFrame].person_0.joint_4.z), new Vector3(biancoGiusto[j].person_0.joint_4.x, biancoGiusto[j].person_0.joint_4.y, biancoGiusto[j].person_0.joint_4.z)) < threshold)
                {
                    i += 1;
                }
            }
        }
        else if (nFrame > arancione.Count - range / 2 - 1 && nFrame + range / 2 < biancoGiusto.Count - 1)//siamo a fine esercizio
        {
            for (int j = nFrame - range / 2; j < arancione.Count - 1; ++j)
            {
                if (calcola_distanza(new Vector3(arancione[nFrame].person_0.joint_4.x, arancione[nFrame].person_0.joint_4.y, arancione[nFrame].person_0.joint_4.z), new Vector3(biancoGiusto[j].person_0.joint_4.x, biancoGiusto[j].person_0.joint_4.y, biancoGiusto[j].person_0.joint_4.z)) < threshold)
                {
                    i += 1;
                }
            }
        }
        else if (nFrame > biancoGiusto.Count - range / 2)//il tipo sta facendo l'es troppo velocemente
        {
            for (int j = nFrame - range / 2; j < biancoGiusto.Count - 1; ++j)
            {
                if (calcola_distanza(new Vector3(arancione[nFrame].person_0.joint_4.x, arancione[nFrame].person_0.joint_4.y, arancione[nFrame].person_0.joint_4.z), new Vector3(biancoGiusto[j].person_0.joint_4.x, biancoGiusto[j].person_0.joint_4.y, biancoGiusto[j].person_0.joint_4.z)) < threshold)
                {
                    i += 1;
                }
            }
        }
        else if (nFrame > range / 2 || nFrame < arancione.Count - range / 2)//siamo nel vivo dell'esercizio
        {
            for (int j = nFrame - range / 2 + 1; j < nFrame + range / 2; ++j)
            {
                if (calcola_distanza(new Vector3(arancione[nFrame].person_0.joint_4.x, arancione[nFrame].person_0.joint_4.y, arancione[nFrame].person_0.joint_4.z), new Vector3(biancoGiusto[j].person_0.joint_4.x, biancoGiusto[j].person_0.joint_4.y, biancoGiusto[j].person_0.joint_4.z)) < threshold)
                {
                    i += 1;
                }
            }
        }

        if (i > 0)
        {
            return true;
        }
        else
        {
            return false;
        }

    }

    public void parti()
    {
        attiva = true;

        play.GetComponent<Button>().interactable = false;
        pausa.GetComponent<Button>().interactable = true;
        framemin.GetComponent<Button>().interactable = true;
    }
    public void ferma()
    {
        attiva = false;
        play.GetComponent<Button>().interactable = true;
        pausa.GetComponent<Button>().interactable = false;
    }
    public void framePlus()
    {
        attiva = false;
        play.GetComponent<Button>().interactable = true;
        pausa.GetComponent<Button>().interactable = false;
        framemin.GetComponent<Button>().interactable = true;

        if (frame_correnteArancione >= arancione.Count - 1) frame_correnteArancione = 0;
        if (frame_correnteBianco >= biancoGiusto.Count - 1) frame_correnteBianco = 0;

        manoSx = calcola_distanza(new Vector3(arancione[frame_correnteArancione].person_0.joint_4.x, arancione[frame_correnteArancione].person_0.joint_4.y, arancione[frame_correnteArancione].person_0.joint_4.z), new Vector3(biancoGiusto[frame_correnteBianco].person_0.joint_4.x, biancoGiusto[frame_correnteBianco].person_0.joint_4.y, biancoGiusto[frame_correnteBianco].person_0.joint_4.z));
        manoDx = calcola_distanza(new Vector3(arancione[frame_correnteArancione].person_0.joint_7.x, arancione[frame_correnteArancione].person_0.joint_7.y, arancione[frame_correnteArancione].person_0.joint_7.z), new Vector3(biancoGiusto[frame_correnteBianco].person_0.joint_7.x, biancoGiusto[frame_correnteBianco].person_0.joint_7.y, biancoGiusto[frame_correnteBianco].person_0.joint_7.z));
        gomitoSx = calcola_distanza(new Vector3(arancione[frame_correnteArancione].person_0.joint_3.x, arancione[frame_correnteArancione].person_0.joint_3.y, arancione[frame_correnteArancione].person_0.joint_3.z), new Vector3(biancoGiusto[frame_correnteBianco].person_0.joint_3.x, biancoGiusto[frame_correnteBianco].person_0.joint_3.y, biancoGiusto[frame_correnteBianco].person_0.joint_3.z));
        gomitoDx = calcola_distanza(new Vector3(arancione[frame_correnteArancione].person_0.joint_6.x, arancione[frame_correnteArancione].person_0.joint_6.y, arancione[frame_correnteArancione].person_0.joint_6.z), new Vector3(biancoGiusto[frame_correnteBianco].person_0.joint_6.x, biancoGiusto[frame_correnteBianco].person_0.joint_6.y, biancoGiusto[frame_correnteBianco].person_0.joint_6.z));
        spallaSx = calcola_distanza(new Vector3(arancione[frame_correnteArancione].person_0.joint_2.x, arancione[frame_correnteArancione].person_0.joint_2.y, arancione[frame_correnteArancione].person_0.joint_2.z), new Vector3(biancoGiusto[frame_correnteBianco].person_0.joint_2.x, biancoGiusto[frame_correnteBianco].person_0.joint_2.y, biancoGiusto[frame_correnteBianco].person_0.joint_2.z));
        spallaDx = calcola_distanza(new Vector3(arancione[frame_correnteArancione].person_0.joint_5.x, arancione[frame_correnteArancione].person_0.joint_5.y, arancione[frame_correnteArancione].person_0.joint_5.z), new Vector3(biancoGiusto[frame_correnteBianco].person_0.joint_5.x, biancoGiusto[frame_correnteBianco].person_0.joint_5.y, biancoGiusto[frame_correnteBianco].person_0.joint_5.z));
        polsoL.text = manoSx.ToString();
        polsoR.text = manoDx.ToString();
        gomitoL.text = gomitoSx.ToString();
        gomitoR.text = gomitoDx.ToString();
        spallaL.text = spallaSx.ToString();
        spallaR.text = spallaDx.ToString();

        if (manoSx < threshold) sogliaManoSx = true; else sogliaManoSx = false;
        if (manoDx < threshold) sogliaManoDx = true; else sogliaManoDx = false;
        if (gomitoSx < threshold) sogliaGomitoSx = true; else sogliaGomitoSx = false;
        if (gomitoDx < threshold) sogliaGomitoDx = true; else sogliaGomitoDx = false;
        if (spallaSx < threshold) sogliaSpallaSx = true; else sogliaSpallaSx = false;
        if (spallaDx < threshold) sogliaSpallaDx = true; else sogliaSpallaDx = false;

        if (frame_correnteArancione == dimBoa * appoggio)
        {
            if (appoggio <= 0 || appoggio > 10) appoggio = 1;

            //Debug.Log("percentuale: " + 10 * appoggio + "%");
            if (boa(dimBoa * appoggio) == true) percentuale += 10; else Debug.Log("al frame " + dimBoa * appoggio + " non è stata rispettata la boa");
            Debug.Log("numero Boa: " + appoggio + " percentuale: " + percentuale + "%");
            ++appoggio;
            percentaleSvolto.text = percentuale.ToString();
        }

        if (frame_correnteBianco < (biancoGiusto.Count - 1)) frame_correnteBianco++;
        if (frame_correnteArancione < (arancione.Count - 1)) frame_correnteArancione++;
        if (frame_correnteBianco == biancoGiusto.Count - 1 & frame_correnteArancione == arancione.Count - 1) { frame_correnteArancione++; frame_correnteBianco++; }
    }
    public void frameMinus()
    {
        if (frame_correnteBianco == 0 & frame_correnteArancione == 0)
        {

            return;
        }
        attiva = false;
        play.GetComponent<Button>().interactable = true;
        pausa.GetComponent<Button>().interactable = false;
        //if (frame_correnteBianco == 0 & frame_correnteArancione == 0) { frame_correnteBianco = biancoGiusto.Count; frame_correnteArancione = arancione.Count; }

        frame_correnteBianco--;
        frame_correnteArancione--;

        manoSx = calcola_distanza(new Vector3(arancione[frame_correnteArancione].person_0.joint_4.x, arancione[frame_correnteArancione].person_0.joint_4.y, arancione[frame_correnteArancione].person_0.joint_4.z), new Vector3(biancoGiusto[frame_correnteBianco].person_0.joint_4.x, biancoGiusto[frame_correnteBianco].person_0.joint_4.y, biancoGiusto[frame_correnteBianco].person_0.joint_4.z));
        manoDx = calcola_distanza(new Vector3(arancione[frame_correnteArancione].person_0.joint_7.x, arancione[frame_correnteArancione].person_0.joint_7.y, arancione[frame_correnteArancione].person_0.joint_7.z), new Vector3(biancoGiusto[frame_correnteBianco].person_0.joint_7.x, biancoGiusto[frame_correnteBianco].person_0.joint_7.y, biancoGiusto[frame_correnteBianco].person_0.joint_7.z));
        gomitoSx = calcola_distanza(new Vector3(arancione[frame_correnteArancione].person_0.joint_3.x, arancione[frame_correnteArancione].person_0.joint_3.y, arancione[frame_correnteArancione].person_0.joint_3.z), new Vector3(biancoGiusto[frame_correnteBianco].person_0.joint_3.x, biancoGiusto[frame_correnteBianco].person_0.joint_3.y, biancoGiusto[frame_correnteBianco].person_0.joint_3.z));
        gomitoDx = calcola_distanza(new Vector3(arancione[frame_correnteArancione].person_0.joint_6.x, arancione[frame_correnteArancione].person_0.joint_6.y, arancione[frame_correnteArancione].person_0.joint_6.z), new Vector3(biancoGiusto[frame_correnteBianco].person_0.joint_6.x, biancoGiusto[frame_correnteBianco].person_0.joint_6.y, biancoGiusto[frame_correnteBianco].person_0.joint_6.z));
        spallaSx = calcola_distanza(new Vector3(arancione[frame_correnteArancione].person_0.joint_2.x, arancione[frame_correnteArancione].person_0.joint_2.y, arancione[frame_correnteArancione].person_0.joint_2.z), new Vector3(biancoGiusto[frame_correnteBianco].person_0.joint_2.x, biancoGiusto[frame_correnteBianco].person_0.joint_2.y, biancoGiusto[frame_correnteBianco].person_0.joint_2.z));
        spallaDx = calcola_distanza(new Vector3(arancione[frame_correnteArancione].person_0.joint_5.x, arancione[frame_correnteArancione].person_0.joint_5.y, arancione[frame_correnteArancione].person_0.joint_5.z), new Vector3(biancoGiusto[frame_correnteBianco].person_0.joint_5.x, biancoGiusto[frame_correnteBianco].person_0.joint_5.y, biancoGiusto[frame_correnteBianco].person_0.joint_5.z));
        polsoL.text = manoSx.ToString();
        polsoR.text = manoDx.ToString();
        gomitoL.text = gomitoSx.ToString();
        gomitoR.text = gomitoDx.ToString();
        spallaL.text = spallaSx.ToString();
        spallaR.text = spallaDx.ToString();

        if (manoSx < threshold) sogliaManoSx = true; else sogliaManoSx = false;
        if (manoDx < threshold) sogliaManoDx = true; else sogliaManoDx = false;
        if (gomitoSx < threshold) sogliaGomitoSx = true; else sogliaGomitoSx = false;
        if (gomitoDx < threshold) sogliaGomitoDx = true; else sogliaGomitoDx = false;
        if (spallaSx < threshold) sogliaSpallaSx = true; else sogliaSpallaSx = false;
        if (spallaDx < threshold) sogliaSpallaDx = true; else sogliaSpallaDx = false;

        if (frame_correnteArancione == dimBoa * appoggio)
        {
            if (appoggio <= 0 || appoggio > 10) appoggio = 1;

            //Debug.Log("percentuale: " + 10 * appoggio + "%");
            if (boa(dimBoa * appoggio) == true) percentuale += 10; else Debug.Log("al frame " + dimBoa * appoggio + " non è stata rispettata la boa");
            Debug.Log("numero Boa: " + appoggio + " percentuale: " + percentuale + "%");
            ++appoggio;
            percentaleSvolto.text = percentuale.ToString();
        }

        if (frame_correnteBianco > 0) frame_correnteBianco--;
        if (frame_correnteArancione > 0) frame_correnteArancione--;
    }

    float calcola_distanza(Vector3 posArancione, Vector3 posBianco)
    {
        float distanza = 0;
        Vector3 delta_pos = new Vector3(posArancione.x - posBianco.x, posArancione.y - posBianco.y, posArancione.z - posBianco.z);

        distanza = Mathf.Sqrt(delta_pos.x * delta_pos.x + delta_pos.y * delta_pos.y + delta_pos.z * delta_pos.z);

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
