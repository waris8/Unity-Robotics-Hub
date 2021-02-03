using RosMessageTypes.NiryoMoveit;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;
using Unity.Robotics.ROSTCPConnector.ROSGeometry;

[VisualizeMessage(typeof(MoverServiceRequest))]
public class MoverServiceRequest_Visualizer : MessageVisualizerDrawing<MoverServiceRequest>
{
    public MoverServiceRequest_Visualizer(string topic, Message msg) :
        base(topic, msg)
    {
    }

    public override void GUI()
    {
        GUILayout.Label(message.ToString());
    }

    public override void DrawVisual()
    {
        MessageVisualizations.Draw<FLU>(drawing, message.pick_pose, Color.cyan, "pick", 0.01f);
        MessageVisualizations.Draw<FLU>(drawing, message.place_pose, Color.red, "place", 0.01f);
    }
}

