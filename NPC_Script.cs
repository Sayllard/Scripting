using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Script : MonoBehaviour
{
    // —оздет переменные здоровье, скорость, уровень
    public int health = 5;
    public int speed = 1;
    public int level = 1;
    private Vector3 newPosition;
    // Start is called before the first frame update
    void Start()
    {
    // ѕрибавл€ет к здоровью NPC его уровень
        health += level;
        print(health);
    }

    // Update is called once per frame
    void Update()
    {
        newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;

    }
}
