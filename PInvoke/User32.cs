using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace PInvoke
{
    public static class User32
    {
        //const string user32dll = "user32.dll";

        //[Flags]
        //public enum SetWindowLongFlags : uint
        //{
        //    WS_OVERLAPPED = 0,
        //    WS_TILED = 0,
        //    WS_EX_LEFT = 0,
        //    WS_EX_LTRREADING = 0,
        //    WS_EX_RIGHTSCROLLBAR = 0,
        //    WS_EX_DLGMODALFRAME = 1,
        //    WS_EX_NOPARENTNOTIFY = 4,
        //    WS_EX_TOPMOST = 8,
        //    WS_EX_ACCEPTFILES = 16,
        //    WS_EX_TRANSPARENT = 32,
        //    WS_EX_MDICHILD = 64,
        //    WS_EX_TOOLWINDOW = 128,
        //    WS_EX_WINDOWEDGE = 256,
        //    WS_EX_PALETTEWINDOW = 392,
        //    WS_EX_CLIENTEDGE = 512,
        //    WS_EX_OVERLAPPEDWINDOW = 768,
        //    WS_EX_CONTEXTHELP = 1024,
        //    WS_EX_RIGHT = 4096,
        //    WS_EX_RTLREADING = 8192,
        //    WS_EX_LEFTSCROLLBAR = 16384,
        //    WS_TABSTOP = 65536,
        //    WS_MAXIMIZEBOX = 65536,
        //    WS_EX_CONTROLPARENT = 65536,
        //    WS_GROUP = 131072,
        //    WS_MINIMIZEBOX = 131072,
        //    WS_EX_STATICEDGE = 131072,
        //    WS_THICKFRAME = 262144,
        //    WS_SIZEBOX = 262144,
        //    WS_EX_APPWINDOW = 262144,
        //    WS_SYSMENU = 524288,
        //    WS_EX_LAYERED = 524288,
        //    WS_HSCROLL = 1048576,
        //    WS_EX_NOINHERITLAYOUT = 1048576,
        //    WS_VSCROLL = 2097152,
        //    WS_DLGFRAME = 4194304,
        //    WS_EX_LAYOUTRTL = 4194304,
        //    WS_BORDER = 8388608,
        //    WS_CAPTION = 12582912,
        //    WS_MAXIMIZE = 16777216,
        //    WS_CLIPCHILDREN = 33554432,
        //    WS_EX_COMPOSITED = 33554432,
        //    WS_CLIPSIBLINGS = 67108864,
        //    WS_DISABLED = 134217728,
        //    WS_EX_NOACTIVATE = 134217728,
        //    WS_VISIBLE = 268435456,
        //    WS_MINIMIZE = 536870912,
        //    WS_ICONIC = 536870912,
        //    WS_CHILD = 1073741824,
        //    WS_POPUP = 2147483648
        //}
  
        public static class SetWindowLongFlags
        {
            /// <summary>
            /// Constants: Window Styles
            /// </summary>
            public const int WS_OVERLAPPED = 0x00000000;
            public const int WS_POPUP = unchecked((int)0x80000000);
            public const int WS_CHILD = 0x40000000;
            public const int WS_MINIMIZE = 0x20000000;
            public const int WS_VISIBLE = 0x10000000;
            public const int WS_DISABLED = 0x08000000;
            public const int WS_CLIPSIBLINGS = 0x04000000;
            public const int WS_CLIPCHILDREN = 0x02000000;
            public const int WS_MAXIMIZE = 0x01000000;
            public const int WS_CAPTION = 0x00C00000;  // WS_BORDER|WS_DLGFRAME
            public const int WS_BORDER = 0x00800000;
            public const int WS_DLGFRAME = 0x00400000;
            public const int WS_VSCROLL = 0x00200000;
            public const int WS_HSCROLL = 0x00100000;
            public const int WS_SYSMENU = 0x00080000;
            public const int WS_THICKFRAME = 0x00040000;
            public const int WS_GROUP = 0x00020000;
            public const int WS_TABSTOP = 0x00010000;
            public const int WS_MINIMIZEBOX = 0x00020000;
            public const int WS_MAXIMIZEBOX = 0x00010000;
            public const int WS_TILED = WS_OVERLAPPED;
            public const int WS_ICONIC = WS_MINIMIZE;
            public const int WS_SIZEBOX = WS_THICKFRAME;
            public const int WS_TILEDWINDOW = WS_OVERLAPPEDWINDOW;
            public const int WS_OVERLAPPEDWINDOW = WS_OVERLAPPED | WS_CAPTION | WS_SYSMENU | WS_THICKFRAME | WS_MINIMIZEBOX | WS_MAXIMIZEBOX;
            public const int WS_POPUPWINDOW = WS_POPUP | WS_BORDER | WS_SYSMENU;
            public const int WS_CHILDWINDOW = WS_CHILD;

            /// <summary>
            /// Constants: Extended Window Styles
            /// </summary>
            public const int WS_EX_DLGMODALFRAME = 0x00000001;
            public const int WS_EX_NOPARENTNOTIFY = 0x00000004;
            public const int WS_EX_TOPMOST = 0x00000008;
            public const int WS_EX_ACCEPTFILES = 0x00000010;
            public const int WS_EX_TRANSPARENT = 0x00000020;
            public const int WS_EX_MDICHILD = 0x00000040;
            public const int WS_EX_TOOLWINDOW = 0x00000080;
            public const int WS_EX_WINDOWEDGE = 0x00000100;
            public const int WS_EX_CLIENTEDGE = 0x00000200;
            public const int WS_EX_CONTEXTHELP = 0x00000400;
            public const int WS_EX_RIGHT = 0x00001000;
            public const int WS_EX_LEFT = 0x00000000;
            public const int WS_EX_RTLREADING = 0x00002000;
            public const int WS_EX_LTRREADING = 0x00000000;
            public const int WS_EX_LEFTSCROLLBAR = 0x00004000;
            public const int WS_EX_RIGHTSCROLLBAR = 0x00000000;
            public const int WS_EX_CONTROLPARENT = 0x00010000;
            public const int WS_EX_STATICEDGE = 0x00020000;
            public const int WS_EX_APPWINDOW = 0x00040000;
            public const int WS_EX_OVERLAPPEDWINDOW = WS_EX_WINDOWEDGE | WS_EX_CLIENTEDGE;
            public const int WS_EX_PALETTEWINDOW = WS_EX_WINDOWEDGE | WS_EX_TOOLWINDOW | WS_EX_TOPMOST;
            public const int WS_EX_LAYERED = 0x00080000;
            public const int WS_EX_NOINHERITLAYOUT = 0x00100000;
            public const int WS_EX_LAYOUTRTL = 0x00400000;
            public const int WS_EX_COMPOSITED = 0x02000000;
            public const int WS_EX_NOACTIVATE = 0x08000000;
        }




        public enum WindowShowStyle : uint
        {
            //
            // Summary:
            //     Hides the window and activates another window.
            SW_HIDE = 0,
            //
            // Summary:
            //     Activates and displays a window. If the window is minimized or maximized, the
            //     system restores it to its original size and position. An application should specify
            //     this flag when displaying the window for the first time.
            SW_SHOWNORMAL = 1,
            //
            // Summary:
            //     Activates the window and displays it as a minimized window.
            SW_SHOWMINIMIZED = 2,
            //
            // Summary:
            //     Activates the window and displays it as a maximized window.
            SW_SHOWMAXIMIZED = 3,
            //
            // Summary:
            //     Maximizes the specified window.
            SW_MAXIMIZE = 3,
            //
            // Summary:
            //     Displays a window in its most recent size and position. This value is similar
            //     to "ShowNormal", except the window is not actived.
            SW_SHOWNOACTIVATE = 4,
            //
            // Summary:
            //     Activates the window and displays it in its current size and position.
            SW_SHOW = 5,
            //
            // Summary:
            //     Minimizes the specified window and activates the next top-level window in the
            //     Z order.
            SW_MINIMIZE = 6,
            //
            // Summary:
            //     Displays the window as a minimized window. This value is similar to "ShowMinimized",
            //     except the window is not activated.
            SW_SHOWMINNOACTIVE = 7,
            //
            // Summary:
            //     Displays the window in its current size and position. This value is similar to
            //     "Show", except the window is not activated.
            SW_SHOWNA = 8,
            //
            // Summary:
            //     Activates and displays the window. If the window is minimized or maximized, the
            //     system restores it to its original size and position. An application should specify
            //     this flag when restoring a minimized window.
            SW_RESTORE = 9,
            //
            // Summary:
            //     Sets the show state based on the SW_ value specified in the STARTUPINFO structure
            //     passed to the CreateProcess function by the program that started the application.
            SW_SHOWDEFAULT = 10,
            //
            // Summary:
            //     Windows 2000/XP: Minimizes a window, even if the thread that owns the window
            //     is hung. This flag should only be used when minimizing windows from a different
            //     thread.
            SW_FORCEMINIMIZE = 11
        }

    
        public static class WindowStylesEx 
        {
            /// <summary>Specifies a window that accepts drag-drop files.</summary>
            public const int WS_EX_ACCEPTFILES = 0x00000010;

            /// <summary>Forces a top-level window onto the taskbar when the window is visible.</summary>
            public const int WS_EX_APPWINDOW = 0x00040000;

            /// <summary>Specifies a window that has a border with a sunken edge.</summary>
            public const int WS_EX_CLIENTEDGE = 0x00000200;

            /// <summary>
            /// Specifies a window that paints all descendants in bottom-to-top painting order using double-buffering.
            /// This cannot be used if the window has a class style of either CS_OWNDC or CS_CLASSDC. This style is not supported in Windows 2000.
            /// </summary>
            /// <remarks>
            /// With WS_EX_COMPOSITED set, all descendants of a window get bottom-to-top painting order using double-buffering.
            /// Bottom-to-top painting order allows a descendent window to have translucency (alpha) and transparency (color-key) effects,
            /// but only if the descendent window also has the WS_EX_TRANSPARENT bit set.
            /// Double-buffering allows the window and its descendents to be painted without flicker.
            /// </remarks>
            public const int WS_EX_COMPOSITED = 0x02000000;

            /// <summary>
            /// Specifies a window that includes a question mark in the title bar. When the user clicks the question mark,
            /// the cursor changes to a question mark with a pointer. If the user then clicks a child window, the child receives a WM_HELP message.
            /// The child window should pass the message to the parent window procedure, which should call the WinHelp function using the HELP_WM_HELP command.
            /// The Help application displays a pop-up window that typically contains help for the child window.
            /// WS_EX_CONTEXTHELP cannot be used with the WS_MAXIMIZEBOX or WS_MINIMIZEBOX styles.
            /// </summary>
            public const int WS_EX_CONTEXTHELP = 0x00000400;

            /// <summary>
            /// Specifies a window which contains child windows that should take part in dialog box navigation.
            /// If this style is specified, the dialog manager recurses into children of this window when performing navigation operations
            /// such as handling the TAB key, an arrow key, or a keyboard mnemonic.
            /// </summary>
            public const int WS_EX_CONTROLPARENT = 0x00010000;

            /// <summary>Specifies a window that has a double border.</summary>
            public const int WS_EX_DLGMODALFRAME = 0x00000001;

            /// <summary>
            /// Specifies a window that is a layered window.
            /// This cannot be used for child windows or if the window has a class style of either CS_OWNDC or CS_CLASSDC.
            /// </summary>
            public const int WS_EX_LAYERED = 0x00080000;

            /// <summary>
            /// Specifies a window with the horizontal origin on the right edge. Increasing horizontal values advance to the left.
            /// The shell language must support reading-order alignment for this to take effect.
            /// </summary>
            public const int WS_EX_LAYOUTRTL = 0x00400000;

            /// <summary>Specifies a window that has generic left-aligned properties. This is the default.</summary>
            public const int WS_EX_LEFT = 0x00000000;

            /// <summary>
            /// Specifies a window with the vertical scroll bar (if present) to the left of the client area.
            /// The shell language must support reading-order alignment for this to take effect.
            /// </summary>
            public const int WS_EX_LEFTSCROLLBAR = 0x00004000;

            /// <summary>
            /// Specifies a window that displays text using left-to-right reading-order properties. This is the default.
            /// </summary>
            public const int WS_EX_LTRREADING = 0x00000000;

            /// <summary>
            /// Specifies a multiple-document interface (MDI) child window.
            /// </summary>
            public const int WS_EX_MDICHILD = 0x00000040;

            /// <summary>
            /// Specifies a top-level window created with this style does not become the foreground window when the user clicks it.
            /// The system does not bring this window to the foreground when the user minimizes or closes the foreground window.
            /// The window does not appear on the taskbar by default. To force the window to appear on the taskbar; use the WS_EX_APPWINDOW style.
            /// To activate the window; use the SetActiveWindow or SetForegroundWindow function.
            /// </summary>
            public const int WS_EX_NOACTIVATE = 0x08000000;

            /// <summary>
            /// Specifies a window which does not pass its window layout to its child windows.
            /// </summary>
            public const int WS_EX_NOINHERITLAYOUT = 0x00100000;

            /// <summary>
            /// Specifies that a child window created with this style does not send the WM_PARENTNOTIFY message to its parent window when it is created or destroyed.
            /// </summary>
            public const int WS_EX_NOPARENTNOTIFY = 0x00000004;

            /// <summary>
            /// The window does not render to a redirection surface.
            /// This is for windows that do not have visible content or that use mechanisms other than surfaces to provide their visual.
            /// </summary>
            public const int WS_EX_NOREDIRECTIONBITMAP = 0x00200000;

            /// <summary>Specifies an overlapped window.</summary>
            public const int WS_EX_OVERLAPPEDWINDOW = WS_EX_WINDOWEDGE | WS_EX_CLIENTEDGE;

            /// <summary>Specifies a palette window; which is a modeless dialog box that presents an array of commands.</summary>
            public const int WS_EX_PALETTEWINDOW = WS_EX_WINDOWEDGE | WS_EX_TOOLWINDOW | WS_EX_TOPMOST;

            /// <summary>
            /// Specifies a window that has generic "right-aligned" properties. This depends on the window class.
            /// The shell language must support reading-order alignment for this to take effect.
            /// Using the WS_EX_RIGHT style has the same effect as using the SS_RIGHT (static); ES_RIGHT (edit); and BS_RIGHT/BS_RIGHTBUTTON (button) control styles.
            /// </summary>
            public const int WS_EX_RIGHT = 0x00001000;

            /// <summary>Specifies a window with the vertical scroll bar (if present) to the right of the client area. This is the default.</summary>
            public const int WS_EX_RIGHTSCROLLBAR = 0x00000000;

            /// <summary>
            /// Specifies a window that displays text using right-to-left reading-order properties.
            /// The shell language must support reading-order alignment for this to take effect.
            /// </summary>
            public const int WS_EX_RTLREADING = 0x00002000;

            /// <summary>Specifies a window with a three-dimensional border style intended to be used for items that do not accept user input.</summary>
            public const int WS_EX_STATICEDGE = 0x00020000;

            /// <summary>
            /// Specifies a window that is intended to be used as a floating toolbar.
            /// A tool window has a title bar that is shorter than a normal title bar; and the window title is drawn using a smaller font.
            /// A tool window does not appear in the taskbar or in the dialog that appears when the user presses ALT+TAB.
            /// If a tool window has a system menu; its icon is not displayed on the title bar.
            /// However; you can display the system menu by right-clicking or by typing ALT+SPACE.
            /// </summary>
            public const int WS_EX_TOOLWINDOW = 0x00000080;

            /// <summary>
            /// Specifies a window that should be placed above all non-topmost windows and should stay above them; even when the window is deactivated.
            /// To add or remove this style; use the SetWindowPos function.
            /// </summary>
            public const int WS_EX_TOPMOST = 0x00000008;

            /// <summary>
            /// Specifies a window that should not be painted until siblings beneath the window (that were created by the same thread) have been painted.
            /// The window appears transparent because the bits of underlying sibling windows have already been painted.
            /// To achieve transparency without these restrictions; use the SetWindowRgn function.
            /// </summary>
            public const int WS_EX_TRANSPARENT = 0x00000020;

            /// <summary>Specifies a window that has a border with a raised edge.</summary>
            public const int WS_EX_WINDOWEDGE = 0x00000100;
        }

        public static class WindowLongIndexFlags
        {
            /// <summary>
            /// Constants for GetWindowLong
            /// </summary>
            public const int GWL_WNDPROC = -4;
            public const int GWL_HINSTANCE = -6;
            public const int GWL_HWNDPARENT = -8;
            public const int GWL_STYLE = -16;
            public const int GWL_EXSTYLE = -20;
            public const int GWL_USERDATA = -21;
            public const int GWL_ID = -12;
            public const int GWLP_USERDATA = -21;
            public const int GWLP_ID = -12;
            public const int GWLP_HWNDPAREN = -8;
            public const int GWLP_HINSTANCE = -6;
            public const int GWLP_WNDPROC = -4;
            public const int DWLP_MSGRESULT = 0;
            public const int DWLP_DLGPROC = 4;
            public const int DWLP_USER = 8;
        }

        /// <summary> An application-defined callback function used with the <see cref="EnumWindows"/> or <see cref="EnumDesktopWindows(SafeDesktopHandle, WNDENUMPROC, IntPtr)"/> function.</summary>
        /// <param name="hwnd">A handle to a top-level window.</param>
        /// <param name="lParam">The application-defined value given in <see cref="EnumWindows"/> or <see cref="EnumDesktopWindows(SafeDesktopHandle, WNDENUMPROC, IntPtr)"/>.</param>
        /// <returns>To continue enumeration, the callback function must return TRUE; to stop enumeration, it must return FALSE.</returns>
        /// <remarks>
        /// An application must register this callback function by passing its address to <see cref="EnumWindows"/> or <see cref="EnumDesktopWindows(SafeDesktopHandle, WNDENUMPROC, IntPtr)"/>.
        /// The callback function can call SetLastError to set an error code for the caller to retrieve by calling GetLastError.
        /// </remarks>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public delegate bool WndEnumProc(IntPtr hwnd, IntPtr lParam);

        [DllImport(nameof(User32), SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport(nameof(User32), SetLastError = true)]
        public static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        /// <summary>
        /// Shows a Window
        /// </summary>
        /// <remarks>
        /// <para>To perform certain special effects when showing or hiding a window, use AnimateWindow.</para>
        /// <para>
        /// The first time an application calls ShowWindow, it should use the WinMain function's
        /// nCmdShow parameter as its nCmdShow parameter. Subsequent calls to ShowWindow must use one
        /// of the values in the given list, instead of the one specified by the WinMain function's
        /// nCmdShow parameter.
        /// </para>
        /// <para>
        /// As noted in the discussion of the nCmdShow parameter, the nCmdShow value is ignored in
        /// the first call to ShowWindow if the program that launched the application specifies
        /// startup information in the structure. In this case, ShowWindow uses the information
        /// specified in the STARTUPINFO structure to show the window. On subsequent calls, the
        /// application must call ShowWindow with nCmdShow set to SW_SHOWDEFAULT to use the startup
        /// information provided by the program that launched the application. This behavior is
        /// designed for the following situations:
        /// </para>
        /// <list type="">
        /// <item>
        /// Applications create their main window by calling CreateWindow with the WS_VISIBLE flag set.
        /// </item>
        /// <item>
        /// Applications create their main window by calling CreateWindow with the WS_VISIBLE flag
        /// cleared, and later call ShowWindow with the SW_SHOW flag set to make it visible.
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="hWnd">Handle to the window.</param>
        /// <param name="nCmdShow">
        /// Specifies how the window is to be shown. This parameter is ignored the first time an
        /// application calls ShowWindow, if the program that launched the application provides a
        /// STARTUPINFO structure. Otherwise, the first time ShowWindow is called, the value should
        /// be the value obtained by the WinMain function in its nCmdShow parameter. In subsequent
        /// calls, this parameter can be one of the WindowShowStyle members.
        /// </param>
        /// <returns>
        /// If the window was previously visible, the return value is nonzero. If the window was
        /// previously hidden, the return value is zero.
        /// </returns>
        [DllImport(nameof(User32))]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        /// <summary>
        /// Enumerates all top-level windows on the screen by passing the handle to each window, in turn, to an application-defined callback function. EnumWindows continues until the last top-level window is enumerated or the callback function returns FALSE.
        /// </summary>
        /// <param name="lpEnumFunc">An application-defined <see cref="WNDENUMPROC"/> callback function.</param>
        /// <param name="lParam">An application-defined value to be passed to the callback function.</param>
        /// <returns>
        /// If the function succeeds, the return value is nonzero.
        /// If the function fails, the return value is zero.To get extended error information, call GetLastError.
        /// If <see cref="WNDENUMPROC"/> returns zero, the return value is also zero. In this case, the callback function should call SetLastError to obtain a meaningful error code to be returned to the caller of EnumWindows.
        /// </returns>
        /// <remarks>
        /// The EnumWindows function does not enumerate child windows, with the exception of a few top-level windows owned by the system that have the WS_CHILD style.
        /// This function is more reliable than calling the GetWindow function in a loop. An application that calls GetWindow to perform this task risks being caught in an infinite loop or referencing a handle to a window that has been destroyed.
        /// Note that for Windows 8 and later, EnumWindows enumerates only top-level windows of desktop apps.
        /// </remarks>
        [DllImport(nameof(User32), SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumWindows(WndEnumProc enumProc, IntPtr lParam);

        /// <summary>
        /// Copies the text of the specified window's title bar (if it has one) into a buffer. If the specified window is
        /// a control, the text of the control is copied. However, GetWindowText cannot retrieve the text of a control in another
        /// application.
        /// </summary>
        /// <param name="hWnd">A handle to the window or control containing the text.</param>
        /// <param name="lpString">
        /// The buffer that will receive the text. If the string is as long or longer than the buffer, the
        /// string is truncated and terminated with a null character.
        /// </param>
        /// <param name="nMaxCount">
        /// The maximum number of characters to copy to the buffer, including the null character. If the
        /// text exceeds this limit, it is truncated.
        /// </param>
        /// <returns>
        /// If the function succeeds, the return value is the length, in characters, of the copied string, not including
        /// the terminating null character. If the window has no title bar or text, if the title bar is empty, or if the window or
        /// control handle is invalid, the return value is zero. To get extended error information, call GetLastError.
        /// <para>This function cannot retrieve the text of an edit control in another application.</para>
        /// </returns>
        [DllImport(nameof(User32), CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

        /// <summary>
        /// Retrieves the length, in characters, of the specified window's title bar text (if the window has a title bar).
        /// If the specified window is a control, the function retrieves the length of the text within the control. However,
        /// GetWindowTextLength cannot retrieve the length of the text of an edit control in another application.
        /// </summary>
        /// <param name="hWnd">A handle to the window or control.</param>
        /// <returns>
        /// If the function succeeds, the return value is the length, in characters, of the text. Under certain
        /// conditions, this value may actually be greater than the length of the text. For more information, see the following
        /// Remarks section.
        /// <para>If the window has no text, the return value is zero. To get extended error information, call GetLastError.</para>
        /// </returns>
        [DllImport(nameof(User32), CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern int GetWindowTextLength(IntPtr hWnd);

        /// <summary>
        /// Retrieves the name of the class to which the specified window belongs.
        /// </summary>
        /// <param name="hWnd">A handle to the window and, indirectly, the class to which the window belongs.</param>
        /// <param name="lpClassName">The class name string.</param>
        /// <param name="nMaxCount">
        /// The length of the <paramref name="lpClassName"/> buffer, in characters. The buffer must be large enough to include the terminating null character; otherwise, the class name string is truncated to <paramref name="nMaxCount"/>-1 characters.
        /// </param>
        /// <returns>
        /// If the function succeeds, the return value is the number of characters copied to the buffer, not including the terminating null character.
        /// If the function fails, the return value is zero. To get extended error information, call GetLastError.
        /// </returns>
        [DllImport(nameof(User32), SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int GetClassName(IntPtr hWnd, StringBuilder lpClassName, int nMaxCount);



        public static class LayeredWindowAttributes
        {
            //Use pbAlpha to determine the opacity of the layered window.
            public const int LWA_ALPHA = 0x00000002;

            // Use pcrKey as the transparency color.
            public const int LWA_COLORKEY = 0x00000001;
        }



        [DllImport(nameof(User32))]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetLayeredWindowAttributes(IntPtr hwnd, uint crKey, byte bAlpha, uint dwFlags);

        /// <summary>
        /// Retrieves a handle to the foreground window (the window with which the user is currently
        /// working). The system assigns a slightly higher priority to the thread that creates the
        /// foreground window than it does to other threads.
        /// <para>
        /// See https://msdn.microsoft.com/en-us/library/windows/desktop/ms633505%28v=vs.85%29.aspx
        /// for more information.
        /// </para>
        /// </summary>
        /// <returns>
        /// C++ ( Type: Type: HWND ) <br/> The return value is a handle to the foreground window. The
        /// foreground window can be NULL in certain circumstances, such as when a window is losing activation.
        /// </returns>
        [DllImport(nameof(User32), SetLastError = true)]
        public static extern IntPtr GetForegroundWindow();

        /// <summary>Retrieves the window handle to the active window attached to the calling thread's message queue.</summary>
        /// <returns>
        ///     The return value is the handle to the active window attached to the calling thread's message queue. Otherwise,
        ///     the return value is <see cref="IntPtr.Zero" />.
        /// </returns>
        [DllImport(nameof(User32), SetLastError = true)]
        public static extern IntPtr GetActiveWindow();
    }
}
