using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MortesNumber : MonoBehaviour
{
    public TextMeshPro mortesText;
    [Min(0)] public static int quant_Mortes = 0;
    
    void Start()
    {
        if (quant_Mortes == 0)
        {
            mortesText.text = $"Parabéns! Você finalizou o jogo sem morrer nenhuma vez!";
        }
         else if (quant_Mortes >= 0 && quant_Mortes <= 10)
        {
            mortesText.text = $"Parabéns! Você finalizou o jogo e morreu {quant_Mortes} vezes!";
        }
        else if (quant_Mortes <= 64)
        {
            mortesText.text = $"Você finalizou o jogo morrendo {quant_Mortes} vezes. Você é horível!";
        }
        else if (quant_Mortes <= 8000)
        {
            mortesText.text = $"Você morreu {quant_Mortes} vezes. Jogue outra coisa";
        }
        else
        {
            mortesText.text = $"Impossível... Suas mortes são mais que 8000!";
        }
        
    }
}
