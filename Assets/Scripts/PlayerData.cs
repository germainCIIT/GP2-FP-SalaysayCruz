using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
    public float Health;
    public int Experience;
    public Shooter.Weapon Equipment;

    public PlayerData (float health, int experience, Shooter.Weapon equipment)
    {
        this.Health = health;
        this.Experience = experience;
        this.Equipment = equipment;
    }
}
