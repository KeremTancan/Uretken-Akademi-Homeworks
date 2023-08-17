using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Kodlar : MonoBehaviour
{
    public Toggle erkek;
    public Toggle kadin;
  
    public void ToggleE(bool Týklandý)
    {
        if (Týklandý)
        {
            kadin.isOn=false;
        }
    }

    public void ToggleK(bool Týklandý)
    {
       
        if (Týklandý)
        {       
            erkek.isOn= false;
        }
    }

    //yukarda ayný anda iki toggle týklanabilir olmamasýný saðlayan kod var

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

    //slider deðerini sahnedeki text objesine dönüþtüren görülebilir deðer
}
