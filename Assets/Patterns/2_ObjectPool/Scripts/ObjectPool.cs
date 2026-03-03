using System.Collections.Generic;
using UnityEngine;

// Dikkat: Kendi yazdığımız Singleton sınıfından türetiyoruz!
public class ObjectPool : Singleton<ObjectPool>
{
    [Tooltip("Havuzda tutulacak büyü veya mermi objesi")]
    public GameObject prefabToPool;
    
    [Tooltip("Oyun başında kaç tane üretilip hazır bekletilecek?")]
    public int poolSize = 20;

    // Objeleri sıraya dizmek ve yönetmek için Queue (Kuyruk) kullanmak çok verimlidir.
    private Queue<GameObject> _poolQueue;

    protected override void Awake()
    {
        base.Awake(); // Singleton'ın kendi Awake işlemlerini bozmamak için
        _poolQueue = new Queue<GameObject>();

        // Oyun başlar başlamaz objeleri üret ve görünmez yapıp havuza at
        for (int i = 0; i < poolSize; i++)
        {
            GameObject obj = Instantiate(prefabToPool);
            obj.SetActive(false); // Görünmez yap
            _poolQueue.Enqueue(obj); // Kuyruğa ekle
        }
    }

    // İhtiyacımız olduğunda havuzdan obje çekeceğimiz fonksiyon
    public GameObject GetObject()
    {
        if (_poolQueue.Count > 0)
        {
            GameObject obj = _poolQueue.Dequeue(); // Kuyruktan çıkar
            obj.SetActive(true); // Görünür yap
            return obj;
        }
        
        // Eğer havuzda obje kalmadıysa (çok hızlı ateş edildiyse) acil durum olarak yeni üret
        GameObject newObj = Instantiate(prefabToPool);
        return newObj;
    }

    // İşimiz biten objeyi silmek (Destroy) yerine havuza geri göndereceğimiz fonksiyon
    public void ReturnObject(GameObject obj)
    {
        obj.SetActive(false); // Tekrar görünmez yap
        _poolQueue.Enqueue(obj); // Kuyruğun sonuna geri ekle
    }
}