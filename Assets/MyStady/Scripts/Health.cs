using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float _health;
    
    public void TakeDamage(float enemyDamage)
    {
        if ((_health -= enemyDamage) <= 0)
        {
            Destroy(gameObject);
        }
    }
    
    public void ToHeal(float heal)
    {
        _health += heal;
    }
}
