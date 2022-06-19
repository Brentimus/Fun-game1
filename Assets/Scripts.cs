using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scripts : MonoBehaviour
{
    public void On()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
