using UnityEditor;
using UnityEngine;

namespace Sunmax0731.PreviewScreenshotDemoGenerator
{
    public sealed class PreviewScreenshotDemoGeneratorWindow : EditorWindow
    {
        [MenuItem("Tools/Sunmax0731/preview-screenshot-demo-generator")]
        public static void Open() => GetWindow<PreviewScreenshotDemoGeneratorWindow>("preview-screenshot-demo-generator");

        private void OnGUI()
        {
            GUILayout.Label("プレビュー・スクショ・デモ生成", EditorStyles.boldLabel);
            GUILayout.Label("Closed alpha editor package is importable.");
        }
    }
}
