using UnityEngine;

public abstract class ObjectsToLift : MonoBehaviour
{
    protected string _objectLabel;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Player player))
        {
            player.PickUpObgect(_objectLabel);
            Destroy(gameObject);
        }
    }
}
