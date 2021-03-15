//namespaces "bibliotheken"
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

//zeile 7 und 8 deklarieren den anfang der deklaration
public class Controller : MonoBehaviour
{
    //variabeln sind speicherplatz für daten und können nicht ausserhalb von klassen deklariert werden
    //variabeln deklarieren (exessmodifier - datentyp - variable)
    //variabeln zuweisung = (name - zuweisungsoperator - wert)
  
    public InputField Zahl01;
    public InputField Zahl02;
    public Text result;
    public Text Error;

    public float num1;
    public float num2;


   // Start is called before the first frame update
   // jetzt kommt die deklaration
   // void Start()
   //{
   //hier steht der code der ausgeführt werden soll (z.B MyName(); = MethodenAufruf)
   //}
   // Update is called once per frame
   // void Update()
   //{
   //}

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
            Error.text = "Mate! You forgot something!";
        }
        try
        {
            num2 = float.Parse(Zahl02.text);
        }
        catch (System.Exception)
        {
            Zahl02.image.color = new Color32(255,0,0,100);
            Error.text = "Mate! You forgot something!";
        }

        //float addResult = num1 + num2;
        result.text = (num1 + num2).ToString();
        Debug.Log("Die Addition ergibt: " + result.text);
    }


}


//Klassen in Klassen deklarieren kann man NICHT
//MethodenDeklaration besteht aus private string MyName(){}
//void-> man bekommt nichts retour
//strng--return; -> man bekommt was zurück
