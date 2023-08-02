using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
   public void RestartScene()
    {
        SceneManager.LoadScene(1); // kazanma ekranýndaki butonun sahneyi yeniden baþlatmasý
        
    }
}
