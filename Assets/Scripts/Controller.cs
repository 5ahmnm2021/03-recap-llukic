using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{
    public InputField Zahl01;
    public InputField Zahl02;
    public Text result;
    public Text Error;
    public float num1;
    public float num2;

    string errorMsg = "Mate! Pls type a number!";

    public void ChangeSceneA()
    {
        SceneManager.LoadScene("01ColorScene");
    }

    public void ChangeSceneB()
    {
        SceneManager.LoadScene("02NumberScene");
    }

    public void ChangeSceneC()
    {
        SceneManager.LoadScene("00WelcomeScene");
    }

    public void AddNumbersOnClick()
    {
        try
        {
            num1 = float.Parse(Zahl01.text);
        }
        catch (System.Exception)
        {
            Zahl01.image.color = new Color32(255,0,0,100);
            Error.text = errorMsg;
        }
        try
        {
            num2 = float.Parse(Zahl02.text);
        }
        catch (System.Exception)
        {
            Zahl02.image.color = new Color32(255,0,0,100);
            Error.text = errorMsg;
        }

        result.text = (num1 + num2).ToString();
        Debug.Log("Die Addition ergibt: " + result.text);
    }

}
