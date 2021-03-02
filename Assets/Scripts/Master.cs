using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Master : MonoBehaviour
{
    public Light l;
    public GameObject obj;
    public BoxCollider boxC;
    public Camera cam;
    public Slider s;

    void Start()
    {
        l.intensity = 1.4f;
        obj.name = "Leuchte";
        boxC.isTrigger = true;
    }

}
