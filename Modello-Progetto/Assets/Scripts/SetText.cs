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
        string path = Application.persistentDataPath + "/note.txt";
        if (!File.Exists(path))
        {
            File.WriteAllText(path, testo.text+'\n');
            Debug.Log("Testo nuovo");
        }
        File.AppendAllText(path, testo.text + '\n');
        Debug.Log("Testo aggiunto");
       
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
