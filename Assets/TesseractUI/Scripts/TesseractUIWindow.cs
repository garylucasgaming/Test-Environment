using UnityEditor;
using UnityEngine.UI;
using UnityEngine;

public class TesseractUIWindow : EditorWindow
{

    string myString = "Hello World";
    bool groupEnabled;
    bool myBool = true;
    float myFloat = 1.23f;

    Canvas myCanvas;
    GameObject coreModule;

    [MenuItem("Window/Tesseract UI")]
    public static void ShowWindow() { EditorWindow.GetWindow(typeof(TesseractUIWindow)); }

    void OnGUI() 
    {
        GUILayout.Label("Base Settings", EditorStyles.boldLabel);
        
        if (GUILayout.Button("Create Core Canvas Module")) 
        {
            coreModule = new GameObject();
            coreModule.name = "Core Tesseract Canvas Module";
            coreModule.AddComponent<Canvas>();

            myCanvas = coreModule.GetComponent<Canvas>();
            myCanvas.renderMode = RenderMode.ScreenSpaceOverlay;
            coreModule.AddComponent<CanvasScaler>();
            coreModule.AddComponent<GraphicRaycaster>();


        }
       


    }
}
