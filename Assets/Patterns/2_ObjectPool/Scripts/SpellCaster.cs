using UnityEngine;

public class SpellCaster : MonoBehaviour
{
    void Update()
    {
        // Boşluk tuşuna basıldığında
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Instantiate YERİNE havuzdan obje talep ediyoruz
            GameObject spell = ObjectPool.Instance.GetObject();
            
            // Çıkan büyünün pozisyonunu karakterin pozisyonuna getir
            spell.transform.position = transform.position;
            spell.transform.rotation = Quaternion.identity;
        }
    }
}