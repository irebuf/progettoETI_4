using System.Collections;
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
    //Vector3 movimento16;
    //Vector3 movimento17;
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
    //public GameObject pallina16;
    //public GameObject pallina17;
    public GameObject testa;



    string filename = "pallineData.json";
    string path;
    string paths;
    string pathss;
    List<Frame> frames = new List<Frame>();

    //string contents = System.IO.File.ReadAllText(Application.DataPath + "/" + "esecuzione es1 irene con schiena storta.json");

    //GameData gameData = new GameData();

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
    // List<Vector3> vettori14 = new List<Vector3>();
    //List<Vector3> vettori15 = new List<Vector3>();
    List<Vector3> vettori16 = new List<Vector3>();
    List<Vector3> vettori17 = new List<Vector3>();
    //Frame frame_0 = new Frame();
    /*Frame frame_1 = new Frame();
    Frame frame_2 = new Frame();
    Frame frame_3 = new Frame();
    Frame frame_4 = new Frame();
    Frame frame_5 = new Frame();
    Frame frame_6 = new Frame();
    Frame frame_7 = new Frame();
    Frame frame_8 = new Frame();
    Frame frame_9 = new Frame();
    Frame frame_10 = new Frame();
    Frame frame_11 = new Frame();
    Frame frame_12 = new Frame();
    Frame frame_13 = new Frame();
    Frame frame_14 = new Frame();
    Frame frame_15 = new Frame();
    Frame frame_16 = new Frame();
    Frame frame_17 = new Frame();
    Frame frame_18 = new Frame();
    Frame frame_19 = new Frame();
    Frame frame_20 = new Frame();
    Frame frame_21 = new Frame();
    Frame frame_22 = new Frame();
    Frame frame_23 = new Frame();
    Frame frame_24 = new Frame();
    Frame frame_25 = new Frame();*/

    //public Frame frame_7 { get; private set; }
    public void tornavettori()
    {
        //List<Frame> frames = altro.get_data();
        int n_ele = frames.Count;
        //Debug.Log(n_ele);
        //GameObject line12 = new GameObject();



        for (int k = 0; k < n_ele; k++)
        {
            //Vector3 a0 = new Vector3(frames[k].person_0.joint_0.x, frames[k].person_0.joint_0.y, frames[k].person_0.joint_0.z);
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
            // Vector3 a14 = new Vector3(frames[k].person_0.joint_14.x, frames[k].person_0.joint_14.y, frames[k].person_0.joint_14.z);
            // Vector3 a15 = new Vector3(frames[k].person_0.joint_15.x, frames[k].person_0.joint_15.y, frames[k].person_0.joint_15.z);
            Vector3 a16 = new Vector3(frames[k].person_0.joint_16.x, frames[k].person_0.joint_16.y, frames[k].person_0.joint_16.z);
            Vector3 a17 = new Vector3(frames[k].person_0.joint_17.x, frames[k].person_0.joint_17.y, frames[k].person_0.joint_17.z);

            //vettori0.Add(a0);
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
            //vettori14.Add(a14);
            //vettori15.Add(a15);
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

        path = Application.dataPath + "/" + filename;
        paths = Application.dataPath + "/" + "provaseba.json";
        pathss = Application.dataPath + "/" + "ominoBiancoGiusto.json";
        //Debug.Log(paths);
        //CreateFile();
        string contents = System.IO.File.ReadAllText(pathss);
        // contents=sostituisci_frame(contents);
        //ReadData(contents);
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
            //movimento16 = vet16()[q / frame_rate];
            //movimento17 = vet17()[q / frame_rate];
            movimentotesta = ((vet16()[q / frame_rate] + vet17()[q / frame_rate]) / 2);
            testa.transform.position = movimentotesta;


            //Debug.Log("ciao");
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
            // pallina16.transform.position = movimento16;
            //pallina17.transform.position = movimento17;

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
            //movimento16 = vet16()[q / frame_rate];
            //movimento17 = vet17()[q / frame_rate];
            movimentotesta = ((vet16()[q / frame_rate] + vet17()[q / frame_rate]) / 2);
            testa.transform.position = movimentotesta;


            //Debug.Log("ciao");
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
            // pallina16.transform.position = movimento16;
            //pallina17.transform.position = movimento17;

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
                //movimento16 = vet16()[q / frame_rate];
                //movimento17 = vet17()[q / frame_rate];
                movimentotesta = ((vet16()[q / frame_rate] + vet17()[q / frame_rate]) / 2);
                testa.transform.position = movimentotesta;


                //Debug.Log("ciao");
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
                // pallina16.transform.position = movimento16;
                //pallina17.transform.position = movimento17;

            }
            q++;
            if (q > n * frame_rate) { q = 0; }
            /*GameObject sphere0 = GameObject.CreatePrimitive(PrimitiveType.Sphere);

            sphere0.transform.position = new Vector3(frames[j].person_0.joint_0.x, frames[j].person_0.joint_0.y, frames[j].person_0.joint_0.z);

            GameObject sphere1 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            sphere1.transform.position = new Vector3(frames[j].person_0.joint_1.x, frames[j].person_0.joint_1.y, frames[j].person_0.joint_1.z);
         */
            /*   GameObject sphere2 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
               sphere2.transform.position = new Vector3(frames[j].person_0.joint_2.x, frames[j].person_0.joint_2.y, frames[j].person_0.joint_2.z);

               GameObject sphere3 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
               sphere3.transform.position = new Vector3(frames[j].person_0.joint_3.x, frames[j].person_0.joint_3.y, frames[j].person_0.joint_3.z);

               GameObject sphere4 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
               sphere4.transform.position = new Vector3(frames[j].person_0.joint_3.x, frames[j].person_0.joint_3.y, frames[j].person_0.joint_3.z);

               GameObject sphere5 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
               sphere5.transform.position = new Vector3(frames[j].person_0.joint_5.x, frames[j].person_0.joint_5.y, frames[j].person_0.joint_5.z);

               GameObject sphere6 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
               sphere6.transform.position = new Vector3(frames[j].person_0.joint_6.x, frames[j].person_0.joint_6.y, frames[j].person_0.joint_6.z);

               GameObject sphere7 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
               sphere7.transform.position = new Vector3(frames[j].person_0.joint_7.x, frames[j].person_0.joint_7.y, frames[j].person_0.joint_7.z);

               GameObject sphere8 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
               sphere8.transform.position = new Vector3(frames[j].person_0.joint_8.x, frames[j].person_0.joint_8.y, frames[j].person_0.joint_8.z);

               GameObject sphere9 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
               sphere9.transform.position = new Vector3(frames[j].person_0.joint_9.x, frames[j].person_0.joint_9.y, frames[j].person_0.joint_9.z);

               GameObject sphere10 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
               sphere10.transform.position = new Vector3(frames[j].person_0.joint_10.x, frames[j].person_0.joint_10.y, frames[j].person_0.joint_10.z);

               j++;
               */
            /* if (Input.GetKeyDown(KeyCode.R))
             {

                 ReadData();
             }
             */
        }
    }
    void CreateFile()
    {
        try
        {

            if (System.IO.File.Exists(path))
            {
                Debug.Log("STATO OK : il file esiste e sembra leggibile.");
            }
            else
            {
                FrameWrap wrapper = new FrameWrap();
                // wrapper.frame_0 = frame_0;

                //Debug.Log("Creating File...");

                /*string contents = JsonUtility.ToJson(wrapper, true);
                System.IO.File.WriteAllText(path, contents);*/
                string contents = JsonUtility.ToJson(wrapper, true);
                System.IO.File.WriteAllText(path, contents);
                Debug.Log("File creato");
            }
        }
        catch (System.Exception ex)
        {
            Debug.Log(ex.Message);
        }
        //Debug.Log("Fuori dal try : STATO OK");
    }
    /*
    void SaveData()
    {
        DataWrapper wrapper = new DataWrapper();
        wrapper.gameData = gameData;
        Debug.Log("SaveData:");
        Debug.Log(gameData.date + " @ " + gameData.time);
        string contents = JsonUtility.ToJson(wrapper, true);
        System.IO.File.WriteAllText(path, contents);
    }
    
    void ReadData()
    {
            if (System.IO.File.Exists(path))
            {
                string contents = System.IO.File.ReadAllText(path);
                DataWrapper wrapper = JsonUtility.FromJson<DataWrapper>(contents);
                gameData = wrapper.gameData;
                Debug.Log("ReadData:");
                Debug.Log(gameData.date + " @ " + gameData.time);
            }
            else
            {
                Debug.Log("unable to read data, file does not exist");
                gameData = new GameData();
            }
    }
      
    */
    string sostituisci_frame(string contents)
    {
        int i = 0;
        int pos = 0;

        Debug.Log(contents);
        do
        {
            // Debug.Log(contents);
            int ini = contents.IndexOf("frame", pos);
            // Debug.Log(ini);
            int dif = contents.IndexOf('"', ini) - ini;
            // Debug.Log(dif);
            contents = contents.Remove(ini, dif);
            //Debug.Log(contents); //restituisce una stringa parte dalla posizione e per tot elementi
            //Debug.Log(i);
            contents = contents.Insert(ini, "frame_" + i);
            i++;
            //Debug.Log(i);
            pos = ini + pos;
            //Debug.Log(contents);
            //Debug.Log(contents.IndexOf("frame", pos));
        }
        while (contents.IndexOf("frame", pos) > 0);
        // while (contents.IndexOf("frame", pos)+1 < contents.LastIndexOf("frame"));
        Debug.Log(contents);
        return contents;
    }
    void acquisisci_frame(string contents)
    {
        //var map = new Dictionary<int, Frame>();
        //Frame [] array;
        int i = 0;
        int pos = 0;
        int el = 0;
        do
        {
            int ini = contents.IndexOf("frame", pos);
            int dif = contents.IndexOf('"', ini) - ini;
            // Debug.Log(dif);
            contents = contents.Remove(ini, dif);
            //Debug.Log(contents); //restituisce una stringa parte dalla posizione e per tot elementi
            //Debug.Log(i);
            contents = contents.Insert(ini, "frame_primo");
            //Debug.Log(contents);
            //Debug.Log(i);
            FrameWrap wrapper = JsonUtility.FromJson<FrameWrap>(contents);


            //Debug.Log(wrapper.frame_primo.person_0.joint_1.x);

            frames.Add(wrapper.frame_primo);
            i++;
            //Debug.Log(wrapper.frame_primo.person_0.joint_0.x);
            el = contents.IndexOf("frame", ini + 100);
            contents = contents.Remove(contents.IndexOf('{', 0) + 1, el - (contents.IndexOf('{', 0) + 2));
            //if (contents.IndexOf("frame", 100) > 0) { contents = contents.Remove(contents.IndexOf('{', 0) + 1, el - (contents.IndexOf('{', 0) + 2)); }//tolgo un frame ogni due perchè ho troppi frame
            //Debug.Log(contents);

        } while (contents.IndexOf("frame", 100) > 0);

    }

    /* void ReadData(string contents)
     {
         //Debug.Log("Reading File...");
         try
         {
             if (System.IO.File.Exists(pathss))
             {
                 Debug.Log("Reading Existing File");
                 //string contents = System.IO.File.ReadAllText(path);
                 FrameWrap wrapper = JsonUtility.FromJson<FrameWrap>(contents);
                // frame_0 = wrapper.frame_0;
                 frame_1 = wrapper.frame_1;
                 frame_2 = wrapper.frame_2;
                 frame_3 = wrapper.frame_3;
                 frame_4 = wrapper.frame_4;
                 frame_5 = wrapper.frame_5;
                 frame_6 = wrapper.frame_6;
                 frame_7 = wrapper.frame_7;
                 frame_8 = wrapper.frame_8;
                 frame_9 = wrapper.frame_9;
                 frame_10 = wrapper.frame_10;
                 frame_11 = wrapper.frame_11;
                 frame_12 = wrapper.frame_12;
                 frame_13 = wrapper.frame_13;
                 frame_14 = wrapper.frame_14;
                 frame_15 = wrapper.frame_15;
                 frame_16 = wrapper.frame_16;
                 frame_17 = wrapper.frame_17;
                 frame_18 = wrapper.frame_18;
                 frame_19 = wrapper.frame_19;
                 frame_20 = wrapper.frame_20;
                 frame_21 = wrapper.frame_21;
                 frame_22 = wrapper.frame_22;
                 frame_23 = wrapper.frame_23;
                 frame_24 = wrapper.frame_24;
                 frame_25 = wrapper.frame_25;

                 Debug.Log(  "x: " + frame_2.person_0.joint_0.x +
                           ", y: " + frame_2.person_0.joint_0.y +
                           ", z: " + frame_2.person_0.joint_0.z
                           );
             }
             else
             {
                 Debug.Log("unable to read file : STATO BAD");
                 //frame_0 = new Frame();
             }
         }
         catch (System.Exception ex)
         {
             Debug.Log(ex.Message);
         }
     }


     */










}
