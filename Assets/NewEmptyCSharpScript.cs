using UnityEngine;

public class Launcher : MonoBehaviour
{
    public float speed = 10f;
    void Start()
    {
        GetComponent<Rigidbody>().AddForce(transform.forward * speed, ForceMode.Impulse);
    }
}