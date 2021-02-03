using RosMessageGeneration;
using RosMessageTypes.NiryoMoveit;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Robotics.ROSTCPConnector.ROSGeometry;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;
using RosMessageTypes.Moveit;
using RosMessageTypes.Trajectory;

[VisualizeMessage(typeof(MoverServiceResponse))]
public class MoverServiceResponse_Visualizer : MessageVisualizerDrawing<MoverServiceResponse>
{
    public MoverServiceResponse_Visualizer(string topic, Message msg):
        base(topic, msg)
    {
    }

    public override void GUI()
    {
        GUILayout.Label(message.ToString());
    }

    public override void DrawVisual()
    {
    }
}
