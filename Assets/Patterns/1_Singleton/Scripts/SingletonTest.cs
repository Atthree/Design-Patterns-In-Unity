using UnityEngine;

public class SingletonTest : MonoBehaviour
{
    void Start()
    {
        // Dikkat et: Sahnedeki AudioManager'ı FindGameObject ile aramadık!
        // Referans bağlamak (sürükle-bırak) zorunda kalmadık!
        // Direkt olarak Class ismi üzerinden her şeye ulaştık.
        AudioManager.Instance.PlaySound("Patlama_Sesi");
        AudioManager.Instance.PlaySound("Arka_Plan_Muzigi");
    }
}