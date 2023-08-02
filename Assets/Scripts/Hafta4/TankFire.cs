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
        EnemyCount = GameObject.FindGameObjectsWithTag("Enemy").Length; // sahnede kaç tane düþman var olduðunu öðrenme
    }
    void Update()
    {
        EnemyCountText.text = "Kalan Düþman Sayýsý: " + EnemyCount ; //kalan düþman sayýsý güncel olarak ekranda gösterme

        if (Input.GetKeyDown(KeyCode.Space)) //Ateþ etme 
        {
            Instantiate(fireSmoke, SmokePosition.transform);
            
            
            SoundManager.Instance.PlayEffectSound(SoundManager.Instance.FireSound); // ateþ etme sesi çýkmasý

            if (Physics.Raycast(Namlu.transform.position, transform.forward, out hit, Mathf.Infinity) && hit.collider.gameObject.tag == "Enemy")
            {
                SoundManager.Instance.PlayEffectSound(SoundManager.Instance.DieSound); //ölme sesi çýkmasý

                EnemyCount--; //Düþman sayýsýný güncelleme (azaltma)
                
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
            
            Destroy(EnemyCountText); // en alttaki kalan düþman sayýsý yazýsýný siliyor
            WinCanvas.SetActive(true);  //Düþman sayýsý sýfýrlandýðýnda kazanma ekraný çýkarma
            SoundManager.Instance.PlayEffectSound(SoundManager.Instance.WinSound); // kazanma sesi çýkarma
            isGameOver= true;

        }
    }
}



