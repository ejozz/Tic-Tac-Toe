using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyOnLoad : MonoBehaviour
{
    
    [SerializeField] GameObject WinPopup;

    void Awake()
    {
       DontDestroyOnLoad(WinPopup);
    }
}
