using UnityEngine;

public class Coin : MonoBehaviour
{
    // Contador compartido que almacena el total de monedas recolectadas.
    public static int CoinsCollected = 0;

    // Reinicia el contador al comenzar una nueva partida.
    public static void ResetCoins()
    {
        CoinsCollected = 0;
    }

    // actualiza el contador y elimina la moneda de la escena.
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            CoinsCollected++;

            Destroy(gameObject);
        }
    }
}
