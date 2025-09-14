using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TicTacToe : MonoBehaviour
{
    public Button[] buttons;
    private string currentPlayer = "X";

    void Start()
    {
        foreach (Button btn in buttons)
        {
            btn.onClick.AddListener(() => OnCellClicked(btn));
        }
    }

    void OnCellClicked(Button btn)
    {
        TextMeshProUGUI btnText = btn.GetComponentInChildren<TextMeshProUGUI>();

        if (btnText.text == "")
        {
            btnText.text = currentPlayer;
            btn.interactable = false;

            if (CheckWin())
            {
                Debug.Log(currentPlayer + " переміг!");
                ResetBoard();
                return;
            }

            currentPlayer = (currentPlayer == "X") ? "O" : "X";
        }
    }

    bool CheckWin()
    {
        int[,] winPatterns = new int[,]
        {
            {0,1,2}, {3,4,5}, {6,7,8},
            {0,3,6}, {1,4,7}, {2,5,8},
            {0,4,8}, {2,4,6}
        };

        for (int i = 0; i < winPatterns.GetLength(0); i++)
        {
            string a = buttons[winPatterns[i, 0]].GetComponentInChildren<TextMeshProUGUI>().text;
            string b = buttons[winPatterns[i, 1]].GetComponentInChildren<TextMeshProUGUI>().text;
            string c = buttons[winPatterns[i, 2]].GetComponentInChildren<TextMeshProUGUI>().text;

            if (a != "" && a == b && b == c)
                return true;
        }

        return false;
    }

    void ResetBoard()
    {
        foreach (Button btn in buttons)
        {
            btn.interactable = true;
            btn.GetComponentInChildren<TextMeshProUGUI>().text = "";
        }
        currentPlayer = "X";
    }
}