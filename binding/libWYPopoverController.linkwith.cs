using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("libWYPopoverController.a", LinkTarget.Simulator | LinkTarget.ArmV7 | LinkTarget.ArmV7s, SmartLink = true, ForceLoad = true)]
