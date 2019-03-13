using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Linq;
using UnityEngine.UI;

//[RequireComponent(typeof(TextMesh))]
public class GetText : MonoBehaviour
{
    
    public Text textComp;
    //string textCont;
    //public string fileName;
    //string path = Application.dataPath + "/note.txt";

    private TextAsset textAss;

    // Start is called before the first frame update
    void Start()
    {
        //textAss = (TextAsset)Resources.Load(path);
        /*
        textCont = textAss.text;
        textComp.text = textAss.text;
        */
        textComp.text = System.IO.File.ReadAllText("Assets/note.txt");
        //textComp.text = System.IO.File.ReadAllText("note.txt");
    }
    /*
    // Update is called once per frame
    void onGUI()
    {
        GUILayout.Label(textCont);
    }*/
}
