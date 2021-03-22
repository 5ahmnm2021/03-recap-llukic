using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorController : MonoBehaviour
{
    public Image colorField;
    
    public void ChangeColor()
    {
        int randomNumber;

        var colors = new List<Color>()
        {
            new Color32(255, 205, 25, 100),
            new Color32(95, 34, 0, 100),
            new Color32(207, 63, 21, 100),
            new Color32(102, 47, 235, 100)
        };

        if (Input.GetKeyDown("space"))
        {
            randomNumber = Random.Range(0, colors.Count);
            colorField.color = colors[randomNumber];
        }
    }
    private void Update()
    {
        ChangeColor();
    }
}
