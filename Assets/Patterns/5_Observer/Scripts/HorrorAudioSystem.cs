using UnityEngine;

public class HorrorAudioSystem : MonoBehaviour
{
    private void OnEnable()
    {
        PlayerHealth.OnPlayerTookDamage += PlayDamageSound;
    }

    private void OnDisable()
    {
        PlayerHealth.OnPlayerTookDamage -= PlayDamageSound;
    }

    private void PlayDamageSound(int currentHealth)
    {
        // Can 50'nin altına düştüyse daha korkunç bir ses çalabiliriz
        if (currentHealth <= 50)
        {
            Debug.Log("[Ses Sistemi] Kritik hasar sesi ve kalp atışı efekti çalıyor!");
        }
        else
        {
            Debug.Log("[Ses Sistemi] Normal hasar sesi çalıyor.");
        }
    }
}