// ISpell.cs
using UnityEngine;

// Bu bir sınıf değil, Interface'dir. 
// "Bu interface'i alan her script, Cast() fonksiyonunu içermek zorundadır" kuralını koyar.
public interface ISpell
{
    void Cast(Vector3 position);
}