﻿using System;
using System.Collections.Generic;
using DG.Tweening;
using MEC;
using UnityEngine;
using WarKiwiCode.Game_Files.Scripts.Projectiles;
using Thinksquirrel.CShake;

namespace WarKiwiCode.Game_Files.Scripts.Managers.Player
{
    public class PlayerHealth : MonoBehaviour
    {
        

        // Start is called before the first frame update
        void Start()
        {
            
            
        }

        // Update is called once per frame
        void Update()
        {
        
        }
        
        public void TakeDamage(int damage)
        {
            // Take damage
            CameraShake.ShakeAll();
            print(gameObject.name + " took damage.");
        }

        private void OnCollisionEnter2D(Collision2D other)
        {
            if (other.gameObject.GetComponent<BulletData>() != null)
            {
                int damage = other.gameObject.GetComponent<BulletData>().GetDamage();

                // Collided with a bullet
                TakeDamage(damage);
                Timing.RunCoroutine(DisableBullet(other.gameObject).CancelWith(gameObject));
            }
        }

        private static IEnumerator<float> DisableBullet(GameObject bullet)
        {
            yield return Timing.WaitForSeconds(0.05f);
            bullet.SetActive(false);
        }
    }
}
