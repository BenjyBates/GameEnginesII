using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinny : MonoBehaviour
{
    public GameObject spinny;
    public float speed;

    void Update()
    {
        spinny.transform.Rotate(0, speed* Time.deltaTime, 0);
    }
}
