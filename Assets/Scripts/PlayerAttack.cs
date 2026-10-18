using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAttack : MonoBehaviour
{
    public Transform attackPoint;
    public float attackRange = 1.8f;
    public LayerMask enemyLayer;
    public int attackDamage = 1;

    void Update()
    {
        bool pressZ = Keyboard.current != null && Keyboard.current.zKey.wasPressedThisFrame;
        bool clickMouse = Mouse.current != null && Mouse.current.leftButton.wasPressedThisFrame;

        if (pressZ || clickMouse)
        {
            Attack();
        }
    }

    void Attack()
    {
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position,attackRange,enemyLayer);

        foreach (Collider2D enemy in hitEnemies)
        {
            EnemyHealth enemyHealth = enemy.GetComponentInParent<EnemyHealth>();

            if (enemyHealth != null)
            {
                enemyHealth.TakeDamage(attackDamage);
            }
        }
    }

}
