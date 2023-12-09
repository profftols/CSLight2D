using UnityEngine;

[RequireComponent(typeof(Health))]
[RequireComponent(typeof(Attacker))]
public class Enemy : MonoBehaviour
{
    private Health _health;
    private Attacker _attacker;

    private void Start()
    {
        _health = GetComponent<Health>();
        _attacker = GetComponent<Attacker>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.TryGetComponent(out Player player))
        {
            _attacker.Attack(player.GetComponent<Health>());
        }
    }
}
