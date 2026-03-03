using UnityEngine;

public class IceSpell : MonoBehaviour, ISpell
{
    public void Cast(Vector3 position)
    {
        transform.position = position;
        Debug.Log("<color=cyan>Buz Büyüsü fırlatıldı! Düşman donduruldu.</color>");
    }
}