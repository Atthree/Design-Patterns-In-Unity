using System;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    // Olayı (Event) tanımlıyoruz. Diğer scriptler bu olaya abone olacak.
    // Olay tetiklendiğinde int tipinde bir değer (kalan can) gönderecek.
    public static event Action<int> OnPlayerTookDamage;

    private int _currentHealth = 100;

    void Update()
    {
        // Test için Boşluk tuşuna basıldığında karaktere hasar verelim
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(20);
        }
    }

    public void TakeDamage(int damageAmount)
    {
        _currentHealth -= damageAmount;
        Debug.Log($"<color=red>Karakter {damageAmount} hasar aldı! Kalan Can: {_currentHealth}</color>");

        // Eğer bu olayı dinleyen (abone olan) en az bir script varsa, olayı tetikle!
        // Gönderdiğimiz _currentHealth değeri, dinleyen scriptlere otomatik gidecek.
        if (OnPlayerTookDamage != null)
        {
            OnPlayerTookDamage.Invoke(_currentHealth);
        }
    }
}