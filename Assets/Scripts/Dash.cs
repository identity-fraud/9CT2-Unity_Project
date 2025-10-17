using UnityEngine;

public class Dash : MonoBehaviour
{
    private Vector3 facing = Vector3.right;
    private PlayerController Controller;
    private float time;

     void Start()
    {
        Controller = GetComponent<PlayerController>();
    }

    void Update()
    {
        time = Time.deltaTime - 1;

        if (Input.GetKey(KeyCode.Q) || Input.GetKey(KeyCode.E))
        {
            transform.Translate(facing * 40 * Time.deltaTime);
        }

        if (Controller.moving.x == 1)
        {
            facing = Vector3.right;
        }
        else if (Controller.moving.x == -1)
        {
            facing = Vector3.left;
        }
    }

}