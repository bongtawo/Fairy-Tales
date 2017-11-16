using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode, RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
public class CurvedMeshGenerator : MonoBehaviour
{
	public Mesh generatedMesh;

	[Range(2, 100)]
	public int count = 6;

	[Range(1f, 360f)]
	public float angle = 180f;

	public float radius = 1f;
	public float height = 1f;

	[Range(0.01f, 100f)]
	public float xRatio = 1f;

	[Range(0.01f, 100f)]
	public float zRatio = 1f;

	public void Awake()
	{
		Refresh();
	}

	private void OnValidate()
	{
		Refresh();
	}

	private void Refresh()
	{
		generatedMesh = Generate();
		var mf = GetComponent<MeshFilter>();
		if (mf != null)
			mf.mesh = generatedMesh;

		var mc = GetComponent<MeshCollider>();
		if (mc != null)
			mc.sharedMesh = generatedMesh;
	}

	private Mesh Generate()
	{
		#region Initialize Mesh

		Mesh mesh = null;
		if (generatedMesh == null)
		{
			mesh = new Mesh();
		}
		else
		{
			generatedMesh.Clear();
			mesh = generatedMesh;
		}

		mesh.name = "Curved Mesh";

		#endregion Initialize Mesh

		#region Vertices

		var halfHeight = height * 0.5f;
		var vertices = new List<Vector3>();
		var currentVertex = Vector3.zero;
		for (int i = 0; i <= count; ++i)
		{
			currentVertex = CalcVertex(radius, i, count, angle, xRatio, zRatio);
			vertices.Add(currentVertex + new Vector3(0f, halfHeight, 0f));
			vertices.Add(currentVertex + new Vector3(0f, -halfHeight, 0f));
		}
		mesh.SetVertices(vertices);

		#endregion Vertices

		#region Indices

		var indices = new List<int>();
		var doubleI = 0;
		for (int i = 0; i < count; i++)
		{
			doubleI = i * 2;

			indices.Add(doubleI);
			indices.Add(doubleI + 1);
			indices.Add(doubleI + 2);

			indices.Add(doubleI + 2);
			indices.Add(doubleI + 1);
			indices.Add(doubleI + 3);
		}
		mesh.SetIndices(indices.ToArray(), MeshTopology.Triangles, 0);

		#endregion Indices

		#region UVs

		var uvs = new List<Vector2>();
		var xStep = 1.0f / (float)count;
		for (int i = 0; i <= count; ++i)
		{
			uvs.Add(new Vector2(1.0f - i * xStep, 1f));
			uvs.Add(new Vector2(1.0f - i * xStep, 0f));
		}
		mesh.SetUVs(0, uvs);

		#endregion UVs

		#region Normals

		var normals = new List<Vector3>();
		for (int i = 0; i <= count; ++i)
		{
			normals.Add(Vector3.back);
			normals.Add(Vector3.back);
		}
		mesh.SetNormals(normals);

		#endregion Normals

		return mesh;
	}

	private static Vector3 CalcVertex(float radius, int index, int count, float angle, float xRatio, float zRatio)
	{
		var radian = ((angle / count) * index - angle * 0.5f + 90f) * Mathf.Deg2Rad;
		return new Vector3(
			(Mathf.Cos(radian) * radius * xRatio),
			0f,
			Mathf.Sin(radian) * radius * zRatio);
	}
}