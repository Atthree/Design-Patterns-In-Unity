using UnityEngine;

public class WeaponController : MonoBehaviour
{
    // Geçerli silah stratejisini tutacağımız referans
    private IWeaponStrategy _currentStrategy;

    public Transform firePoint; // Namlu ucu

    void Start()
    {
        // Oyun başladığında varsayılan olarak Tekli Atış stratejisini ata
        SetWeaponStrategy(new SingleShotStrategy());
    }

    void Update()
    {
        // Boşluk tuşu ile ateş et
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // O anki strateji neyse onun Fire fonksiyonu çalışır
            _currentStrategy?.Fire(firePoint);
        }

        // 1 Tuşu -> Tekli Atışa Geç
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SetWeaponStrategy(new SingleShotStrategy());
            Debug.Log("Silah Modu Değişti: TEKLİ ATIŞ");
        }

        // 2 Tuşu -> Üçlü Saçmaya Geç
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SetWeaponStrategy(new SpreadShotStrategy());
            Debug.Log("Silah Modu Değişti: ÜÇLÜ SAÇMA");
        }
    }

    // Dışarıdan veya bir power-up alındığında stratejiyi değiştirecek fonksiyon
    public void SetWeaponStrategy(IWeaponStrategy newStrategy)
    {
        _currentStrategy = newStrategy;
    }
}