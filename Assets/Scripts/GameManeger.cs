using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class GameManeger : MonoBehaviour
{
    public Sprite xImage;
    public Sprite defImage;
    int winner;
    public TextMeshProUGUI winertext;
    public Sprite oImage;
    int[] board = new int[9];
    public int currentPlayer = 1;
    readonly int[][] winLines = new int[][]
{
    new int[]{0,1,2},
    new int[]{3,4,5},
    new int[]{6,7,8},
    new int[]{0,3,6},
    new int[]{1,4,7},
    new int[]{2,5,8},
    new int[]{0,4,8},
    new int[]{2,4,6}


};

    public Button[] buttons;
    public void MakeMove(int index) 
    {
        board[index] = currentPlayer;
        if (currentPlayer == 1)
        {
            buttons[index].GetComponent<Image>().sprite = xImage;
        }
        else 
        {
            buttons[index].GetComponent<Image>().sprite = oImage;
        }
        buttons[index].interactable = false;
        winner = Check();
        currentPlayer *= -1;
        if (winner != 0)
        {
            if (winner == 1)
            {
                winertext.text = "Хрестики перемогли";
            }
            else if (winner == -1)
            {
                winertext.text = "Нулики перемогли";
            }
            else
            {
                winertext.text = "Нічия";

            }
            for (int i = 0; i < 9; i++)
                buttons[i].interactable = false;
            return;
        }
    }
    public int Check() 
    {
        foreach (var line in winLines)
        {
            int a = board[line[0]];
            if (a != 0 && a == board[line[1]] && a == board[line[2]])
            {
                return a;
            }
        }
        return 0;
    }
    public void InitBoard()
    {
        for (int i = 0; i < 9; i++)
        {
            board[i] = 0;
            int index = i;
            buttons[index].GetComponent<Image>().sprite = defImage;

            buttons[i].interactable = true;
        }
        currentPlayer = 1;
    }

    public void EndGame() 
    {
              
    }
}
