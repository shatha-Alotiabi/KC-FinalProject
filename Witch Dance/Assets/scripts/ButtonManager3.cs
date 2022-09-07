using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ButtonManager3 : MonoBehaviour
{

    public void ButtonMoveScene(string level2)
    {
        SceneManager.LoadScene(level2);
    }
}
