using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pantalla_Completa : MonoBehaviour
{

    public Toggle togglePantallaCompleta;








    // Start is called before the first frame update
    void Start()
    {


        if (Screen.fullScreen) 
        {
            togglePantallaCompleta.isOn = true;
        }
        else 
        {
            togglePantallaCompleta.isOn = false;
        }


    }


    public void ActivarPantallaCompleta(bool pantallaCompleta) 
    { 
    
        Screen.fullScreen = pantallaCompleta;

    }










    // Update is called once per frame
    void Update()
    {
        
    }
}
