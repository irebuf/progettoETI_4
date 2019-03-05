using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Drop : MonoBehaviour
{
    public GameObject mano;
    public GameObject spalla;
    public Dropdown drop_es;


    // Update is called once per frame
    void Update()
    {
        switch (drop_es.value)
        {
            case 0:
                mano.SetActive(false);
                spalla.SetActive(false);
                break;
            case 1:
                spalla.SetActive(false);
                mano.SetActive(true);
                break;
            case 2:
                mano.SetActive(false);
                spalla.SetActive(true);
                break;
            default:
                break;
        }
    }
}
