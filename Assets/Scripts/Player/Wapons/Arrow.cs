using UnityEngine;

public abstract class Arrow : MonoBehaviour
{
    [SerializeField] private int _damage;
    [SerializeField] private float _speed;   

    private void Update()
    {
        transform.Translate(Vector2.right * _speed * Time.deltaTime, Space.World);
    }
}
