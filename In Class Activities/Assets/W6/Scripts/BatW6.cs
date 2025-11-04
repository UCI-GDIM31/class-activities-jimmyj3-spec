using UnityEngine;

// Write the BatW6 class here.
public class BatW6 : MonoBehaviour
{
   [SerializeField] private float _speed = 3f;
    private Transform _cat;
    private bool _isChasing = false;

    private void Update()
    {
        if (_isChasing && _cat != null)
        {
            Vector3 direction = (_cat.position - transform.position).normalized;
            transform.position += direction * _speed * Time.deltaTime;
        }
    }

    public void StartChasing()
    {
        if (_cat == null)
            _cat = GameObject.FindGameObjectWithTag("Player").transform;

        _isChasing = true;
    }

    public void StopChasing()
    {
        _isChasing = false;
    }
}
