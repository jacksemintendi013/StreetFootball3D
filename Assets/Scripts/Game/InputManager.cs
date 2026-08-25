using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    public static InputManager Instance { get; private set; }
    
    private PlayerInput playerInput;
    private bool isGamepadConnected = false;
    
    // Input callbacks
    public delegate void OnMoveInput(Vector2 input);
    public delegate void OnActionInput();
    
    public event OnMoveInput MoveInputEvent;
    public event OnActionInput JumpInputEvent;
    public event OnActionInput PassInputEvent;
    public event OnActionInput ShootInputEvent;
    public event OnActionInput SkillInputEvent;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        
        playerInput = GetComponent<PlayerInput>();
    }

    private void OnEnable()
    {
        InputSystem.onDeviceChange += OnDeviceChange;
    }

    private void OnDisable()
    {
        InputSystem.onDeviceChange -= OnDeviceChange;
    }

    private void OnDeviceChange(InputDevice device, InputDeviceChange change)
    {
        if (device is Gamepad)
        {
            isGamepadConnected = change == InputDeviceChange.Added;
            Debug.Log($"Gamepad {(isGamepadConnected ? "Connected" : "Disconnected")}");
        }
    }

    public bool IsGamepadConnected() => isGamepadConnected;
    public string GetCurrentControlScheme() => playerInput.currentControlScheme;
}
