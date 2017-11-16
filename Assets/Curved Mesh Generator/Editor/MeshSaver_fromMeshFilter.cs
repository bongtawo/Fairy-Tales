using UnityEngine;
using UnityEditor;

public static class MeshSaver_fromMeshFilter
{
	[MenuItem("CONTEXT/MeshFilter/Save Mesh...")]
	public static void SaveMeshNewInstanceItem(MenuCommand menuCommand)
	{
		var mf = menuCommand.context as MeshFilter;
		var mesh = mf.sharedMesh;
		SaveMesh(mesh, mesh.name);
	}

	public static void SaveMesh(Mesh mesh, string name, bool makeNewInstance = true, bool optimizeMesh = true)
	{
		var path = EditorUtility.SaveFilePanel("Save Separate Mesh Asset", "Assets/", name, "asset");
		if (string.IsNullOrEmpty(path)) return;

		path = FileUtil.GetProjectRelativePath(path);

		var saveMeshInstance = (makeNewInstance) ? Object.Instantiate(mesh) : mesh;

		if (optimizeMesh)
			MeshUtility.Optimize(saveMeshInstance);

		AssetDatabase.CreateAsset(saveMeshInstance, path);
		AssetDatabase.SaveAssets();
	}
}