using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] private Projectile _projectile;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(_projectile);
        }
    }
}
