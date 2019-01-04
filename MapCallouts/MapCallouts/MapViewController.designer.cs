// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace MapCallouts
{
    [Register ("MapViewController")]
    partial class MapViewController
    {
        [Outlet]
        MapKit.MKMapView mapView { get; set; }


        [Action ("ShowAllAnnotations:")]
        partial void ShowAllAnnotations (Foundation.NSObject sender);


        [Action ("ShowOnlyBridgeAnnotation:")]
        partial void ShowOnlyBridgeAnnotation (Foundation.NSObject sender);


        [Action ("ShowOnlyFerryBuildingAnnotation:")]
        partial void ShowOnlyFerryBuildingAnnotation (Foundation.NSObject sender);


        [Action ("ShowOnlyFlowerAnnotation:")]
        partial void ShowOnlyFlowerAnnotation (Foundation.NSObject sender);


        [Action ("ShowOnlySanFranciscoAnnotation:")]
        partial void ShowOnlySanFranciscoAnnotation (Foundation.NSObject sender);

        void ReleaseDesignerOutlets ()
        {
            if (mapView != null) {
                mapView.Dispose ();
                mapView = null;
            }
        }
    }
}