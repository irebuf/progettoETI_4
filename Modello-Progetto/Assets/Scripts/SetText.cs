using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;


public class SetText : MonoBehaviour
{
    public InputField testo;

    public void CreateText()
    {
        string path = Application.dataPath + "/note.txt";
        if (!File.Exists(path))
        {
            File.WriteAllText(path, testo.text+'\n');
            Debug.Log("Testo nuovo");
        }else
        {
            File.AppendAllText(path, testo.text + '\n');
            Debug.Log("Testo aggiunto");
        }
        testo.Select();
        testo.text = "";
       
    }/*
    public void ClearText()
    {
        testo.clear
    }
    /*
    public void Start()
    {
        CreateText();
    }

    public void Update()
    {
        CreateText();
    }


    public void setget()
    {
        print("Inserisci note");
    }
    */
}
