using System.Text;
using UnityEngine;

namespace XFrameEffect
{

    [ExecuteInEditMode]
    [AddComponentMenu("")]
    public class XFrameFPSInfo : MonoBehaviour
    {

        static GUIStyle boxStyle;
        StringBuilder sb = new StringBuilder();

        void OnGUI()
        {
            Rect rect;
            XFrameManager xframe = XFrameManager.instance;
            if (xframe == null)
                return;
            if (boxStyle == null)
            {
                boxStyle = new GUIStyle();
                boxStyle.normal.textColor = Color.yellow;
                boxStyle.fontStyle = FontStyle.Bold;
                boxStyle.wordWrap = false;
                boxStyle.richText = false;
            }
            float scale = 1080f / Screen.height;
            boxStyle.fontSize = (int)(xframe.fpsFontSize * scale);
            boxStyle.normal.textColor = xframe.fpsColor;
            string fps;
            if (xframe.showQuality) {
                sb.Length = 0;
                sb.Append("FPS: ");
                sb.Append(xframe.currentFPS);
                sb.AppendLine();
                sb.Append("Q: ");
                sb.Append((int)(xframe.appliedDownsampling * 100f));
                sb.Append("%");
                fps = sb.ToString();
            } else {
                fps = xframe.currentFPS.ToString();
            }
             
            Vector2 size = boxStyle.CalcSize(new GUIContent(fps));

            switch (xframe.fpsLocation)
            {
                default:
                    rect = new Rect(5, 5, 10, 10);
                    boxStyle.alignment = TextAnchor.MiddleLeft;
                    break;
                case XFRAME_FPS_LOCATION.TopRightCorner:
                    rect = new Rect(Screen.width - size.x - 5, 5, 50, 30);
                    boxStyle.alignment = TextAnchor.MiddleRight;
                    break;
                case XFRAME_FPS_LOCATION.BottomLeftCorner:
                    rect = new Rect(5, Screen.height - size.y - 5, 50, 30);
                    boxStyle.alignment = TextAnchor.MiddleLeft;
                    break;
                case XFRAME_FPS_LOCATION.BottomRightCorner:
                    rect = new Rect(Screen.width - size.x - 5, Screen.height - size.y - 5, 50, 30);
                    boxStyle.alignment = TextAnchor.MiddleRight;
                    break;
            }
            rect.size = size;

            GUI.Box(rect, fps, boxStyle);

        }
    }
}