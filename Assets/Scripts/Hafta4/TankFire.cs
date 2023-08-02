using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class TankFire : MonoBehaviour
{
    RaycastHit hit;
    public GameObject Namlu;

    public TextMeshProUGUI EnemyCountText;
    private int EnemyCount;

    public GameObject WinCanvas;

    private void Start()
    {
        WinCanvas.SetActive(false);
        EnemyCount = GameObject.FindGameObjectsWithTag("Enemy").Length;
    }
    void Update()
    {
        EnemyCountText.text = "Kalan Düþman Sayýsý: " + EnemyCount ;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            SoundManager.Instance.PlayEffectSound(SoundManager.Instance.FireSound);

            if (Physics.Raycast(Namlu.transform.position, transform.forward, out hit, Mathf.Infinity) && hit.collider.gameObject.tag == "Enemy")
            {
                EnemyCount--;
                Destroy(hit.collider.gameObject);
            }
            
        }

        if(EnemyCount== 0)
        {
            Destroy(EnemyCountText);
            WinCanvas.SetActive(true);
        }
    }
}



