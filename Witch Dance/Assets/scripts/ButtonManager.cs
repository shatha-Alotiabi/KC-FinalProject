using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
   public void ButtonMoveScene(string level1)
    {
        SceneManager.LoadScene(level1);
    }
      
    
}
