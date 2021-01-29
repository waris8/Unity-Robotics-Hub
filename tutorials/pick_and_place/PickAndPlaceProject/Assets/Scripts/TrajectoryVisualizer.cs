using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrajectoryVisualizer : MonoBehaviour
{
    public static TrajectoryVisualizer instance;
    public GameObject niryoOne;

    private void Awake()
    {
        instance = this;
    }

    public void DrawRobot(float[] joints, DebugDraw drawing)
    {

    }
}
