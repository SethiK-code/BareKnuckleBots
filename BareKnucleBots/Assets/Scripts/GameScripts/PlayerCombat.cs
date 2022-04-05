using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    private InputManager inputManager;

    public Attacks[] allAttacks; 
    public Attacks currentAttack;

    private bool recovery = false;

    // Start is called before the first frame update
    void Start()
    {
        inputManager = GetComponent<InputManager>();
        currentAttack = allAttacks[0];
    }

    // Update is called once per frame
    void Update()
    {
        if (inputManager.LightAtk() && !recovery)
        {
            currentAttack = allAttacks[0];

            if (!recovery)
            {
                Invoke("MeleeStart", currentAttack.TTE);
            }
        }

        if (inputManager.HeavyAtk() && !recovery)
        {
            currentAttack = allAttacks[1];

            if (!recovery)
            {
                Invoke("MeleeStart", currentAttack.TTE);
            }
        }

        if (inputManager.KickAtk() && !recovery)
        {
            currentAttack = allAttacks[2];

            if (!recovery)
            {
                Invoke("MeleeStart", currentAttack.TTE);
            }
        }
    }

    public void MeleeStart()
    {
        recovery = true; //Player has started his attack and will no longer be able to attack again until they are out of recovery
        currentAttack.AttackField.SetActive(true);
        Invoke("MeleeReset", currentAttack.TTE / 2);
    }

    public void MeleeReset()
    {
        currentAttack.AttackField.SetActive(false);
        recovery = false; //Player has started his attack and will no longer be able to attack again until they are out of recovery
    }

}

[System.Serializable]
public class Attacks
{
    [Header("Attack Stats")]
    [Tooltip("Name of the attack(Uppercut, Jab, Hook, etc).")]
    public string attackName;
    [Tooltip("Time it will take for the attack to execute (TTE = Time To Execute).")]
    public float TTE;
    [Tooltip("Amount of Damage the attack will do.")]
    public float attackDamage;
    [Tooltip("Space the attack will occupy.")]
    public GameObject AttackField;
}