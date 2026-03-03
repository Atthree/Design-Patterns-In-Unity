using UnityEngine;

public class InputHandler : MonoBehaviour
{
    public Transform player;         // Hareket edecek obje
    public CommandInvoker invoker;   // Komutları yönetecek sistem
    public float moveDistance = 1f;

    void Update()
    {
        // W tuşu ile Yukarı (Universal 2D'de Y ekseni)
        if (Input.GetKeyDown(KeyCode.W))
        {
            ICommand moveUp = new MoveCommand(player, Vector3.up, moveDistance);
            invoker.ExecuteCommand(moveUp);
        }
        // S tuşu ile Aşağı
        else if (Input.GetKeyDown(KeyCode.S))
        {
            ICommand moveDown = new MoveCommand(player, Vector3.down, moveDistance);
            invoker.ExecuteCommand(moveDown);
        }
        // D tuşu ile Sağa
        else if (Input.GetKeyDown(KeyCode.D))
        {
            ICommand moveRight = new MoveCommand(player, Vector3.right, moveDistance);
            invoker.ExecuteCommand(moveRight);
        }
        // A tuşu ile Sola
        else if (Input.GetKeyDown(KeyCode.A))
        {
            ICommand moveLeft = new MoveCommand(player, Vector3.left, moveDistance);
            invoker.ExecuteCommand(moveLeft);
        }

        // Z TUŞU İLE GERİ ALMA (Zamanı Geri Sar!)
        if (Input.GetKeyDown(KeyCode.Z))
        {
            invoker.UndoLastCommand();
        }
    }
}