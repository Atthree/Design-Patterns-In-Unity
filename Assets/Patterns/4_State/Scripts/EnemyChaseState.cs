using UnityEngine;

public class EnemyChaseState : IState
{
    private EnemyController _enemy;

    public EnemyChaseState(EnemyController enemy)
    {
        _enemy = enemy;
    }

    public void Enter()
    {
        Debug.Log("<color=red>Düşman: SENİ GÖRDÜM! Kaçamazsın! (Chase State)</color>");
    }

    public void Update()
    {
        // Oyuncuya doğru basitçe hareket et
        Vector3 direction = (_enemy.player.position - _enemy.transform.position).normalized;
        _enemy.transform.position += direction * 3f * Time.deltaTime;

        float distance = Vector3.Distance(_enemy.transform.position, _enemy.player.position);

        // Eğer oyuncu 6 birimden uzağa kaçmayı başarırsa, tekrar Idle (Bekleme) durumuna dön!
        if (distance > 6f)
        {
            _enemy.TransitionToState(_enemy.IdleState);
        }
    }

    public void Exit()
    {
        Debug.Log("Düşman: Hedefi kaybettim. Sakinleşiyorum.");
    }
}