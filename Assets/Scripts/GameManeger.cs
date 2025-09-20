using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManeger : MonoBehaviour
{
    public Sprite xImage;
    public Sprite oImage;
    public bool xTurn = true;

    public Button[] buttons;
    public void MakeMove(int index) 
    {
        if (xTurn == true)
        {
            buttons[index].GetComponent<Image>().sprite = xImage;
            xTurn = false;
        }
        else 
        {
            buttons[index].GetComponent<Image>().sprite = oImage;
            xTurn=true;  
        }
        Check();
    }
    public void Check() 
    {
        if (true) 
        {
            
        }
    }
    public void EndGame() 
    {
              
    }
}
