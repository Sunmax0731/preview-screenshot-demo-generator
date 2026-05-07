using UnityEditor;
using UnityEngine;

namespace Sunmax0731.PreviewScreenshotDemoGenerator
{
    public sealed class PreviewScreenshotDemoGeneratorWindow : EditorWindow
    {
        [MenuItem("Tools/Sunmax0731/プレビュー・スクショ・デモ生成")]
        public static void Open()
        {
            GetWindow<PreviewScreenshotDemoGeneratorWindow>("プレビュー・スクショ・デモ生成");
        }

        private void OnGUI()
        {
            EditorGUILayout.LabelField("プレビュー・スクショ・デモ生成", EditorStyles.boldLabel);
            EditorGUILayout.HelpBox("プレビュー確認から共有用成果物までUnity内で生成する。", MessageType.Info);
            if (GUILayout.Button("Open documentation"))
            {
                Application.OpenURL("https://github.com/Sunmax0731/preview-screenshot-demo-generator");
            }
        }
    }
}
