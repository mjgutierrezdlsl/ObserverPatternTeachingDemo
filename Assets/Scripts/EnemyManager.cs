using System;
using UnityEngine;
using UnityEngine.Events;
using Random = UnityEngine.Random;

public class EnemyManager : MonoBehaviour
{
    [SerializeField] EnemyData[] _enemyTypes;
    [SerializeField] Enemy _enemy;

    public void SpawnEnemy()
    {
        var type = _enemyTypes[Random.Range(0, _enemyTypes.Length)];
        _enemy.Init(type);
    }
}
