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
            cins.text = "kad�n";
        }


        Debug.Log("�sim: " + isim.text);
        Debug.Log("Ya�: " + Yas.value);
        Debug.Log("Cinsiyet: " + cins.text.ToString());
        Debug.Log("Karde� Say�s�: " + KardesSayisi.value);

        //anketi bitir butonuna bas�ld���nda consola girilen de�erleri yazan k�s�m
    }

   
}
