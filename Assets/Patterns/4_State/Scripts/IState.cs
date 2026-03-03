public interface IState
{
    void Enter();   // Duruma girildiğinde bir kez çalışır (Örn: Animasyonu başlat)
    void Update();  // Durum aktifken her karede çalışır (Örn: Oyuncuya doğru yürü)
    void Exit();    // Durumdan çıkarken bir kez çalışır (Örn: Hızı sıfırla)
}