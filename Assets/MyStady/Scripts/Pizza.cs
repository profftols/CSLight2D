using UnityEngine;

public class Pizza : MonoBehaviour
{
    private float _heal = 3f;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.TryGetComponent(out Player player))
        {
            player.GetComponent<Health>().ToHeal(_heal);
            Destroy(gameObject);
        }
    }
}
