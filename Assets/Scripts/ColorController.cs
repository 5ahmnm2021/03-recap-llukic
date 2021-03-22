using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorController : MonoBehaviour
{
    public Image ColorField;
    
    public void ChangeColor()
    {
        int randomNumber;

        var colors = new List<Color>()
        {
            new Color32(255, 205, 25, 100),
            new Color32(95, 34, 0, 100),
            new Color32(167, 235, 122, 100),
            new Color32(245, 149, 235, 100)
        };

        if (Input.GetKeyDown("space"))
        {
            randomNumber = Random.Range(0, colors.Count);
            ColorField.color = colors[randomNumber];
        }
    }
    private void Update()
    {
        ChangeColor();
    }
}
