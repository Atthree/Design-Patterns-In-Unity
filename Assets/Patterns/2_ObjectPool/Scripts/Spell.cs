using UnityEngine;

public class Spell : MonoBehaviour
{
    public float speed = 10f;
    public float lifeTime = 2f; // Büyü 2 saniye sonra kaybolsun

    void OnEnable()
    {
        // Obje aktif olduğunda (havuzdan çıkınca) geri sayımı başlat
        Invoke("Deactivate", lifeTime);
    }

    void Update()
    {
        // Universal 2D'de yukarı doğru (veya sağa doğru) basit bir hareket
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }

    void Deactivate()
    {
        // İŞTE BÜTÜN SIR BURADA: Destroy(gameObject) YERİNE havuza iade ediyoruz!
        ObjectPool.Instance.ReturnObject(gameObject);
    }

    void OnDisable()
    {
        // Obje deaktif olduğunda olası hataları önlemek için sayacı iptal et
        CancelInvoke(); 
    }
}