using UnityEditor;

public class ForceSlnRegenerate
{
    [MenuItem("Tools/Force Regenerate Solution")]
    public static void ForceGenerate()
    {
        EditorApplication.ExecuteMenuItem("Assets/Open C# Project");
    }
}