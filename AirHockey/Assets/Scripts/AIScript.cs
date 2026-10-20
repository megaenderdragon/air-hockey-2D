using UnityEngine;

public class AIScript : MonoBehaviour
{
    public float MaxMovementSpeed;
    private Rigidbody2D rb;
    private Vector2 startingPosition;

    public Rigidbody2D Puck;

    public Transform PlayerBoundaryHolder;
    private Boundary playerBoundary;

    public Transform PuckBoundaryHolder;
    private Boundary puckBoundary;

    private Vector2 targetPosition;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        startingPosition = rb.position;

        playerBoundary = new Boundary(PlayerBoundaryHolder.GetChild(0).position.y, PlayerBoundaryHolder.GetChild(1).position.y, PlayerBoundaryHolder.GetChild(2).position.x, PlayerBoundaryHolder.GetChild(3).position.x);

        puckBoundary = new Boundary(PuckBoundaryHolder.GetChild(0).position.y, PuckBoundaryHolder.GetChild(1).position.y, PuckBoundaryHolder.GetChild(2).position.x, PuckBoundaryHolder.GetChild(3).position.x);
    }

    private void FixedUpdate()
    {
        float movementSpeed;

        if (Puck.position.y < puckBoundary.Down)
        {
            movementSpeed = MaxMovementSpeed * Random.Range(0.1f, 0.3f);
            targetPosition = new Vector2(Mathf.Clamp(Puck.position.x, playerBoundary.Left, playerBoundary.Right), startingPosition.y);
        }
    }
}
