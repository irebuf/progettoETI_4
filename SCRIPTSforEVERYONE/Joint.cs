using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Joint
{
    public float x;
    public float y;
    public float z;

    public Joint()
    {
    }

    public Joint(float x, float y, float z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }

}
