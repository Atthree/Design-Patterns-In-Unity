using UnityEngine;

public class SingleShotStrategy : IWeaponStrategy
{
    public void Fire(Transform firePoint)
    {
        Debug.Log("<color=yellow>[Tekli Atış] Standart mermi fırlatıldı!</color>");
        
        // Sahnede görsel olarak test edebilmek için namludan ileriye sarı bir çizgi çiziyoruz
        Debug.DrawRay(firePoint.position, firePoint.up * 5f, Color.yellow, 1f);
    }
}