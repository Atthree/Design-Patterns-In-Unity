using UnityEngine;

public interface IWeaponStrategy
{
    // Her strateji nasıl ateş edileceğini (Fire) bilmek zorundadır.
    // firePoint: Merminin çıkacağı namlu pozisyonu
    void Fire(Transform firePoint);
}