using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolManager : MonoBehaviour
{
    #region Singleton
    public static PoolManager Instance => _instance;
    private static PoolManager _instance;

    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
        }

        else
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this);
    }

    #endregion

    [SerializeField] private Projectile _objectToPool;
    [SerializeField] private int amountToPool;

    private List<Projectile> _pooledObjects;

    private void Start()
    {
        _pooledObjects = new List<Projectile>();
        for (int i = 0; i < amountToPool; i++)
        {
            var projectile = Instantiate(_objectToPool);
            projectile.gameObject.SetActive(false);
            _pooledObjects.Add(projectile);
        }
    }

    public GameObject GetPooledObject()
    {
        foreach (var projectile in _pooledObjects)
        {
            if (projectile.gameObject.activeInHierarchy) continue;
            return projectile.gameObject;
        }

        var backupProjectile = Instantiate(_objectToPool);
        var gameProjectile = backupProjectile.gameObject;
        gameProjectile.SetActive(false);
        return gameProjectile;
    }
}
