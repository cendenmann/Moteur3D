using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerBehaviourScript : MonoBehaviour {

    public float _runSpeed = 10.5f;
    public float _strafeSpeed = 0.5f;
    private const float CAMERA_TURN_FACTOR = 10.0f;
    public GameObject _cameraPivot;

    public Text scoreText;
    private int score;

	// Use this for initialization
	void Start () {
        score = 0;
        UpdateScore();
	}
	
	// Update is called once per frame
	void Update () {
        if (Time.timeScale == 0) return;
        // Get mouse input
        float horizontalMouseInput = Input.GetAxis("Mouse X");
        float verticalMouseInput = Input.GetAxis("Mouse Y");

        // Turn player and pivot
        transform.RotateAround(transform.position, transform.up, CAMERA_TURN_FACTOR * horizontalMouseInput);
        _cameraPivot.transform.RotateAround(_cameraPivot.transform.position, _cameraPivot.transform.right, -CAMERA_TURN_FACTOR * verticalMouseInput);

        // Get the input from up/down keys
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Advance...       in nose direction  by run speed * frame duration * input (-1/0/1)
        transform.position += transform.forward * _runSpeed * Time.deltaTime * verticalInput
                           + transform.right * _strafeSpeed * Time.deltaTime * horizontalInput;
	}

    private const float TEST_GROUND_DISTANCE = 0.2f;
    private bool IsOnEarth()
    {
        // Launch ray downwards
        //    ^  _A_
        //    |  (") / \
        //    |---|-(   )
        //    |   |  \ /
        //    |  / \
        //  ____/_T_\____
        //        |ray  
        Ray ray = new Ray(transform.position + Vector3.up * TEST_GROUND_DISTANCE * 0.5f, -Vector3.up);
        return Physics.Raycast(ray, TEST_GROUND_DISTANCE, LayerMask.GetMask("Terrain"));
    }

    void UpdateScore()
    {
        scoreText.text = score.ToString();
    }

    public int AddScore(int newScoreValue)
    {
        score += newScoreValue;
        UpdateScore();
        return score;
    }
}
