using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Creazione : MonoBehaviour
{

    public GameObject punto = null;
    //List<Vector3> vettori0 = new List<Vector3>();
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
    List<Vector3> vettori12= new List<Vector3>();
    List<Vector3> vettori13 = new List<Vector3>();
   // List<Vector3> vettori14 = new List<Vector3>();
    //List<Vector3> vettori15 = new List<Vector3>();
    List<Vector3> vettori16 = new List<Vector3>();
    List<Vector3> vettori17 = new List<Vector3>();
    int frame = 0;
    //GameObject punto0 = null;
    GameObject punto1 = null;
    GameObject punto2 = null;
    GameObject punto3 = null;
    GameObject punto4 = null;
    GameObject punto5 = null;
    GameObject punto6 = null;
    GameObject punto7 = null;
    GameObject punto8 = null;
    GameObject punto9 = null;
    GameObject punto10 = null;
    GameObject punto11 = null;
    GameObject punto12 = null;
    GameObject punto13 = null;
    //GameObject punto14 = null;
    //GameObject punto15 = null;
    GameObject punto16 = null;
    GameObject punto17 = null;
   

    // Start is called before the first frame update
    void Start()
    {

       /* Quaternion b = new Quaternion(0, 0, 0, 0);
        Vector3 d = new Vector3(0, 0, 0);
        punto1 = GameObject.Instantiate(punto, d, b);*/
    }

    // Update is called once per frame
    void Update()
    {


        JsonFile altro = GetComponent<JsonFile>();
        List<Frame> lista = altro.get_data();
        int n_ele = lista.Count;
        //Debug.Log(n_ele);
        GameObject line12 = new GameObject();



        for (int k = 0; k < n_ele; k++)
        {
            //Vector3 a0 = new Vector3(lista[k].person_0.joint_0.x, lista[k].person_0.joint_0.y, lista[k].person_0.joint_0.z);
            Vector3 a1 = new Vector3(lista[k].person_0.joint_1.x, lista[k].person_0.joint_1.y, lista[k].person_0.joint_1.z);
            Vector3 a2 = new Vector3(lista[k].person_0.joint_2.x, lista[k].person_0.joint_2.y, lista[k].person_0.joint_2.z);
            Vector3 a3 = new Vector3(lista[k].person_0.joint_3.x, lista[k].person_0.joint_3.y, lista[k].person_0.joint_3.z);
            Vector3 a4 = new Vector3(lista[k].person_0.joint_4.x, lista[k].person_0.joint_4.y, lista[k].person_0.joint_4.z);
            Vector3 a5 = new Vector3(lista[k].person_0.joint_5.x, lista[k].person_0.joint_5.y, lista[k].person_0.joint_5.z);
            Vector3 a6 = new Vector3(lista[k].person_0.joint_6.x, lista[k].person_0.joint_6.y, lista[k].person_0.joint_6.z);
            Vector3 a7 = new Vector3(lista[k].person_0.joint_7.x, lista[k].person_0.joint_7.y, lista[k].person_0.joint_7.z);
            Vector3 a8 = new Vector3(lista[k].person_0.joint_8.x, lista[k].person_0.joint_8.y, lista[k].person_0.joint_8.z);
            Vector3 a9 = new Vector3(lista[k].person_0.joint_9.x, lista[k].person_0.joint_9.y, lista[k].person_0.joint_9.z);
            Vector3 a10 = new Vector3(lista[k].person_0.joint_10.x, lista[k].person_0.joint_10.y, lista[k].person_0.joint_10.z);
            Vector3 a11=  new Vector3(lista[k].person_0.joint_11.x, lista[k].person_0.joint_11.y, lista[k].person_0.joint_11.z);
            Vector3 a12 = new Vector3(lista[k].person_0.joint_12.x, lista[k].person_0.joint_12.y, lista[k].person_0.joint_12.z);
            Vector3 a13 = new Vector3(lista[k].person_0.joint_13.x, lista[k].person_0.joint_13.y, lista[k].person_0.joint_13.z);
           // Vector3 a14 = new Vector3(lista[k].person_0.joint_14.x, lista[k].person_0.joint_14.y, lista[k].person_0.joint_14.z);
           // Vector3 a15 = new Vector3(lista[k].person_0.joint_15.x, lista[k].person_0.joint_15.y, lista[k].person_0.joint_15.z);
            Vector3 a16 = new Vector3(lista[k].person_0.joint_16.x, lista[k].person_0.joint_16.y, lista[k].person_0.joint_16.z);
            Vector3 a17 = new Vector3(lista[k].person_0.joint_17.x, lista[k].person_0.joint_17.y, lista[k].person_0.joint_17.z);

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
        Quaternion b = new Quaternion(0, 0, 0, 0);
        if(frame == 0)
        {/*
            punto0 = GameObject.Instantiate(punto, vettori0[0], b);
            punto1 = GameObject.Instantiate(punto, vettori1[0], b);
            punto2 = GameObject.Instantiate(punto, vettori2[0], b);
            punto3 = GameObject.Instantiate(punto, vettori3[0], b);
            punto4 = GameObject.Instantiate(punto, vettori4[0], b);
            punto5 = GameObject.Instantiate(punto, vettori5[0], b);
            punto6 = GameObject.Instantiate(punto, vettori6[0], b);
        */
        }
        if (frame % 99 == 0)
        {
           // Destroy(punto0);
            Destroy(punto1);
            Destroy(line12);
            Destroy(punto2);
            Destroy(punto3);
            Destroy(punto4);
            Destroy(punto5);
            Destroy(punto6);
            Destroy(punto7);
            Destroy(punto8);
            Destroy(punto9);
            Destroy(punto10);
            Destroy(punto11);
            Destroy(punto12);
            Destroy(punto13);
            //Destroy(punto14);
            //Destroy(punto15);
            Destroy(punto16);
            Destroy(punto17);
            

        }
        if (frame % 100 == 0)
        {/*
            punto0.transform.Translate(vettori0[frame / 100], Space.World);
            punto1.transform.Translate(vettori1[frame / 100], Space.World);
            punto2.transform.Translate(vettori2[frame / 100], Space.World);
            punto3.transform.Translate(vettori3[frame / 100], Space.World);
            punto4.transform.Translate(vettori4[frame / 100], Space.World);
            punto5.transform.Translate(vettori5[frame / 100], Space.World);
            punto6.transform.Translate(vettori6[frame / 100], Space.World);

            */
             //   punto0 = GameObject.Instantiate(punto, vettori0[frame / 100],b);
             punto1 = GameObject.Instantiate(punto, vettori1[frame / 100],b);
            line12.transform.position = vettori1[frame / 100];
            line12.AddComponent<LineRenderer>();
            LineRenderer lr = line12.GetComponent<LineRenderer>();
            lr.SetPosition(0, vettori1[frame / 100]);
            lr.SetPosition(1, vettori2[frame / 100]);

            punto2 = GameObject.Instantiate(punto, vettori2[frame / 100], b);
             punto3 = GameObject.Instantiate(punto, vettori3[frame / 100], b);
             punto4 = GameObject.Instantiate(punto, vettori4[frame / 100], b);
             punto5 = GameObject.Instantiate(punto, vettori5[frame / 100], b);
             punto6 = GameObject.Instantiate(punto, vettori6[frame / 100], b);
             punto7 = GameObject.Instantiate(punto, vettori7[frame / 100], b);
             punto8 = GameObject.Instantiate(punto, vettori8[frame / 100], b);
             punto9 = GameObject.Instantiate(punto, vettori9[frame / 100], b);
             punto10 = GameObject.Instantiate(punto, vettori10[frame / 100], b);
             punto11 = GameObject.Instantiate(punto, vettori11[frame / 100], b);
             punto12 = GameObject.Instantiate(punto, vettori12[frame / 100], b);
             punto13 = GameObject.Instantiate(punto, vettori13[frame / 100], b);
             //punto14 = GameObject.Instantiate(punto, vettori14[frame / 100], b);
            // punto15 = GameObject.Instantiate(punto, vettori15[frame / 100], b);
             punto16 = GameObject.Instantiate(punto, vettori16[frame / 100], b);
             punto17 = GameObject.Instantiate(punto, vettori17[frame / 100], b);
             

        }
       // Debug.Log(frame);
        frame++;
        if(frame > n_ele * 100) { frame -= (n_ele * 100); }
        
    }
}
