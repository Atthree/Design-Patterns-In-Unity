using UnityEngine;

// AudioManager sınıfını kendi yazdığımız Singleton'dan türetiyoruz!
// Artık AudioManager otomatik olarak bir Singleton oldu.
public class AudioManager : Singleton<AudioManager>
{
    // Oyunun herhangi bir yerinden çağırabileceğimiz bir fonksiyon
    public void PlaySound(string soundName)
    {
        // Gerçek bir projede burada AudioClip çaldırma işlemleri olurdu.
        // Biz mantığı anlamak için Console'a yazdırıyoruz.
        Debug.Log($"[Ses Sistemi] Çalınan ses: {soundName}");
    }
}