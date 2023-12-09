using UnityEngine;

[RequireComponent(typeof(Health))]
[RequireComponent(typeof(Attacker))]
public class Player : MonoBehaviour
{
    private Health _health;
    private Attacker _attacker;
    
    private void Awake()
    {
        _health = GetComponent<Health>();
        _attacker = GetComponent<Attacker>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.TryGetComponent(out Enemy enemy))
        {
            _attacker.Attack(enemy.GetComponent<Health>());
        }
    }
}
