﻿using UnityEngine;

namespace WarKiwiCode.Game_Files.Scripts.Core.Attack
{
    [CreateAssetMenu(fileName = "New Enemy Weapon", menuName = "Enemy Weapon", order = 2)]
    public class EnemyWeapon : ScriptableObject
    {
        public float weaponMinRange;
        public float weaponMaxRange;
        public float weaponCooldown;
        public bool isAutomatic;
        public float rateOfFire;
        public float bulletsToFire;
        public bool isMelee;
        [Tooltip("How many strikes will the attack make")]
        public float meleeComboNumber;
        [Tooltip("Speed of each strike")]
        public float meleeComboSpeed;
        public int meleeDamage;
    }
}