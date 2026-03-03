using UnityEngine;

public class SpreadShotStrategy : IWeaponStrategy
{
    public void Fire(Transform firePoint)
    {
        Debug.Log("<color=red>[Üçlü Saçma] Geniş açılı ateş edildi!</color>");

        // 3 farklı yöne kırmızı çizgiler çizerek saçma etkisini görselleştiriyoruz
        Debug.DrawRay(firePoint.position, firePoint.up * 5f, Color.red, 1f); // İleri
        Debug.DrawRay(firePoint.position, (firePoint.up + firePoint.right).normalized * 5f, Color.red, 1f); // Sağ Çapraz
        Debug.DrawRay(firePoint.position, (firePoint.up - firePoint.right).normalized * 5f, Color.red, 1f); // Sol Çapraz
    }
}