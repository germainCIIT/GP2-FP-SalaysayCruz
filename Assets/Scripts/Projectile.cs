using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _lifetime;

    private float startTime;

    private void OnEnable()
    {
        startTime = Time.time;
    }

    private void Update()
    {
        if (Time.time - startTime >= _lifetime)
        {
            ReturnToPool();
        }
    }

    void LateUpdate()
    {
        var projectileTransform = transform;
        var position = projectileTransform.position;
        position.y += _speed * Time.deltaTime;
        projectileTransform.position = position;
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider != null)
        {
            ReturnToPool();
        }
    }

    private void ReturnToPool()
    {
        this.gameObject.SetActive(false);
    }
}
