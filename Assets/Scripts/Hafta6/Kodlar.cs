using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Kodlar : MonoBehaviour
{
    public Toggle erkek;
    public Toggle kadin;
  
    public void ToggleE(bool T�kland�)
    {
        if (T�kland�)
        {
            kadin.isOn=false;
        }
    }

    public void ToggleK(bool T�kland�)
    {
       
        if (T�kland�)
        {       
            erkek.isOn= false;
        }
    }

    //yukarda ayn� anda iki toggle t�klanabilir olmamas�n� sa�layan kod var

    public TextMeshProUGUI text;
    public Slider slider;

    private void Start()
    {
        text.text = slider.value.ToString();
    }
    public void Value()
    {
        text.text = slider.value.ToString();
    }

    //slider de�erini sahnedeki text objesine d�n��t�ren g�r�lebilir de�er
}
