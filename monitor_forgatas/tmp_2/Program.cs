using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Kepernyo_forgat;
using System.Drawing;

namespace ConsoleHotKey
{
    class Program
    {
        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        const int SW_HIDE = 0;
        const int SW_SHOW = 5;
        
        static void Main(string[] args)
        {
            
            HotKeyManager.RegisterHotKey(Keys.Up, KeyModifiers.Alt | KeyModifiers.Shift);
            HotKeyManager.RegisterHotKey(Keys.Down, KeyModifiers.Alt | KeyModifiers.Shift);
            HotKeyManager.RegisterHotKey(Keys.Left, KeyModifiers.Alt | KeyModifiers.Shift);
            HotKeyManager.RegisterHotKey(Keys.Right, KeyModifiers.Alt | KeyModifiers.Shift);
            HotKeyManager.HotKeyPressed += new EventHandler<HotKeyEventArgs>(HotKeyManager_HotKeyPressed);
            CreateNotifyicon();
            Console.ReadLine();
        }
        private static void CreateNotifyicon()
        {
            NotifyIcon tray = new NotifyIcon();
            //tray.DoubleClick += Tray_DoubleClick;
            tray.Icon = new Icon("cinema_display.ico");
            tray.Visible = true;
            tray.Text = "Monitor Orientáció";
            ContextMenu menu = new ContextMenu();
            tray.ContextMenu = menu;
            MenuItem Monitor_1 = new MenuItem("Monitor 1");
            Monitor_1.MenuItems.Add(new MenuItem("0°", new EventHandler(fel_monitor1)));
            Monitor_1.MenuItems.Add(new MenuItem("90°", new EventHandler(balra_monitor1)));
            Monitor_1.MenuItems.Add(new MenuItem("180°", new EventHandler(le_monitor1)));
            Monitor_1.MenuItems.Add(new MenuItem("270°", new EventHandler(jobbra_monitor1)));
            MenuItem Monitor_2 = new MenuItem("Monitor 2");
            Monitor_2.MenuItems.Add(new MenuItem("0°", new EventHandler(fel_monitor2)));
            Monitor_2.MenuItems.Add(new MenuItem("90°", new EventHandler(balra_monitor2)));
            Monitor_2.MenuItems.Add(new MenuItem("180°", new EventHandler(le_monitor2)));
            Monitor_2.MenuItems.Add(new MenuItem("270°", new EventHandler(jobbra_monitor2)));
            MenuItem Monitor_3 = new MenuItem("Monitor 3");
            Monitor_3.MenuItems.Add(new MenuItem("0°", new EventHandler(fel_monitor3)));
            Monitor_3.MenuItems.Add(new MenuItem("90°", new EventHandler(balra_monitor3)));
            Monitor_3.MenuItems.Add(new MenuItem("180°", new EventHandler(le_monitor3)));
            Monitor_3.MenuItems.Add(new MenuItem("270°", new EventHandler(jobbra_monitor3)));
            menu.MenuItems.Add(Monitor_1);
            menu.MenuItems.Add(Monitor_2);
            menu.MenuItems.Add(Monitor_3);
            MenuItem Console_Ablak = new MenuItem("Console Ablak");
            Console_Ablak.MenuItems.Add("Mutat", new EventHandler(ablak_mutat));
            Console_Ablak.MenuItems.Add("Elrejt", new EventHandler(ablak_elrejt));
            menu.MenuItems.Add(Console_Ablak);
            menu.MenuItems.Add(new MenuItem("Exit", new EventHandler(Program_exit)));
            Application.Run();
        }
        /*Forgatasok*/
        private static void fel_monitor1(object sender, EventArgs e)
        {
            Kepernyo.Rotate(1, Kepernyo.Orientations.DEGREES_CW_0);
        }
        private static void balra_monitor1(object sender, EventArgs e)
        {
            Kepernyo.Rotate(1, Kepernyo.Orientations.DEGREES_CW_90);
        }
        private static void le_monitor1(object sender, EventArgs e)
        {
            Kepernyo.Rotate(1, Kepernyo.Orientations.DEGREES_CW_180);
        }
        private static void jobbra_monitor1(object sender, EventArgs e)
        {
            Kepernyo.Rotate(1, Kepernyo.Orientations.DEGREES_CW_270);
        }
        private static void fel_monitor2(object sender, EventArgs e)
        {
            Kepernyo.Rotate(2, Kepernyo.Orientations.DEGREES_CW_0);
        }
        private static void balra_monitor2(object sender, EventArgs e)
        {
            Kepernyo.Rotate(2, Kepernyo.Orientations.DEGREES_CW_90);
        }
        private static void le_monitor2(object sender, EventArgs e)
        {
            Kepernyo.Rotate(2, Kepernyo.Orientations.DEGREES_CW_180);
        }
        private static void jobbra_monitor2(object sender, EventArgs e)
        {
            Kepernyo.Rotate(2, Kepernyo.Orientations.DEGREES_CW_270);
        }
        private static void fel_monitor3(object sender, EventArgs e)
        {
            Kepernyo.Rotate(3, Kepernyo.Orientations.DEGREES_CW_0);
        }
        private static void balra_monitor3(object sender, EventArgs e)
        {
            Kepernyo.Rotate(3, Kepernyo.Orientations.DEGREES_CW_90);
        }
        private static void le_monitor3(object sender, EventArgs e)
        {
            Kepernyo.Rotate(3, Kepernyo.Orientations.DEGREES_CW_180);
        }
        private static void jobbra_monitor3(object sender, EventArgs e)
        {
            Kepernyo.Rotate(3, Kepernyo.Orientations.DEGREES_CW_270);
        }
        private static void Program_exit(object sender, EventArgs e)
        {
            Application.Exit();
            Environment.Exit(1);
        }
        /*Forgatasok*/
        private static void ablak_mutat(object sender,EventArgs e)
        {
            var handle = GetConsoleWindow();
            ShowWindow(handle, SW_SHOW);
        }
        private static void ablak_elrejt(object sender, EventArgs e)
        {
            var handle = GetConsoleWindow();
            ShowWindow(handle, SW_HIDE);
        }
        static void HotKeyManager_HotKeyPressed(object sender, HotKeyEventArgs e)
        {
            switch (e.Key.ToString())
            {
                case "Up":
                    Kepernyo.Rotate(2, Kepernyo.Orientations.DEGREES_CW_0);
                    Console.WriteLine("2-es monitor, alaphelyzet");
                    break;
                case "Down":
                    Kepernyo.Rotate(2, Kepernyo.Orientations.DEGREES_CW_180);
                    Console.WriteLine("2-es monitor, fejjel lefelé");
                    break;
                case "Left":
                    Kepernyo.Rotate(2, Kepernyo.Orientations.DEGREES_CW_90);
                    Console.WriteLine("2-es monitor, balra fordulva");
                    break;
                case "Right":
                    Kepernyo.Rotate(2, Kepernyo.Orientations.DEGREES_CW_270);
                    Console.WriteLine("2-es monitor, jobbra fordulva");
                    break;
            }
            Console.WriteLine("Hit me!");
            Console.WriteLine(e.Key.ToString());
        }
    }
    public static class HotKeyManager
    {
        public static event EventHandler<HotKeyEventArgs> HotKeyPressed;

        public static int RegisterHotKey(Keys key, KeyModifiers modifiers)
        {
            _windowReadyEvent.WaitOne();
            int id = System.Threading.Interlocked.Increment(ref _id);
            _wnd.Invoke(new RegisterHotKeyDelegate(RegisterHotKeyInternal), _hwnd, id, (uint)modifiers, (uint)key);
            return id;
        }

        public static void UnregisterHotKey(int id)
        {
            _wnd.Invoke(new UnRegisterHotKeyDelegate(UnRegisterHotKeyInternal), _hwnd, id);
        }

        delegate void RegisterHotKeyDelegate(IntPtr hwnd, int id, uint modifiers, uint key);
        delegate void UnRegisterHotKeyDelegate(IntPtr hwnd, int id);

        private static void RegisterHotKeyInternal(IntPtr hwnd, int id, uint modifiers, uint key)
        {
            RegisterHotKey(hwnd, id, modifiers, key);
        }

        private static void UnRegisterHotKeyInternal(IntPtr hwnd, int id)
        {
            UnregisterHotKey(_hwnd, id);
        }

        private static void OnHotKeyPressed(HotKeyEventArgs e)
        {
            if (HotKeyManager.HotKeyPressed != null)
            {
                HotKeyManager.HotKeyPressed(null, e);
            }
        }

        private static volatile MessageWindow _wnd;
        private static volatile IntPtr _hwnd;
        private static ManualResetEvent _windowReadyEvent = new ManualResetEvent(false);
        static HotKeyManager()
        {
            Thread messageLoop = new Thread(delegate ()
            {
                Application.Run(new MessageWindow());
            });
            messageLoop.Name = "MessageLoopThread";
            messageLoop.IsBackground = true;
            messageLoop.Start();
        }

        private class MessageWindow : Form
        {
            public MessageWindow()
            {
                _wnd = this;
                _hwnd = this.Handle;
                _windowReadyEvent.Set();
            }

            protected override void WndProc(ref Message m)
            {
                if (m.Msg == WM_HOTKEY)
                {
                    HotKeyEventArgs e = new HotKeyEventArgs(m.LParam);
                    HotKeyManager.OnHotKeyPressed(e);
                }

                base.WndProc(ref m);
            }

            protected override void SetVisibleCore(bool value)
            {
                // Ensure the window never becomes visible
                base.SetVisibleCore(false);
            }

            private const int WM_HOTKEY = 0x312;
        }

        [DllImport("user32", SetLastError = true)]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);

        [DllImport("user32", SetLastError = true)]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        private static int _id = 0;
    }


    public class HotKeyEventArgs : EventArgs
    {
        public readonly Keys Key;
        public readonly KeyModifiers Modifiers;

        public HotKeyEventArgs(Keys key, KeyModifiers modifiers)
        {
            this.Key = key;
            this.Modifiers = modifiers;
        }

        public HotKeyEventArgs(IntPtr hotKeyParam)
        {
            uint param = (uint)hotKeyParam.ToInt64();
            Key = (Keys)((param & 0xffff0000) >> 16);
            Modifiers = (KeyModifiers)(param & 0x0000ffff);
        }
    }

    [Flags]
    public enum KeyModifiers
    {
        Alt = 1,
        Control = 2,
        Shift = 4,
        Windows = 8,
        NoRepeat = 0x4000
    }
}