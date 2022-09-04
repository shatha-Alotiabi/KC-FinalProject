using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager1 : MonoBehaviour
{
    public void ButtonMoveScene(string SampleScene)
    {
        SceneManager.LoadScene(SampleScene);
    }

}
