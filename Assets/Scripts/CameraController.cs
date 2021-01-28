using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float panSpeed = 30f;
    public float panBoarderThickness = 10f;
    public float scrollSpeed = 5f;

    public float minX = -30f;
    public float maxX = 100f;

    public float minY = 10f;
    public float maxY = 80f;

    public float minZ = -50f;
    public float maxZ = 50f;

    // Update is called once per frame
    void Update()
    {
        if (GameManager.GameIsOver)
        {
            this.enabled = false;
            return;
        }
        if (Input.GetKey("w"))
        {
            transform.Translate(Vector3.forward * panSpeed * Time.deltaTime, Space.World);
            Vector3 pos2 = transform.position;
            pos2.z = Mathf.Clamp(pos2.z, minZ, maxZ);
            transform.position = pos2;
        }
        if (Input.GetKey("s"))
        {
            transform.Translate(Vector3.back * panSpeed * Time.deltaTime, Space.World);
            Vector3 pos2 = transform.position;
            pos2.z = Mathf.Clamp(pos2.z, minZ, maxZ);
            transform.position = pos2;
        }
        if (Input.GetKey("d"))
        {
            transform.Translate(Vector3.right * panSpeed * Time.deltaTime, Space.World);
            Vector3 pos2 = transform.position;
            pos2.x = Mathf.Clamp(pos2.x, minX, maxX);
            transform.position = pos2;
        }
        if (Input.GetKey("a"))
        {
            transform.Translate(Vector3.left * panSpeed * Time.deltaTime, Space.World);
            Vector3 pos2 = transform.position;
            pos2.x = Mathf.Clamp(pos2.x, minX, maxX);
            transform.position = pos2;
        }

        float scroll = Input.GetAxis("Mouse ScrollWheel");

        Vector3 pos = transform.position;

        pos.y -= scroll * 1000 * scrollSpeed * Time.deltaTime;
        pos.y = Mathf.Clamp(pos.y, minY, maxY);

        transform.position = pos;
    }
}
