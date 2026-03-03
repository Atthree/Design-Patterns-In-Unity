using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private IState _currentState;

    // Durumların referansları (Sürekli yeni obje üretmemek için bir kere yaratıyoruz)
    public EnemyIdleState IdleState { get; private set; }
    public EnemyChaseState ChaseState { get; private set; }

    // Test için oyuncu objesi (Sahnede referans vereceğiz)
    public Transform player;

    void Start()
    {
        // Durumları başlatıyoruz. 'this' ile bu kontrolcüyü (yani düşmanı) durumlara gönderiyoruz.
        IdleState = new EnemyIdleState(this);
        ChaseState = new EnemyChaseState(this);

        // Başlangıç durumu olarak Idle'ı seçiyoruz.
        TransitionToState(IdleState);
    }

    void Update()
    {
        // Sadece aktif olan durumun Update'ini çalıştır! Kod ne kadar temiz gördün mü?
        if (_currentState != null)
        {
            _currentState.Update();
        }
    }

    // Durum değiştirmek için kullanacağımız fonksiyon
    public void TransitionToState(IState newState)
    {
        // Eğer zaten bir durumdaysak, önce ondan temizce çıkış yap
        if (_currentState != null)
        {
            _currentState.Exit();
        }

        // Yeni duruma geç ve giriş fonksiyonunu çalıştır
        _currentState = newState;
        _currentState.Enter();
    }
}