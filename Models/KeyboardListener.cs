using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

public static class KeyboardListener
{
    private const int WH_KEYBOARD_LL = 13;
    private const int WM_KEYDOWN = 0x0100;

    private static LowLevelKeyboardProc _proc = HookCallback;
    private static IntPtr _hookID = IntPtr.Zero;
    private static int _digitCount = 0;
    private static int[] _capturedDigits = new int[8]; // Almacenar los 8 dígitos ingresados

    public static event EventHandler<EightDigitsEventArgs> EightDigitsKeyPressed; // Modificar la firma del evento

    public static void StartListening()
    {
        _hookID = SetHook(_proc);
    }

    public static void StopListening()
    {
        UnhookWindowsHookEx(_hookID);
    }

    private static IntPtr SetHook(LowLevelKeyboardProc proc)
    {
        using (System.Diagnostics.Process curProcess = System.Diagnostics.Process.GetCurrentProcess())
        using (System.Diagnostics.ProcessModule curModule = curProcess.MainModule)
        {
            return SetWindowsHookEx(WH_KEYBOARD_LL, proc, GetModuleHandle(curModule.ModuleName), 0);
        }
    }

    private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

    private static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
    {
        if (nCode >= 0 && wParam == (IntPtr)WM_KEYDOWN)
        {
            int vkCode = Marshal.ReadInt32(lParam);

            // Verificar si la tecla presionada es un dígito
            if ((vkCode >= 48 && vkCode <= 57) || (vkCode >= 96 && vkCode <= 105))
            {
                // Agregar el dígito a la lista de dígitos capturados
                _capturedDigits[_digitCount] = vkCode - (int)Keys.D0;
                _digitCount++;

                // Si se ingresaron 8 dígitos, disparar el evento con los dígitos capturados y reiniciar el contador
                if (_digitCount == 8)
                {
                    EightDigitsEventArgs args = new EightDigitsEventArgs(_capturedDigits);
                    EightDigitsKeyPressed?.Invoke(null, args);
                    _digitCount = 0; // Reiniciar el contador
                    _capturedDigits = new int[8]; // Reiniciar la lista de dígitos capturados
                }
            }
        }
        return CallNextHookEx(_hookID, nCode, wParam, lParam);
    }

    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static extern bool UnhookWindowsHookEx(IntPtr hhk);

    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

    [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    private static extern IntPtr GetModuleHandle(string lpModuleName);
}

public class EightDigitsEventArgs : EventArgs
{
    public int[] Digits { get; private set; }

    public EightDigitsEventArgs(int[] digits)
    {
        Digits = digits;
    }
}
