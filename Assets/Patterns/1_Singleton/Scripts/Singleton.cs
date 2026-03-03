using UnityEngine;

// <T> ifadesi bunun "Generic" bir sınıf olduğunu belirtir.
// where T : Component kısmı, T'nin bir Unity objesi (MonoBehaviour) olmasını zorunlu kılar.
public class Singleton<T> : MonoBehaviour where T : Component
{
    private static T _instance;

    public static T Instance
    {
        get
        {
            if (_instance == null)
            {
                // Sahnede bu objeden var mı diye kontrol et
                _instance = FindFirstObjectByType<T>();

                // Sahnede yoksa, sıfırdan bir tane yarat ve ekle
                if (_instance == null)
                {
                    GameObject obj = new GameObject();
                    obj.name = typeof(T).Name;
                    _instance = obj.AddComponent<T>();
                }
            }
            return _instance;
        }
    }

    protected virtual void Awake()
    {
        // Eğer sahnede zaten bir instance varsa ve bu o değilse, kendini yok et (Çoğalmayı engelle)
        if (_instance == null)
        {
            _instance = this as T;
            DontDestroyOnLoad(gameObject); // Sahne değişse bile silinmesin
        }
        else if (_instance != this as T)
        {
            Destroy(gameObject);
        }
    }
}