// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace MagneticField.iOS
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        UIKit.UIButton Button { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIProgressView progres_z { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIProgressView progress_x { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIProgressView progress_y { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (progres_z != null) {
                progres_z.Dispose ();
                progres_z = null;
            }

            if (progress_x != null) {
                progress_x.Dispose ();
                progress_x = null;
            }

            if (progress_y != null) {
                progress_y.Dispose ();
                progress_y = null;
            }
        }
    }
}