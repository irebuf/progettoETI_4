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
        string path = Application.dataPath + "/" + "note.txt";
        if (!File.Exists(path))
        {
            File.WriteAllText(path, System.DateTime.Today.Day.ToString() + "/"+ System.DateTime.Today.Month.ToString() + "/" + System.DateTime.Today.Year.ToString()+" "+ testo.text+'\n');
            Debug.Log("Testo nuovo");
        }else
        {
            string current = File.ReadAllText(path);
            File.WriteAllText(path, System.DateTime.Today.Day.ToString() + "/" + System.DateTime.Today.Month.ToString() + "/" + System.DateTime.Today.Year.ToString() + " "+ testo.text + '\n' + current);
            Debug.Log("Testo aggiunto");
        }
        testo.Select();
        testo.text = "";
       
    }
}
