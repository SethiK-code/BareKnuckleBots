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
    public void OnTriggerEnter(Collider collider)
    {
        PlayerHealth player = collider.GetComponent<PlayerHealth>();
        Debug.Log(collider.name);

        if (player != null)
        {
            player.TakeDamage(damage);
        }
    }
}
