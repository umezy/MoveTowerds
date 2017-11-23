using UnityEngine;

public class Cube : MonoBehaviour
{
    float speed = 1000;

    Transform t_sphere;
    Vector3 v_sphere;
    Vector3 target;


    // Use this for initialization
    void Start()
    {
        t_sphere = GameObject.Find("Sphere").GetComponent<Transform>();

    }

    void Update()
    {

        v_sphere = t_sphere.position;
        target.Set(v_sphere.x +3, v_sphere.y, 0);
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);
    
    }

}
