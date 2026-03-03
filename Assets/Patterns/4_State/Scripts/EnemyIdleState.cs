using UnityEngine;

public class EnemyIdleState : IState
{
    private EnemyController _enemy;

    // Constructor (Yapıcı Metot) - Düşmanı tanımak için
    public EnemyIdleState(EnemyController enemy)
    {
        _enemy = enemy;
    }

    public void Enter()
    {
        Debug.Log("<color=green>Düşman: Sakince etrafa bakınıyorum... (Idle State)</color>");
    }

    public void Update()
    {
        // Oyuncuyla aradaki mesafeyi ölç (Gerçek bir oyunda görüş açısı (Raycast) falan olurdu)
        float distance = Vector3.Distance(_enemy.transform.position, _enemy.player.position);

        // Eğer oyuncu 5 birimden yakındaysa, Chase (Kovalama) durumuna geç!
        if (distance < 5f)
        {
            _enemy.TransitionToState(_enemy.ChaseState);
        }
    }

    public void Exit()
    {
        Debug.Log("Düşman: Bir ses duydum! Devriyeyi bırakıyorum.");
    }
}