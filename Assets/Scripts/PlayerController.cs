using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private Rigidbody _rigidbody;
    [SerializeField]
    private float _speed;
    [SerializeField]
    private float _angle;

    void Start()
    {
    }

    void FixedUpdate()
    {
        WASDController();
    }

    private void WASDController()
    {
        Vector3 positionOffset = gameObject.transform.position;
        Vector3 rotateOffset = Vector3.zero;

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            positionOffset += Time.deltaTime * _speed * gameObject.transform.forward;
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            positionOffset -= Time.deltaTime * _speed * gameObject.transform.forward;
        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            rotateOffset = new Vector3(0f, -Time.deltaTime * _angle, 0f);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            rotateOffset = new Vector3(0f, Time.deltaTime * _angle, 0f);
        }

        gameObject.transform.position = positionOffset;
        gameObject.transform.Rotate(rotateOffset);
    }
}
