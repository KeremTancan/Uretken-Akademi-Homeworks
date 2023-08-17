using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class RaporScript : MonoBehaviour
{
    public TMP_InputField isim;
    public Slider Yas;
    public Toggle Cinsiyet;
    public TMP_Dropdown KardesSayisi;
    public Text cins;
  

    public void AnketBitti()
    {
        if (Cinsiyet.isOn)
        {
            cins.text = "erkek";
        }
        else
        {
            cins.text = "kadýn";
        }


        Debug.Log("Ýsim: " + isim.text);
        Debug.Log("Yaþ: " + Yas.value);
        Debug.Log("Cinsiyet: " + cins.text.ToString());
        Debug.Log("Kardeþ Sayýsý: " + KardesSayisi.value);

        //anketi bitir butonuna basýldýðýnda consola girilen deðerleri yazan kýsým
    }

   
}
