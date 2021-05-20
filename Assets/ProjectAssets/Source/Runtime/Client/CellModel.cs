using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace TicTacToe.Client.Runtime
{      
    
    public sealed class CellModel
    {

        
        public readonly Side PlayerSide = default;

        //constructor
        public CellModel(Side side)
        {
            PlayerSide = side;
        }   
    }
}
