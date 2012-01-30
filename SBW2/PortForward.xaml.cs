﻿using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows;
using System.Windows.Interop;
using System.Windows.Media;
using NATUPNPLib;

namespace SBW2
{

    public partial class PortForward : Window
    {

        public PortForward()
        {
            InitializeComponent();

            PopulateUpnpData();
        }

        [DllImport("dwmapi.dll")]
        private static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref Margins pMargins);

        [DllImport("dwmapi.dll", PreserveSig = false)]
        private static extern bool DwmIsCompositionEnabled();

        [StructLayout(LayoutKind.Sequential)]
        private class Margins
        {
            public int cxLeftWidth, cxRightWidth,
                cyTopHeight, cyBottomHeight;
        }

        private void WindowLoaded(object sender, RoutedEventArgs e)
        {
            EnableGlass();

        }

        private void EnableGlass()
        {
            if (Environment.OSVersion.Version.Major < 6 || !DwmIsCompositionEnabled()) return;
            // Get the current window handle
            var mainWindowPtr = new WindowInteropHelper(this).Handle;
            var mainWindowSrc = HwndSource.FromHwnd(mainWindowPtr);
            if (mainWindowSrc != null)
                if (mainWindowSrc.CompositionTarget != null)
                    mainWindowSrc.CompositionTarget.BackgroundColor = Colors.Transparent;
                else return;
            else return;

            Background = Brushes.Transparent;

            // Set the proper margins for the extended glass part
            var margins = new Margins {cxLeftWidth = -1, cxRightWidth = -1, cyTopHeight = -1, cyBottomHeight = -1};

            DwmExtendFrameIntoClientArea(mainWindowSrc.Handle, ref margins);
        }

        private void PopulateUpnpData()
        {
            if (Net.UpnPnatHelper.StaticPortMappings == null)
            {
                Dispatcher.BeginInvoke(new Action(() =>
                                                      {
                                                          MessageBox.Show(Properties.Resources.NO_UPNP);
                                                          Close();
                                                      }));
                return;
            }

            Visibility = Visibility.Visible;

            foreach (IStaticPortMapping smapping in Net.UpnPnatHelper.StaticPortMappings)
            {
                UpnpList.Items.Add(smapping);
            }
        }
    }
}