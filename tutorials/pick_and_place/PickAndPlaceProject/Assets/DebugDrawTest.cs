using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FLU = ROSGeometry.FLU;
using RVector3 = ROSGeometry.Vector3<ROSGeometry.FLU>;
using static ROSGeometry.CoordinateSpaceExtensions;

public class DebugDrawTest : MonoBehaviour
{
    public GameObject pivot;
    void Start()
    {
        DebugDraw.Drawing drawing = DebugDraw.instance.CreateDrawing();
        MessageVisualizations<FLU>.DrawQuaternion(drawing, pivot.transform.rotation.To<FLU>(), pivot.transform.position);
    }
}
