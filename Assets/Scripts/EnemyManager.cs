using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    [SerializeField] private EnemyData[] _enemyTypes;
    [SerializeField] private Enemy _enemy;

    private int _enemyIndex;

    public void SpawnEnemy(bool random = false)
    {
        if (!random)
        {
            // Loops the enemy index
            if (_enemyIndex > _enemyTypes.Length - 1)
            {
                _enemyIndex = 0;
            }
        }
        else
        {
            _enemyIndex = Random.Range(0, _enemyTypes.Length);
        }

        var type = _enemyTypes[_enemyIndex];
        _enemy.Init(type);
        _enemyIndex++;
    }
}
