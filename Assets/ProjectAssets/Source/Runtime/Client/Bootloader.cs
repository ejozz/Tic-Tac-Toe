using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bootloader : MonoBehaviour
{
    void Start()
    {
        SceneManager.LoadScene("Win");
        SceneManager.LoadScene("GameField",LoadSceneMode.Additive);
    }
}
