using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //Habilita los comandos para modificar el canvas

public class Volumen : MonoBehaviour
{
    //Declarando variables
    public Slider slider;
    public float sliderValue;
    public Image imageMute;




    // Start is called before the first frame update
    void Start()
    {

       slider.value = PlayerPrefs.GetFloat( "volumenAudio", 0.5f); //Con Get se invoca a la variable Audio y después de la coma se añade el valor o variable.
       AudioListener.volume = slider.value;
       RevisarSiMute();


    }


    public void ChangeSlider(float valor) 
    { 
        sliderValue = valor;
        PlayerPrefs.SetFloat("volumenAudio", sliderValue );
        AudioListener.volume = sliderValue;
        RevisarSiMute();

    }

    public void RevisarSiMute() //Se revisa el valor del slider y en funcion de si llega a 0 o no, se activa la imagen deseada.
    {
        
        if (sliderValue == 0f)
        {
            imageMute.enabled = true;
        }
        else 
        { 
        imageMute.enabled = false;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
