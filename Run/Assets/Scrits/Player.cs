using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float velocity = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Изменения вызывающиеся за один кадр
    void Update()
    { // передвижение героя
        transform.position += new Vector3(velocity * Time.deltaTime, 0, 0);
    }
}
