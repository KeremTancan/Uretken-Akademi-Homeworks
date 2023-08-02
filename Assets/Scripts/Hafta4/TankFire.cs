using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class TankFire : MonoBehaviour
{
    RaycastHit hit;
    public GameObject Namlu;
    public GameObject SmokePosition;
    public TextMeshProUGUI EnemyCountText;
    private int EnemyCount;
    public GameObject WinCanvas;
    private bool isGameOver =false;
    public GameObject fireSmoke;
   

    private void Start()
    {
        
        WinCanvas.SetActive(false);
        EnemyCount = GameObject.FindGameObjectsWithTag("Enemy").Length; // sahnede ka� tane d��man var oldu�unu ��renme
    }
    void Update()
    {
        EnemyCountText.text = "Kalan D��man Say�s�: " + EnemyCount ; //kalan d��man say�s� g�ncel olarak ekranda g�sterme

        if (Input.GetKeyDown(KeyCode.Space)) //Ate� etme 
        {
            Instantiate(fireSmoke, SmokePosition.transform);
            
            
            SoundManager.Instance.PlayEffectSound(SoundManager.Instance.FireSound); // ate� etme sesi ��kmas�

            if (Physics.Raycast(Namlu.transform.position, transform.forward, out hit, Mathf.Infinity) && hit.collider.gameObject.tag == "Enemy")
            {
                SoundManager.Instance.PlayEffectSound(SoundManager.Instance.DieSound); //�lme sesi ��kmas�

                EnemyCount--; //D��man say�s�n� g�ncelleme (azaltma)
                
                if(hit.collider.TryGetComponent(out Animator animator))
                {
                    //hit.collider.GetComponent<BoxCollider>().isTrigger = true;
                    animator.enabled = false;

                    hit.collider.transform.GetChild(0).GetChild(1).GetChild(2).GetChild(0).GetComponent<Rigidbody>().AddForce( (hit.collider.transform.up) * 15000f);
                    Destroy(hit.collider.gameObject,2f);
                }
                //vurulan askeri yok etme
            }
            
        }

        if(EnemyCount== 0 && !isGameOver) 
        {
            
            Destroy(EnemyCountText); // en alttaki kalan d��man say�s� yaz�s�n� siliyor
            WinCanvas.SetActive(true);  //D��man say�s� s�f�rland���nda kazanma ekran� ��karma
            SoundManager.Instance.PlayEffectSound(SoundManager.Instance.WinSound); // kazanma sesi ��karma
            isGameOver= true;

        }
    }
}



