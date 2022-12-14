using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave : MonoBehaviour
{
    public Transform[] ground = new Transform[20];

    float x = 0;
    float[] height = new float[20];

    public float amplitude = 2;
    public float speed = 1;
    public float followSpeed = 15;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            x += Time.deltaTime;
            Vector3 wave = Vector3.up * (amplitude * Mathf.Sin(speed * (x)));
            ground[0].position = wave;
        }

        //height[1] = Mathf.Lerp(height[1], ground[0].position.y, Time.deltaTime * 10);
        //ground[1].position = new Vector3(ground[1].position.x, height[1], ground[1].position.z);

        //height[2] = Mathf.Lerp(height[2], ground[1].position.y, Time.deltaTime * 10);
        //ground[2].position = new Vector3(ground[2].position.x, height[2], ground[2].position.z);

        WaveMove(1);
        WaveMove(2);
        WaveMove(3);
        WaveMove(4);
        WaveMove(5);
        WaveMove(6);
        WaveMove(7);
        WaveMove(8);
        WaveMove(9);
        WaveMove(10);
        WaveMove(11);
        WaveMove(12);
        WaveMove(13);
        WaveMove(14);
        WaveMove(15);
        WaveMove(16);
        WaveMove(17);
        WaveMove(18);
        WaveMove(19);
    }

    void WaveMove(int i)
    {
        height[i] = Mathf.Lerp(height[i], ground[i - 1].position.y, Time.deltaTime * followSpeed);
        ground[i].position = new Vector3(ground[i].position.x, height[i], ground[i].position.z);
    }
}
