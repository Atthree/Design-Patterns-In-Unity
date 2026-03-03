using UnityEngine;

public class PlayerCaster : MonoBehaviour
{
    public SpellFactory factory;

    void Update()
    {
        // 1 tuşuna basıldığında Ateş iste
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            ISpell spell = factory.GetSpell(SpellType.Fire);
            spell?.Cast(transform.position); 
        }

        // 2 tuşuna basıldığında Buz iste
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            ISpell spell = factory.GetSpell(SpellType.Ice);
            spell?.Cast(transform.position);
        }
    }
}