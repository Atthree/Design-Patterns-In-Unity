using UnityEngine;

// MonoBehaviour'dan ve ISpell interface'inden kalıtım alıyor
public class FireSpell : MonoBehaviour, ISpell
{
    public void Cast(Vector3 position)
    {
        transform.position = position;
        Debug.Log("<color=red>Ateş Büyüsü fırlatıldı! Düşman yanıyor.</color>");
        // Burada objeye ileri doğru bir fizik gücü (Rigidbody) verilebilirdi.
    }
}