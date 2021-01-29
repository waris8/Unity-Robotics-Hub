using RosMessageGeneration;
using RosMessageTypes.NiryoMoveit;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ROSGeometry;
using RosMessageTypes.Moveit;
using RosMessageTypes.Trajectory;

[VisualizeMessage(typeof(MoverServiceResponse))]
public class MoverServiceResponse_Visualizer : MessageVisualizerDrawing<MoverServiceResponse>
{
    public override void DrawGUI(DebugDraw.Drawing drawing, MoverServiceResponse message)
    {
        base.DrawGUI(drawing, message);
    }

    public override void Draw(DebugDraw.Drawing drawing, MoverServiceResponse message)
    {
    }
}
