using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnClickRandom : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Random rnd = new Random
        int RandomValue = rnd.Next(100);
        
        Text ButtonText;

        if(RandomValue>=50)
        {
            ButtonText = "X";
        }
        else
        {
            ButtonText = "O";
        }
         
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
