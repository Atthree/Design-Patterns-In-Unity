public interface ICommand
{
    void Execute(); // Komutu çalıştır
    void Undo();    // Komutu geri al
}