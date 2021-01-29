using RosMessageGeneration;
using RosMessageTypes.NiryoMoveit;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ROSGeometry;

[VisualizeMessage(typeof(MoverServiceRequest))]
public class MoverServiceRequest_Visualizer : MessageVisualizerDrawing<MoverServiceRequest>
{
    public override void DrawGUI(DebugDraw.Drawing drawing, MoverServiceRequest message)
    {
        GUILayout.Label(message.ToString());
    }

    public override void Draw(DebugDraw.Drawing drawing, MoverServiceRequest message)
    {
        MessageVisualizations<FLU>.DrawPose(drawing, message.pick_pose, Color.cyan, "pick", 0.01f);
        MessageVisualizations<FLU>.DrawPose(drawing, message.place_pose, Color.red, "place", 0.01f);
    }
}

