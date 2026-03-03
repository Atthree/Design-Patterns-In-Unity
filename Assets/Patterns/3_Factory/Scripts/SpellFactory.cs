using UnityEngine;

public enum SpellType { Fire, Ice }

public class SpellFactory : MonoBehaviour
{
    [Header("Büyü Prefabları")]
    public GameObject firePrefab;
    public GameObject icePrefab;

    // Sadece ISpell döndüren sihirli fonksiyonumuz
    public ISpell GetSpell(SpellType type)
    {
        GameObject spellObj = null;

        // İstemci (Oyuncu) sadece tipi söyler, üretimi fabrika yapar
        switch (type)
        {
            case SpellType.Fire:
                spellObj = Instantiate(firePrefab);
                break;
            case SpellType.Ice:
                spellObj = Instantiate(icePrefab);
                break;
        }

        // Objeyi ürettikten sonra üzerindeki ISpell bileşenini teslim ediyoruz
        if (spellObj != null)
        {
            return spellObj.GetComponent<ISpell>();
        }

        return null;
    }
}