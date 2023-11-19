using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class ProjectileBehaviour : MonoBehaviour
{
    public int damageAmount = 1;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Target"))
        {
            SphereBehaviour target = collision.gameObject.GetComponent<SphereBehaviour>();

            if (target != null)
            {
                target.TakeDamage(damageAmount);
            }

            Destroy(gameObject);
        }
    }
}
