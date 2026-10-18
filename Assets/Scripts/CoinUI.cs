using UnityEngine;
using TMPro;

public class CoinUI : MonoBehaviour
{
    [Header("Contador de monedas")]

    public TMP_Text coinText;

    // Se ejecuta una vez cuando comienza el juego.
    private void Start()
    {
        Coin.ResetCoins();

        // Actualiza el texto para mostrar el contador inicial.
        UpdateCoinText();
    }


    private void Update()
    {

        UpdateCoinText();
    }

    // Muestra en pantalla la cantidad actual de monedas recolectadas.
    private void UpdateCoinText()
    {

        if (coinText != null)
        {
            coinText.text = "Monedas: " + Coin.CoinsCollected;
        }
    }
}
