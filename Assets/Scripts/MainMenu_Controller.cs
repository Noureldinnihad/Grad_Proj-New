using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu_Controller : MonoBehaviour
{
   
   public void start_BT()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
