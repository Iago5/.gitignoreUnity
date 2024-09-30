using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //Habilita los comandos para editar los canvas

public class Brillo : MonoBehaviour
{
    
    public Slider slider;
    public float sliderValue;
    public Image brilloimage;



    public void changeslider(float valor) 
    { 
        sliderValue = valor;
        PlayerPrefs.SetFloat("Brillo", sliderValue);
        brilloimage.color = new Color(brilloimage.color.r, brilloimage.color.g, brilloimage.color.b, slider.value);
    }

    // Start is called before the first frame update
    void Start()
    {

        slider.value = PlayerPrefs.GetFloat("Brillo", 0.5f); //Con Get se invoca a la variable Brillo y después de la coma se añade el valor o variable.
        slider.value = PlayerPrefs.GetFloat("Brillopantalla", 0.5f);
        brilloimage.color = new Color(brilloimage.color.r, brilloimage.color.g, brilloimage.color.b, sliderValue);
        
    }

    // Update is called once per frame
    void Update()
    {
       



    }
}
