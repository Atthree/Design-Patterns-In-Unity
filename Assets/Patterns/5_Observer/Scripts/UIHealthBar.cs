using UnityEngine;

public class UIHealthBar : MonoBehaviour
{
    // Obje aktifleştiğinde olaya ABONE OL (Dinlemeye başla)
    private void OnEnable()
    {
        PlayerHealth.OnPlayerTookDamage += UpdateHealthUI;
    }

    // Obje kapanırsa veya silinirse abonelikten ÇIK (Memory Leak / Hafıza Sızıntısını önlemek için çok kritik!)
    private void OnDisable()
    {
        PlayerHealth.OnPlayerTookDamage -= UpdateHealthUI;
    }

    // Olay tetiklendiğinde çalışacak fonksiyon (Parametre tipi Action ile uyuşmalı)
    private void UpdateHealthUI(int currentHealth)
    {
        Debug.Log($"[UI Sistemi] Ekranda can barı güncellendi. Yeni Can: {currentHealth}");
    }
}