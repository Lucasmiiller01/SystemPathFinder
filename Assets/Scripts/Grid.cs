using UnityEngine;

using System.Collections;

public class Grid : MonoBehaviour
{
	
	[ SerializeField ] private Transform transform;
	
	[ SerializeField ] private Material material;
	
	[ SerializeField ] private Vector2 gridSize;
	
	[ SerializeField ] private int rows;
	
	[ SerializeField ] private int columns;

	void Start()
	{
		DrawGrid();
	}
	

	public void DrawGrid()
	{
		transform.localScale = new Vector3( gridSize.x, gridSize.y, 1.0f );
		
		material.SetTextureScale( "_MainTex", new Vector2( columns, rows ) );	
	}
	
}
