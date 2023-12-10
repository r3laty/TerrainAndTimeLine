using UnityEngine;

public class Changes : MonoBehaviour
{
    [SerializeField] private Rigidbody sphereRb;
    public void ChangeScale()
    {
        Vector3 newScale = new Vector3(3.27f, 4.5f, 7);
        Vector3 newPosition = new Vector3(transform.position.x, transform.position.y + 2f, transform.position.z);

        transform.localScale = newScale;
        transform.position = newPosition;
        AddForce();
    }
    public void DestroyObject()
    {
        Destroy(gameObject);
    }
    private void AddForce()
    {
        Vector3 vectorOfForce = new Vector3(20, 1, 20);

        sphereRb.AddForce(vectorOfForce * 2, ForceMode.Impulse);
    }
}
