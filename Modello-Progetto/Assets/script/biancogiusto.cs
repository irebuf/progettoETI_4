﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class biancogiusto : MonoBehaviour
{
    int q = 0;

    Vector3 movimento1;
    Vector3 movimento2;
    Vector3 movimento3;
    Vector3 movimento4;
    Vector3 movimento5;
    Vector3 movimento6;
    Vector3 movimento7;
    Vector3 movimento8;
    Vector3 movimento9;
    Vector3 movimento10;
    Vector3 movimento11;
    Vector3 movimento12;
    Vector3 movimento13;
    Vector3 movimentotesta;

    public int frame_rate;
    public GameObject pallina1;
    public GameObject pallina2;
    public GameObject pallina3;
    public GameObject pallina4;
    public GameObject pallina5;
    public GameObject pallina6;
    public GameObject pallina7;
    public GameObject pallina8;
    public GameObject pallina9;
    public GameObject pallina10;
    public GameObject pallina11;
    public GameObject pallina12;
    public GameObject pallina13;
    public GameObject testa;
    public GameObject cilindro12;
    public GameObject cilindro23;
    public GameObject cilindro34;
    public GameObject cilindro51;
    public GameObject cilindro65;
    public GameObject cilindro67;
    public GameObject cilindro8_11;
    public GameObject cilindro1_8;
    public GameObject cilindro1_11;
    public GameObject cilindro9_8;
    public GameObject cilindro9_10;
    public GameObject cilindro11_12;
    public GameObject cilindro12_13;




    string pathss;
    List<Frame> frames = new List<Frame>();


    Persona person_0 = new Persona();
    Joint joint = new Joint();
    List<Vector3> vettori1 = new List<Vector3>();
    List<Vector3> vettori2 = new List<Vector3>();
    List<Vector3> vettori3 = new List<Vector3>();
    List<Vector3> vettori4 = new List<Vector3>();
    List<Vector3> vettori5 = new List<Vector3>();
    List<Vector3> vettori6 = new List<Vector3>();
    List<Vector3> vettori7 = new List<Vector3>();
    List<Vector3> vettori8 = new List<Vector3>();
    List<Vector3> vettori9 = new List<Vector3>();
    List<Vector3> vettori10 = new List<Vector3>();
    List<Vector3> vettori11 = new List<Vector3>();
    List<Vector3> vettori12 = new List<Vector3>();
    List<Vector3> vettori13 = new List<Vector3>();
    List<Vector3> vettori16 = new List<Vector3>();
    List<Vector3> vettori17 = new List<Vector3>();

    public void tornavettori()
    {
        int n_ele = frames.Count;



        for (int k = 0; k < n_ele; k++)
        {
            Vector3 a1 = new Vector3(frames[k].person_0.joint_1.x, frames[k].person_0.joint_1.y, frames[k].person_0.joint_1.z);
            Vector3 a2 = new Vector3(frames[k].person_0.joint_2.x, frames[k].person_0.joint_2.y, frames[k].person_0.joint_2.z);
            Vector3 a3 = new Vector3(frames[k].person_0.joint_3.x, frames[k].person_0.joint_3.y, frames[k].person_0.joint_3.z);
            Vector3 a4 = new Vector3(frames[k].person_0.joint_4.x, frames[k].person_0.joint_4.y, frames[k].person_0.joint_4.z);
            Vector3 a5 = new Vector3(frames[k].person_0.joint_5.x, frames[k].person_0.joint_5.y, frames[k].person_0.joint_5.z);
            Vector3 a6 = new Vector3(frames[k].person_0.joint_6.x, frames[k].person_0.joint_6.y, frames[k].person_0.joint_6.z);
            Vector3 a7 = new Vector3(frames[k].person_0.joint_7.x, frames[k].person_0.joint_7.y, frames[k].person_0.joint_7.z);
            Vector3 a8 = new Vector3(frames[k].person_0.joint_8.x, frames[k].person_0.joint_8.y, frames[k].person_0.joint_8.z);
            Vector3 a9 = new Vector3(frames[k].person_0.joint_9.x, frames[k].person_0.joint_9.y, frames[k].person_0.joint_9.z);
            Vector3 a10 = new Vector3(frames[k].person_0.joint_10.x, frames[k].person_0.joint_10.y, frames[k].person_0.joint_10.z);
            Vector3 a11 = new Vector3(frames[k].person_0.joint_11.x, frames[k].person_0.joint_11.y, frames[k].person_0.joint_11.z);
            Vector3 a12 = new Vector3(frames[k].person_0.joint_12.x, frames[k].person_0.joint_12.y, frames[k].person_0.joint_12.z);
            Vector3 a13 = new Vector3(frames[k].person_0.joint_13.x, frames[k].person_0.joint_13.y, frames[k].person_0.joint_13.z);
            Vector3 a16 = new Vector3(frames[k].person_0.joint_16.x, frames[k].person_0.joint_16.y, frames[k].person_0.joint_16.z);
            Vector3 a17 = new Vector3(frames[k].person_0.joint_17.x, frames[k].person_0.joint_17.y, frames[k].person_0.joint_17.z);

            vettori1.Add(a1);
            vettori2.Add(a2);
            vettori3.Add(a3);
            vettori4.Add(a4);
            vettori5.Add(a5);
            vettori6.Add(a6);
            vettori7.Add(a7);
            vettori8.Add(a8);
            vettori9.Add(a9);
            vettori10.Add(a10);
            vettori11.Add(a11);
            vettori12.Add(a12);
            vettori13.Add(a13);
            vettori16.Add(a16);
            vettori17.Add(a17);

        }

    }



    public List<Frame> get_data()
    {

        return frames;
    }
    public List<Vector3> vet1()
    {
        tornavettori();
        return vettori1;
    }
    public List<Vector3> vet2()
    {
        tornavettori();
        return vettori2;
    }
    public List<Vector3> vet3()
    {
        tornavettori();
        return vettori3;
    }
    public List<Vector3> vet4()
    {
        tornavettori();
        return vettori4;
    }
    public List<Vector3> vet5()
    {
        tornavettori();
        return vettori5;
    }
    public List<Vector3> vet6()
    {
        tornavettori();
        return vettori6;
    }
    public List<Vector3> vet7()
    {
        tornavettori();
        return vettori7;
    }
    public List<Vector3> vet8()
    {
        tornavettori();
        return vettori8;
    }
    public List<Vector3> vet9()
    {
        tornavettori();
        return vettori9;
    }
    public List<Vector3> vet10()
    {
        tornavettori();
        return vettori10;
    }
    public List<Vector3> vet11()
    {
        tornavettori();
        return vettori11;
    }
    public List<Vector3> vet12()
    {
        tornavettori();
        return vettori12;
    }
    public List<Vector3> vet13()
    {
        tornavettori();
        return vettori13;
    }
    public List<Vector3> vet16()
    {
        tornavettori();
        return vettori16;
    }
    public List<Vector3> vet17()
    {
        tornavettori();
        return vettori17;
    }
    ////////////////// Start is called before the first frame update
    void Start()
    {

        pathss = Application.dataPath + "/" + "ominoBiancoGiusto.json";
        string contents = System.IO.File.ReadAllText(pathss);
        acquisisci_frame(contents);


    }
    bool attiva = false;
    public Button play;
    public Button pausa;

    public void Parti()
    {
        attiva = true;
        play.GetComponent<Button>().interactable = false;
        pausa.GetComponent<Button>().interactable = true;
    }
    public void Ferma()
    {
        attiva = false;
        play.GetComponent<Button>().interactable = true;
        pausa.GetComponent<Button>().interactable = false;
    }
    public void FramePlus()
    {
        attiva = false;
        int n = vet1().Count;
        if (q % frame_rate == 0)
        {
            movimento1 = vet1()[q / frame_rate];
            movimento2 = vet2()[q / frame_rate];
            movimento3 = vet3()[q / frame_rate];
            movimento4 = vet4()[q / frame_rate];
            movimento5 = vet5()[q / frame_rate];
            movimento6 = vet6()[q / frame_rate];
            movimento7 = vet7()[q / frame_rate];
            movimento8 = vet8()[q / frame_rate];
            movimento9 = vet9()[q / frame_rate];
            movimento10 = vet10()[q / frame_rate];
            movimento11 = vet11()[q / frame_rate];
            movimento12 = vet12()[q / frame_rate];
            movimento13 = vet13()[q / frame_rate];
            movimentotesta = ((vet16()[q / frame_rate] + vet17()[q / frame_rate]) / 2);
            testa.transform.position = movimentotesta;


            pallina1.transform.position = movimento1;
            pallina2.transform.position = movimento2;
            pallina3.transform.position = movimento3;
            pallina4.transform.position = movimento4;
            pallina5.transform.position = movimento5;
            pallina6.transform.position = movimento6;
            pallina7.transform.position = movimento7;
            pallina8.transform.position = movimento8;
            pallina9.transform.position = movimento9;
            pallina10.transform.position = movimento10;
            pallina11.transform.position = movimento11;
            pallina12.transform.position = movimento12;
            pallina13.transform.position = movimento13;

        }
        q++;
        if (q > n * frame_rate) { q = 0; }

    }

    public void FrameMinus()
    {
        attiva = false;
        int n = vet1().Count;
        if (q % frame_rate == 0)
        {
            movimento1 = vet1()[q / frame_rate];
            movimento2 = vet2()[q / frame_rate];
            movimento3 = vet3()[q / frame_rate];
            movimento4 = vet4()[q / frame_rate];
            movimento5 = vet5()[q / frame_rate];
            movimento6 = vet6()[q / frame_rate];
            movimento7 = vet7()[q / frame_rate];
            movimento8 = vet8()[q / frame_rate];
            movimento9 = vet9()[q / frame_rate];
            movimento10 = vet10()[q / frame_rate];
            movimento11 = vet11()[q / frame_rate];
            movimento12 = vet12()[q / frame_rate];
            movimento13 = vet13()[q / frame_rate];
            movimentotesta = ((vet16()[q / frame_rate] + vet17()[q / frame_rate]) / 2);
            testa.transform.position = movimentotesta;


            pallina1.transform.position = movimento1;
            pallina2.transform.position = movimento2;
            pallina3.transform.position = movimento3;
            pallina4.transform.position = movimento4;
            pallina5.transform.position = movimento5;
            pallina6.transform.position = movimento6;
            pallina7.transform.position = movimento7;
            pallina8.transform.position = movimento8;
            pallina9.transform.position = movimento9;
            pallina10.transform.position = movimento10;
            pallina11.transform.position = movimento11;
            pallina12.transform.position = movimento12;
            pallina13.transform.position = movimento13;

        }
        q--;
        if (q > n * frame_rate) { q = 0; }

    }

   
    ////////////////// Update is called once per frame
    void Update()
    {
        if (attiva == true)
        {
            int n = vet1().Count;
            if (q % frame_rate == 0)
            {
                movimento1 = vet1()[q / frame_rate];
                movimento2 = vet2()[q / frame_rate];
                movimento3 = vet3()[q / frame_rate];
                movimento4 = vet4()[q / frame_rate];
                movimento5 = vet5()[q / frame_rate];
                movimento6 = vet6()[q / frame_rate];
                movimento7 = vet7()[q / frame_rate];
                movimento8 = vet8()[q / frame_rate];
                movimento9 = vet9()[q / frame_rate];
                movimento10 = vet10()[q / frame_rate];
                movimento11 = vet11()[q / frame_rate];
                movimento12 = vet12()[q / frame_rate];
                movimento13 = vet13()[q / frame_rate];
                movimentotesta = ((vet16()[q / frame_rate] + vet17()[q / frame_rate]) / 2);
                testa.transform.position = movimentotesta;

                pallina1.transform.position = movimento1;
                pallina2.transform.position = movimento2;
                pallina3.transform.position = movimento3;
                pallina4.transform.position = movimento4;
                pallina5.transform.position = movimento5;
                pallina6.transform.position = movimento6;
                pallina7.transform.position = movimento7;
                pallina8.transform.position = movimento8;
                pallina9.transform.position = movimento9;
                pallina10.transform.position = movimento10;
                pallina11.transform.position = movimento11;
                pallina12.transform.position = movimento12;
                pallina13.transform.position = movimento13;
            }
            q++;
            if (q > n * frame_rate) { q = 0; }
            coloramateriale();
            
        }
    }
    void coloramateriale()
    {

        if (Input.GetKeyDown(KeyCode.R))
        {
            pallina1.GetComponent<Renderer>().material.color = new Color(0, 1, 0, 1);
            pallina2.GetComponent<Renderer>().material.color = new Color(0, 1, 0, 1);
            pallina3.GetComponent<Renderer>().material.color = new Color(0, 1, 0, 1);
            pallina4.GetComponent<Renderer>().material.color = new Color(0, 1, 0, 1);
            pallina5.GetComponent<Renderer>().material.color = new Color(0, 1, 0, 1);
            pallina6.GetComponent<Renderer>().material.color = new Color(0, 1, 0, 1);
            pallina7.GetComponent<Renderer>().material.color = new Color(0, 1, 0, 1);
            pallina8.GetComponent<Renderer>().material.color = new Color(0, 1, 0, 1);
            pallina9.GetComponent<Renderer>().material.color = new Color(0, 1, 0, 1);
            pallina10.GetComponent<Renderer>().material.color = new Color(0, 1, 0, 1);
            pallina11.GetComponent<Renderer>().material.color = new Color(0, 1, 0, 1);
            pallina12.GetComponent<Renderer>().material.color = new Color(0, 1, 0, 1);
            pallina13.GetComponent<Renderer>().material.color = new Color(0, 1, 0, 1);
            testa.GetComponent<Renderer>().material.color = new Color(0, 1, 0, 1);
            cilindro12.GetComponent<Renderer>().material.color = new Color(0, 1, 0, 1);
            cilindro23.GetComponent<Renderer>().material.color = new Color(0, 1, 0, 1);
            cilindro34.GetComponent<Renderer>().material.color = new Color(0, 1, 0, 1);
            cilindro51.GetComponent<Renderer>().material.color = new Color(0, 1, 0, 1);
            cilindro65.GetComponent<Renderer>().material.color = new Color(0, 1, 0, 1);
            cilindro67.GetComponent<Renderer>().material.color = new Color(0, 1, 0, 1);
            cilindro8_11.GetComponent<Renderer>().material.color = new Color(0, 1, 0, 1);
            cilindro1_8.GetComponent<Renderer>().material.color = new Color(0, 1, 0, 1);
            cilindro1_11.GetComponent<Renderer>().material.color = new Color(0, 1, 0, 1);
            cilindro9_8.GetComponent<Renderer>().material.color = new Color(0, 1, 0, 1);
            cilindro9_10.GetComponent<Renderer>().material.color = new Color(0, 1, 0, 1);
            cilindro11_12.GetComponent<Renderer>().material.color = new Color(0, 1, 0, 1);
            cilindro12_13.GetComponent<Renderer>().material.color = new Color(0, 1, 0, 1);

        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            pallina1.GetComponent<Renderer>().material.color = new Color(0, 1, 1, 1);
            pallina2.GetComponent<Renderer>().material.color = new Color(0, 1, 1, 1);
            pallina3.GetComponent<Renderer>().material.color = new Color(0, 1, 1, 1);
            pallina4.GetComponent<Renderer>().material.color = new Color(0, 1, 1, 1);
            pallina5.GetComponent<Renderer>().material.color = new Color(0, 1, 1, 1);
            pallina6.GetComponent<Renderer>().material.color = new Color(0, 1, 1, 1);
            pallina7.GetComponent<Renderer>().material.color = new Color(0, 1, 1, 1);
            pallina8.GetComponent<Renderer>().material.color = new Color(0, 1, 1, 1);
            pallina9.GetComponent<Renderer>().material.color = new Color(0, 1, 1, 1);
            pallina10.GetComponent<Renderer>().material.color = new Color(0, 1, 1, 1);
            pallina11.GetComponent<Renderer>().material.color = new Color(0, 1, 1, 1);
            pallina12.GetComponent<Renderer>().material.color = new Color(0, 1, 1, 1);
            pallina13.GetComponent<Renderer>().material.color = new Color(0, 1, 1, 1);
            testa.GetComponent<Renderer>().material.color = new Color(0, 1, 1, 1);
            cilindro12.GetComponent<Renderer>().material.color = new Color(0, 1, 1, 1);
            cilindro23.GetComponent<Renderer>().material.color = new Color(0, 1, 1, 1);
            cilindro34.GetComponent<Renderer>().material.color = new Color(0, 1, 1, 1);
            cilindro51.GetComponent<Renderer>().material.color = new Color(0, 1, 1, 1);
            cilindro65.GetComponent<Renderer>().material.color = new Color(0, 1, 1, 1);
            cilindro67.GetComponent<Renderer>().material.color = new Color(0, 1, 1, 1);
            cilindro8_11.GetComponent<Renderer>().material.color = new Color(0, 1, 1, 1);
            cilindro1_8.GetComponent<Renderer>().material.color = new Color(0, 1, 1, 1);
            cilindro1_11.GetComponent<Renderer>().material.color = new Color(0, 1, 1, 1);
            cilindro9_8.GetComponent<Renderer>().material.color = new Color(0, 1, 1, 1);
            cilindro9_10.GetComponent<Renderer>().material.color = new Color(0, 1, 1, 1);
            cilindro11_12.GetComponent<Renderer>().material.color = new Color(0, 1, 1, 1);
            cilindro12_13.GetComponent<Renderer>().material.color = new Color(0, 1, 1, 1);
        }
    }
    string sostituisci_frame(string contents)
    {
        int i = 0;
        int pos = 0;

        Debug.Log(contents);
        do
        {
            int ini = contents.IndexOf("frame", pos);
            int dif = contents.IndexOf('"', ini) - ini;
            contents = contents.Remove(ini, dif);
            contents = contents.Insert(ini, "frame_" + i);
            i++;
            pos = ini + pos;
        }
        while (contents.IndexOf("frame", pos) > 0);
        return contents;
    }
    void acquisisci_frame(string contents)
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

            frames.Add(wrapper.frame_primo);
            i++;
            el = contents.IndexOf("frame", ini + 100);
            contents = contents.Remove(contents.IndexOf('{', 0) + 1, el - (contents.IndexOf('{', 0) + 2));
        } while (contents.IndexOf("frame", 100) > 0);
    }
}
