using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gridspace : MonoBehaviour
{
   public Button button;
   public Text buttonText;
   public string playerSide;
   int randomNumber;

   public void SetSpace()
   {
      if (buttonText.text.Equals("X"))
      {
         playerSide = "O";
         buttonText.text = playerSide;
      }

      else if (buttonText.text.Equals("O"))
      {
         playerSide = "X";
         buttonText.text = playerSide;
      }

      else
      {

         randomNumber = Random.Range(0, 2);
         if (randomNumber < 1)
            playerSide = "X";
         else
            playerSide = "O";
         buttonText.text = playerSide;

      }
   }
}
