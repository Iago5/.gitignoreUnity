using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Calidad : MonoBehaviour
{

    public TMP_Dropdown dropdown;
    public int calidad;


    // Start is called before the first frame update
    void Start()
    {

        calidad = PlayerPrefs.GetInt("numerocalidad", 3);
        dropdown.value = calidad;

    }

    public void calidade() 
    { 
        QualitySettings.SetQualityLevel(dropdown.value,true);
        PlayerPrefs.SetInt("numeroacalidad", dropdown.value);
        calidad = dropdown.value;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
