using System.Collections.Generic;
using UnityEngine;

public class CommandInvoker : MonoBehaviour
{
    // Komut geçmişini tutacağımız yığın
    private Stack<ICommand> _commandHistory = new Stack<ICommand>();

    public void ExecuteCommand(ICommand command)
    {
        command.Execute();          // Komutu çalıştır
        _commandHistory.Push(command); // Geçmişe (Yığına) kaydet
    }

    public void UndoLastCommand()
    {
        // Eğer geçmişte bir hamle varsa
        if (_commandHistory.Count > 0)
        {
            ICommand lastCommand = _commandHistory.Pop(); // Son hamleyi yığından çıkar
            lastCommand.Undo();                           // Hamleyi geri al
        }
        else
        {
            Debug.Log("<color=yellow>Geri alınacak hamle kalmadı!</color>");
        }
    }
}