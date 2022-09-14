using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public Transform[] ground;
    float[] height = new float[20];

    float followSpeed = 15;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
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
