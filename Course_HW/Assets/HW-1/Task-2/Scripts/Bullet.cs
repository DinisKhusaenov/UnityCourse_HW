using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float _speed;

    public float Speed
    {
        get { return _speed; }
        set
        {
            if (value > 0)
            {
                _speed = value;
            }
        }
    }

    private void Update()
    {
        transform.Translate(Vector3.forward * _speed * Time.deltaTime);
    }
}