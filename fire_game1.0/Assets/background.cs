using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class background : MonoBehaviour {

    [SerializeField]
    private float scrollSpeed = 1f;
    private float topEdge;
    private float bottomEdge;
    private Vector3 distanceBetweenEdge;

	// Use this for initialization
	void Start () {
        CalculateEdge();
        distanceBetweenEdge = new Vector3(0f, topEdge - bottomEdge, 0f);

	}
    private void CalculateEdge() {
        var spriteRenderer = GetComponent<SpriteRenderer>();
        topEdge = transform.position.y + spriteRenderer.bounds.extents.y / 3f;
        bottomEdge = transform.position.y - spriteRenderer.bounds.extents.y / 3f;
    }
	// Update is called once per frame
	void Update () {
        transform.localPosition += scrollSpeed * Vector3.up * Time.deltaTime;
        if (PassedEdge()) {
            MoveRightSpiteToOppositeEdge();
        }
	}
    private bool PassedEdge() {
        return (scrollSpeed > 0 && transform.position.y > topEdge) || (scrollSpeed < 0 && transform.position.y < bottomEdge);

    }
    private void MoveRightSpiteToOppositeEdge() {
        if (scrollSpeed > 0)
        {
            transform.position -= distanceBetweenEdge;
        }
        else
        {
            transform.position += distanceBetweenEdge;
        }
    }
    private void OnDrawGizmos()
    {
        if (Application.isPlaying)
        {
            Gizmos.DrawCube(new Vector3(0f,topEdge, 0f), new Vector3(2f, 0.1f, 0.1f));
            Gizmos.DrawCube(new Vector3(0f,bottomEdge, 0f), new Vector3(2f, 0.1f, 0.1f));
        }
    }
}
