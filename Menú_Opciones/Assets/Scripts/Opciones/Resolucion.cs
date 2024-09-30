using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;
using JetBrains.Annotations;

public class Resolucion : MonoBehaviour
{
    public Toggle toggle;
    public TMP_Dropdown resolucionDropDown;
    Resolution[] resolutions;
    


// Start is called before the first frame update
void Start()
    {
        if (Screen.fullScreen)
        {
            toggle.isOn = true;
        }
        else
        {
            toggle.isOn = false;
        }
    }

    public void ActivarPantallaCompleta(bool pantallaCompleta)
    {

        Screen.fullScreen = pantallaCompleta;

    }

    public void RevisaResolucion() 
    { 
    
        resolutions = Screen.resolutions;
        List<string>options=new List<string>();
        int resolucionActual = 0;

        for (int i = 0; i < resolutions.Length; i++) 
        {
            string option = resolutions[i].width +"x" + resolutions[i].height;

            if (resolutions[i].width == Screen.currentResolution.width &&
                resolutions[i].height == Screen.currentResolution.height)
            {
                resolucionActual = i;
            }
        
        }
        resolucionDropDown.AddOptions(options);
        resolucionDropDown.value = resolucionActual;
        resolucionDropDown.RefreshShownValue();

        resolucionDropDown.value = PlayerPrefs.GetInt("numeroresolucion");
    }
    public void CambiarResolucion(int indicadorResolucion) 
    {
        Resolution resolucion = resolutions[indicadorResolucion];
        Screen.SetResolution(resolucion.width, resolucion.height, Screen.fullScreen);
    }











    // Update is called once per frame
    void Update()
    {
        
    }
}
