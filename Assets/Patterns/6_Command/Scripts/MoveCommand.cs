using UnityEngine;

public class MoveCommand : ICommand
{
    private Transform _playerTransform;
    private Vector3 _direction;
    private float _distance;

    // Constructor (Sınıf yaratılırken gerekli bilgileri alıyoruz)
    public MoveCommand(Transform player, Vector3 direction, float distance)
    {
        _playerTransform = player;
        _direction = direction;
        _distance = distance;
    }

    public void Execute()
    {
        // Karakteri belirtilen yönde hareket ettir
        _playerTransform.position += _direction * _distance;
        Debug.Log($"Oyuncu hareket etti: {_direction}");
    }

    public void Undo()
    {
        // Hareketi tam tersine çevirerek geri al!
        _playerTransform.position -= _direction * _distance;
        Debug.Log("Hareket geri alındı (Undo)!");
    }
}