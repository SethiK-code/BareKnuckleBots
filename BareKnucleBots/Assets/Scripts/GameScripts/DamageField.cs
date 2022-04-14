using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageField : MonoBehaviour
{
    [SerializeField]
    private float damage;

    public void OnEnable()
    {
        damage = GetComponentInParent<PlayerCombat>().currentAttack.attackDamage;
    }
    public void OnCollisionEnter(Collision collision)
    {
        PlayerHealth player = collision.gameObject.GetComponent<PlayerHealth>();
        //Debug.Log(collision.gameObject.name);

        if (player != null)
        {
            player.TakeDamage(damage);
        }
    }

    
}
