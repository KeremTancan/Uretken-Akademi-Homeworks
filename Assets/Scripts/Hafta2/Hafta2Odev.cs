using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hafta2Odev : MonoBehaviour
{
    void BolenleriBul(int ilksayi, int ikincisayi)
    {
        ArrayList Sayilar = new ArrayList();
        ArrayList Ikiyebolunenler = new ArrayList();
        ArrayList UceBolunenler = new ArrayList();
        ArrayList DordeBolunenler = new ArrayList();
        ArrayList BeseBolunenler = new ArrayList();
        string outputSayilar = "";
        string outputIkiyebolunenler = "";       
        string outputUceBolunenler = "";
        string outputDordeBolunenler = "";
        string outputBeseBolunenler = "";

        for (int arasayi = ilksayi; arasayi <= ikincisayi; arasayi++)
        {
            Sayilar.Add(arasayi);

            if (arasayi % 2 == 0)
            {
                Ikiyebolunenler.Add(arasayi);
            }
            if (arasayi % 3 == 0)
            {
                UceBolunenler.Add(arasayi);
            }
            if (arasayi % 4 == 0)
            {
                DordeBolunenler.Add(arasayi);
            }
            if (arasayi % 5 == 0)
            {
                BeseBolunenler.Add(arasayi);
            }
        }

        foreach (int sayi in Sayilar)
        {
            outputSayilar += sayi + "-";
        }

        foreach (int sayi in Ikiyebolunenler)
        {
            outputIkiyebolunenler += sayi + "-";
        }
        foreach (int sayi in UceBolunenler)
        {
            outputUceBolunenler += sayi + "-";
        }
        foreach (int sayi in DordeBolunenler)
        {
            outputDordeBolunenler += sayi + "-";
        }
        foreach (int sayi in BeseBolunenler)
        {
            outputBeseBolunenler += sayi + "-";
        }

        Debug.Log("T�m Liste: " + outputSayilar.TrimEnd('-')); 
        Debug.Log("�kiye B�l�nenler: " + outputIkiyebolunenler.TrimEnd('-'));
        Debug.Log("��e B�l�nenler: " + outputUceBolunenler.TrimEnd('-'));
        Debug.Log("D�rde B�l�nenler: " + outputDordeBolunenler.TrimEnd('-'));
        Debug.Log("Be�e B�l�nenler: " + outputBeseBolunenler.TrimEnd('-'));
    }

    void Start()
    {
        BolenleriBul(12, 86);
    }
}
